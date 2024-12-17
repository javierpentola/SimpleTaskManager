using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionTareasApp
{
    public partial class Form1 : Form
    {
        private List<Tarea> tareas;

        public Form1()
        {
            InitializeComponent();
            tareas = new List<Tarea>();
        }

        // Cargar la lista de tareas en el ListBox
        private void ActualizarLista()
        {
            lstTareas.Items.Clear();
            foreach (var tarea in tareas)
            {
                string estado = tarea.Completada ? "Completada" : "Pendiente";
                lstTareas.Items.Add($"{tarea.Descripcion} - {estado}");
            }
        }

        // Evento para agregar una tarea
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                return;
            }
            tareas.Add(new Tarea { Descripcion = txtDescripcion.Text, Completada = false });
            txtDescripcion.Clear();
            ActualizarLista();
        }

        // Evento para marcar una tarea como completada
        private void btnMarcarCompletada_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una tarea para marcar como completada.");
                return;
            }

            int index = lstTareas.SelectedIndex;
            tareas[index].Completada = true;
            ActualizarLista();
        }

        // Evento para eliminar una tarea
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una tarea para eliminar.");
                return;
            }

            int index = lstTareas.SelectedIndex;
            tareas.RemoveAt(index);
            ActualizarLista();
        }
    }

    public class Tarea
    {
        public string Descripcion { get; set; }
        public bool Completada { get; set; }
    }
}
