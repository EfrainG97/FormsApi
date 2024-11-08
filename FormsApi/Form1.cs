using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsApi.Model;
using FormsApi.Controller;

namespace FormsApi
{
    public partial class Form1 : Form
    {
        AlumnoController ac = new AlumnoController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private async void CargarAlumnos()
        {
            DGVAlumno.DataSource = null;
            DGVAlumno.DataSource = await ac.GetAlumnos();
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBNombre.Text) || TBNombre.Text.Length < 3)
            {
                MessageBox.Show("El nombre es obligatorio y debe tener al menos 3 caracteres");
                return;
            }

            int edadv = Convert.ToInt32(TBEdad.Text);

            if (edadv < 0 && edadv > 99)
            {
                MessageBox.Show("Por favor, introduce una edad valida");
                return;
            }

            DateTime fechaseleccionada = DTPFecha.Value;
            string fechamysql = fechaseleccionada.ToString("yyyy-MM-dd");

            if (await ac.AgregarAlumno(new Alumno { Nombre = TBNombre.Text, Edad = edadv, FechaNacimiento = fechaseleccionada }))
            {
                MessageBox.Show("Alumno Agregado con Exito");
                Limpiar(this);
            }
            else
            {
                MessageBox.Show("Hubo un problema al agregar el alumno");
            }

        }
        
        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        void Limpiar(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (await ac.EliminarAlumno(Convert.ToInt32(TBID.Text)))
            {
                MessageBox.Show("Alumno eliminado con exito");
                CargarAlumnos();
                Limpiar(this);
            }
        }

        private async void BtnCargar_Click(object sender, EventArgs e)
        {
            var lista = await ac.ObtenerAlumnoID(Convert.ToInt32(TBID.Text));

            TBNombre.Text= lista.Nombre.ToString();
            TBEdad.Text= lista.Edad.ToString();
            DTPFecha.Value = lista.FechaNacimiento;
        }

        private async void BtnAct_Click(object sender, EventArgs e)
        {
           
            int edadv = Convert.ToInt32(TBEdad.Text);
            DateTime fechaseleccionada = DTPFecha.Value;
            string fechamysql = fechaseleccionada.ToString("yyyy-MM-dd");

            if (await ac.ActualizarAlumno(Convert.ToInt32(TBID.Text), new Alumno(Convert.ToInt32(TBID.Text), TBNombre.Text, edadv, fechaseleccionada)))
            {
                MessageBox.Show("Alumno actualizado con Exito");
                CargarAlumnos();
                Limpiar(this);
            }
            else
            {
                MessageBox.Show("Hubo un problema al actualizar el alumno");
            }

        }
    }
}
