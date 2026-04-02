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
    public partial class FormMaterias : Form
    {
        SistemaCalificacionesEntities db = new SistemaCalificacionesEntities();

        public FormMaterias()
        {
            InitializeComponent();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                var listaMaterias = db.Materias.Select(m => new
                {
                    m.MateriaID,
                    m.NombreMateria

                }).ToList();

                dgvMaterias.DataSource = listaMaterias;

                dgvMaterias.Columns["MateriaID"].HeaderText = "ID Materia";
                dgvMaterias.Columns["NombreMateria"].HeaderText = "Nombre Materia";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las materias: " + ex.Message);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreMateria.Text))
            {
                MessageBox.Show("Por favor, escribe el nombre de la materia.");
                return;
            }

            try
            {
                Materias nuevaMateria = new Materias();

                nuevaMateria.MateriaID = int.Parse(txtID.Text);

                nuevaMateria.NombreMateria = txtNombreMateria.Text;

                db.Materias.Add(nuevaMateria);
                db.SaveChanges();

                MessageBox.Show("¡Materia agregada con éxito!");
                txtNombreMateria.Clear();
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
                MessageBox.Show("Ingresa el ID de la materia que vas a actualizar.");
                return;
            }

            try
            {
                int idBuscar = int.Parse(txtID.Text);
                var materiaExistente = db.Materias.Find(idBuscar);

                if (materiaExistente != null)
                {
                    materiaExistente.NombreMateria = txtNombreMateria.Text;

                    db.SaveChanges();

                    MessageBox.Show("¡Materia actualizada con éxito!");
                    txtID.Clear();
                    txtNombreMateria.Clear();
                    btnMostrar.PerformClick();
                }
                else
                {
                    MessageBox.Show("No se encontró una materia con ese ID.");
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
                MessageBox.Show("Ingresa el ID de la materia a eliminar.");
                return;
            }

            try
            {
                int idEliminar = int.Parse(txtID.Text);
                var materiaEliminar = db.Materias.Find(idEliminar);

                if (materiaEliminar != null)
                {
                    db.Materias.Remove(materiaEliminar);
                    db.SaveChanges();

                    MessageBox.Show("¡Materia eliminada con éxito!");
                    txtID.Clear();
                    btnMostrar.PerformClick();
                }
                else
                {
                    MessageBox.Show("No se encontró una materia con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No puedes borrar esta materia porque ya tiene estudiantes calificados en ella.\nError: " + ex.Message, "Alerta de Base de Datos");
            }
        }
    }
}