using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Saludame(object sender, EventArgs e)
        {
       
        }

        private void BuscarClick(object sender, EventArgs e)
        {
            string valor = txtClick.Text;

         DialogResult respuesta =    MessageBox.Show(
                                                "Esta seguro de buscar a " + valor,
                                                "Sistema de busqueda",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Question
                                                );
            switch (respuesta) {
                case DialogResult.OK:
                    grbResultado.Visible = true;
                    txtResultado.Text = valor;
                    break;
                case DialogResult.Cancel:
                    txtClick.Text = "";//limpiar la caja texto
                    txtClick.Focus();  // retornar el puntero acaja
                    txtClick.Select(); //selec activa el puntero
                    break;
                default:
                    MessageBox.Show("no hiciste anda ...");
                    break; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtClick.Text = txtKeyPress.Text = txtLostFocus.Text= txtResultado.Text = "";
            cbxChange.SelectedText = "";
            grbResultado.Visible = false;
        }

        private void CambiaSeleccion(object sender, EventArgs e)
        {
            string valor = cbxChange.Text;
            DialogResult respuesta = MessageBox.Show(
                                               "Esta seguro de buscar a " + valor,
                                               "Sistema de busqueda ItemChange",
                                               MessageBoxButtons.OKCancel,
                                               MessageBoxIcon.Question
                                               );
            switch (respuesta)
            {
                case DialogResult.OK:
                    grbResultado.Visible = true;
                    txtResultado.Text = valor;
                    break;
                case DialogResult.Cancel:
                    cbxChange.SelectedText = "";//limpiar la caja texto
                    cbxChange.Focus();  // retornar el puntero acaja
                    cbxChange.Select(); //selec activa el puntero
                    break;
                default:
                    MessageBox.Show("no hiciste anda ...");
                    break;
            }
        }

        private void buscarLostFocus(object sender, CancelEventArgs e)
        {

        }

        private void buscarLostFocus(object sender, EventArgs e)
        {
            string valor = txtLostFocus.Text;
            DialogResult respuesta = MessageBox.Show(
                                   "Esta seguro de buscar a " + valor,
                                   "Sistema de busqueda Validating",
                                   MessageBoxButtons.OKCancel,
                                   MessageBoxIcon.Question
                                   );
            switch (respuesta)
            {
                case DialogResult.OK:
                    grbResultado.Visible = true;
                    txtResultado.Text = valor;
                    break;
                case DialogResult.Cancel:
                    txtLostFocus.Text = "";//limpiar la caja texto
                    txtLostFocus.Focus();  // retornar el puntero acaja
                    txtLostFocus.Select(); //selec activa el puntero
                    break;
                default:
                    MessageBox.Show("no hiciste anda ...");
                    break;
            }
        }

        private void buscarKeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void BuscarKeyUp(object sender, KeyEventArgs e)
        {
            string valor = txtKeyPress.Text;
            DialogResult respuesta = MessageBox.Show(
                                   "Esta seguro de buscar a " + valor,
                                   "Sistema de busqueda KeyPress",
                                   MessageBoxButtons.OKCancel,
                                   MessageBoxIcon.Question
                                   );
            switch (respuesta)
            {
                case DialogResult.OK:
                    grbResultado.Visible = true;
                    txtResultado.Text = valor;
                    break;
                case DialogResult.Cancel:
                    txtKeyPress.Text = "";//limpiar la caja texto
                    txtKeyPress.Focus();  // retornar el puntero acaja
                    txtKeyPress.Select(); //selec activa el puntero
                    break;
                default:
                    MessageBox.Show("no hiciste anda ...");
                    break;
            }
        }
    }
}
