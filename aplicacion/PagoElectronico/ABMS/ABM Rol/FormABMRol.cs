using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PagoElectronico.DAO;
using PagoElectronico.Dominio;

namespace PagoElectronico.ABM_Rol
{
    public partial class FormABMRol : Form
    {
        public FormABMRol()
        {
            InitializeComponent();
        }

        private void FormABMRol_Load(object sender, EventArgs e)
        {
            dataGridRoles.DataSource = findAll();         
        }
        
        private List<Rol> findAll()
        {
            var roles = new List<Rol>();
            Rol rol = null;

            try
            {
                SqlDataReader myReader = null;
                var myCommand = new SqlCommand("SELECT * FROM [SUDO].[Rol]" + getFiltros(), DAO.ConexionDB.conexionDB);

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    rol = new Rol(myReader);
                    roles.Add(rol);
                }

                myReader.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return roles;
        }

        private string getFiltros()
        {
            string filtros = " WHERE "; 
            
            if (nombre.Text != null)
            {
                filtros += "nombreRol LIKE '%" + nombre.Text + "%'";
            }
            else
            {
                filtros += "1";
            }
            if (estado.SelectedItem != null)
            {
                if (estado.SelectedItem.ToString() == "Activos")
                {
                    filtros += " AND estado = 1";
                }
                if (estado.SelectedItem.ToString() == "Inactivos")
                {
                    filtros += " AND estado = 0";
                }
            }

            return filtros;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            dataGridRoles.DataSource = findAll();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre.Clear();
            estado.Text = "Todos";
        }

        private void dataGridRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) 
            {
                MessageBox.Show("Editar");
            }
            if (e.ColumnIndex == 3)
            {
                const string mensaje = "Esta seguro que quiere eliminar este registro?";
                const string titulo = "Eliminar registro";
                var result = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Eliminar");
                }
            }
        }


    }
}
