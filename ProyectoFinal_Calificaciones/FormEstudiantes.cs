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
    public partial class FormEstudiantes : Form
    {
        SistemaCalificacionesEntities db = new SistemaCalificacionesEntities();

        public FormEstudiantes()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = db.Estudiante.Select(est => new
                {
                    est.EstudianteID,
                    est.NombreCompleto,
                    est.Matricula
                }).ToList();

                dgvEstudiantes.DataSource = lista;

                dgvEstudiantes.Columns["EstudianteID"].HeaderText = "ID Materia";
                dgvEstudiantes.Columns["NombreCompleto"].HeaderText = "Nombre Completo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar: " + ex.Message);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text) || string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Por favor, llena el Nombre Completo y la Matrícula.");
                return;
            }

            try
            {
                Estudiante nuevoEstudiante = new Estudiante();

                nuevoEstudiante.EstudianteID = int.Parse(txtID.Text);

                nuevoEstudiante.NombreCompleto = txtNombreCompleto.Text;
                nuevoEstudiante.Matricula = txtMatricula.Text;

                db.Estudiante.Add(nuevoEstudiante);
                db.SaveChanges();

                MessageBox.Show("¡Estudiante agregado correctamente!");
                txtNombreCompleto.Clear();
                txtMatricula.Clear();
                btnMostrar.PerformClick(); 
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
                MessageBox.Show("Por favor, ingresa el ID del estudiante que deseas actualizar.");
                return;
            }

            try
            {
                int idBuscar = int.Parse(txtID.Text);
                var estExistente = db.Estudiante.Find(idBuscar);

                if (estExistente != null)
                {
                    estExistente.NombreCompleto = txtNombreCompleto.Text;
                    estExistente.Matricula = txtMatricula.Text;

                    db.SaveChanges();

                    MessageBox.Show("¡Estudiante actualizado correctamente!");
                    txtID.Clear();
                    txtNombreCompleto.Clear();
                    txtMatricula.Clear();
                    btnMostrar.PerformClick();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún estudiante con ese ID.");
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
                MessageBox.Show("Por favor, ingresa el ID del estudiante que deseas eliminar.");
                return;
            }

            try
            {
                int idEliminar = int.Parse(txtID.Text);
                var estEliminar = db.Estudiante.Find(idEliminar);

                if (estEliminar != null)
                {
                    db.Estudiante.Remove(estEliminar);
                    db.SaveChanges();

                    MessageBox.Show("¡Estudiante eliminado correctamente!");
                    txtID.Clear();
                    btnMostrar.PerformClick();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún estudiante con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No puedes eliminar a este estudiante porque ya tiene calificaciones asignadas.\nError: " + ex.Message, "Alerta de integridad");
            }
        }

    }
}
