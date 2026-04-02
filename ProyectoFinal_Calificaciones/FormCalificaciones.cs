using ProyectoFinal_Calificaciones.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Calificaciones
{
    public partial class FormCalificaciones : Form
    {
        SistemaCalificacionesEntities db = new SistemaCalificacionesEntities(); // Base de DATOS
        public FormCalificaciones()
        {
            InitializeComponent();
        }

        private void FormCalificaciones_Load(object sender, EventArgs e)
        {
            try
            {
                cmbEstudiante.DisplayMember = "NombreCompleto";
                cmbEstudiante.ValueMember = "EstudianteID";
                cmbEstudiante.DataSource = db.Estudiante.ToList();

                cmbMateria.DisplayMember = "NombreMateria";
                cmbMateria.ValueMember = "MateriaID";
                cmbMateria.DataSource = db.Materias.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las listas: " + ex.Message);
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Traer los datos
                var listaCalificaciones = db.Calificacion.Select(c => new
                {
                    c.ID,
                    Estudiante = c.Estudiante.NombreCompleto,
                    Materia = c.Materias.NombreMateria,
                    C1 = c.Calificacion1,
                    C2 = c.Calificacion2,
                    C3 = c.Calificacion3,
                    C4 = c.Calificacion4,
                    c.Examen,
                    Total = c.TotalCalificacion,
                    c.Clasificacion,
                    c.Estado
                }).ToList();

                dgvCalificaciones.DataSource = listaCalificaciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal c1 = decimal.Parse(txtC1.Text);
                decimal c2 = decimal.Parse(txtC2.Text);
                decimal c3 = decimal.Parse(txtC3.Text);
                decimal c4 = decimal.Parse(txtC4.Text);
                decimal examen = decimal.Parse(txtExamen.Text);

                // Validar que las notas no se pasen de 100 ni bajen de 0
                if (c1 > 100 || c2 > 100 || c3 > 100 || c4 > 100 || examen > 100 ||
                    c1 < 0 || c2 < 0 || c3 < 0 || c4 < 0 || examen < 0)
                {
                    MessageBox.Show("Todas las calificaciones deben estar entre 0 y 100.");
                    return;
                }

                Calificacion nuevaNota = new Calificacion();

                nuevaNota.ID = int.Parse(txtID.Text);

                // Para Guardar los ids seleccionados en los ComboBox
                nuevaNota.EstudianteID = (int)cmbEstudiante.SelectedValue;
                nuevaNota.MateriaID = (int)cmbMateria.SelectedValue;

                nuevaNota.Calificacion1 = c1;
                nuevaNota.Calificacion2 = c2;
                nuevaNota.Calificacion3 = c3;
                nuevaNota.Calificacion4 = c4;
                nuevaNota.Examen = examen;

                decimal totalCalculado = (((c1 + c2 + c3 + c4) / 4m) * 0.70m) + (examen * 0.30m);

                nuevaNota.TotalCalificacion = Math.Round(totalCalculado, 2);

                nuevaNota.Clasificacion = totalCalculado >= 90 ? "A" : totalCalculado >= 80 ? "B" : totalCalculado >= 70 ? "C" : "F";

                nuevaNota.Estado = totalCalculado >= 70 ? "Aprobado" : "Reprobado";

                db.Calificacion.Add(nuevaNota);
                db.SaveChanges();

                MessageBox.Show($"¡Calificación guardada!\nTotal: {nuevaNota.TotalCalificacion}\nLetra: {nuevaNota.Clasificacion}");

                txtC1.Clear(); txtC2.Clear(); txtC3.Clear(); txtC4.Clear(); txtExamen.Clear();
                btnMostrar.PerformClick();
            }
            catch (FormatException)
            {
                MessageBox.Show("solo esta permitido agregar números en las calificaciones.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Ingresa el ID de la calificación para actualizar.");
                return;
            }

            try
            {
                int idBuscar = int.Parse(txtID.Text);
                var notaExistente = db.Calificacion.Find(idBuscar);

                if (notaExistente != null)
                {
                    decimal c1 = decimal.Parse(txtC1.Text);
                    decimal c2 = decimal.Parse(txtC2.Text);
                    decimal c3 = decimal.Parse(txtC3.Text);
                    decimal c4 = decimal.Parse(txtC4.Text);
                    decimal examen = decimal.Parse(txtExamen.Text);

                    notaExistente.EstudianteID = (int)cmbEstudiante.SelectedValue;
                    notaExistente.MateriaID = (int)cmbMateria.SelectedValue;
                    notaExistente.Calificacion1 = c1;
                    notaExistente.Calificacion2 = c2;
                    notaExistente.Calificacion3 = c3;
                    notaExistente.Calificacion4 = c4;
                    notaExistente.Examen = examen;

                    // Recalcular al actualizar
                    decimal totalCalculado = (((c1 + c2 + c3 + c4) / 4m) * 0.70m) + (examen * 0.30m);
                    notaExistente.TotalCalificacion = Math.Round(totalCalculado, 2);
                    notaExistente.Clasificacion = totalCalculado >= 90 ? "A" : totalCalculado >= 80 ? "B" : totalCalculado >= 70 ? "C" : "F";
                    notaExistente.Estado = totalCalculado >= 70 ? "Aprobado" : "Reprobado";

                    db.SaveChanges();

                    MessageBox.Show("¡Calificación actualizada!");
                    txtID.Clear(); txtC1.Clear(); txtC2.Clear(); txtC3.Clear(); txtC4.Clear(); txtExamen.Clear();
                    btnMostrar.PerformClick();
                }
                else
                {
                    MessageBox.Show("No se encontró ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Ingresa el ID de la calificación para eliminar.");
                return;
            }

            try
            {
                int idEliminar = int.Parse(txtID.Text);
                var notaEliminar = db.Calificacion.Find(idEliminar);

                if (notaEliminar != null)
                {
                    db.Calificacion.Remove(notaEliminar);
                    db.SaveChanges();

                    MessageBox.Show("¡Registro eliminado!");
                    txtID.Clear();
                    btnMostrar.PerformClick();
                }
                else
                {
                    MessageBox.Show("No se encontró ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

    }
}

