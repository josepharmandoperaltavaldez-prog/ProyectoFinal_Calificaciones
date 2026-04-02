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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void EstudiantesStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstudiantes ventanaEstudiantes = new FormEstudiantes();
            ventanaEstudiantes.ShowDialog();
        }

        private void MateriasStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormMaterias ventanaMaterias = new FormMaterias();
            ventanaMaterias.ShowDialog();
        }

        private void CalificacionesStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormCalificaciones ventanaCalificaciones = new FormCalificaciones();
            ventanaCalificaciones.ShowDialog();
        }
    }
}
