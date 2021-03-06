﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using PagoElectronico.ABM_Rol;
using PagoElectronico.ABM_Cliente;
using PagoElectronico.ABM_Cuenta;
using PagoElectronico.ABM_Usuario;
using PagoElectronico.Consulta_Saldos;
using PagoElectronico.Depositos;
using PagoElectronico.Facturacion;
using PagoElectronico.Retiros;
using PagoElectronico.Transferencias;
using PagoElectronico.Listados;
using PagoElectronico.DAO;
using PagoElectronico.Dominio;

namespace PagoElectronico.Login
{
    public partial class FormRolesFuncionalidades : Form
    {
        Roles roles;
        List<string> listaFuncionalidades;
        public int idUser;

        public FormRolesFuncionalidades(int idUsuario)
        {
            idUser = idUsuario;
            InitializeComponent();
            GestorLogin gestorLogin = new GestorLogin();
            roles = gestorLogin.GetRolesXFuncionalidades(idUser);
            int i;
            if (roles.roles.Count == 1)
            {
                /*lockear combobox1 y mostrar el rol*/
                label1.Text = "Unico Rol = " + roles.roles.GetKey(0).ToString();
                comboBox1.Text = roles.roles.GetKey(0).ToString();
                comboBox1.Hide();
                int j;
                List<string> listaFuncionalidades;
                listaFuncionalidades = (List<string>)roles.roles.GetByIndex(0);
                for (j = 0; j < listaFuncionalidades.Count; j++)
                {
                    comboBox2.Items.Add(listaFuncionalidades[j].ToString());
                }
            }
            else
            {
                for (i = 0; i < roles.roles.Count; i++)
                {
                    label1.Hide();
                    comboBox1.Items.Add(roles.roles.GetKey(i));
                }
            }            
        }
        private void FormRoles_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int j;
            listaFuncionalidades = (List<string>)roles.roles.GetByIndex(roles.roles.IndexOfKey(comboBox1.Text));

            for (comboBox2.ResetText(), comboBox2.Items.Clear(), j = 0; j < listaFuncionalidades.Count; j++) comboBox2.Items.Add(listaFuncionalidades[j].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "ABM de rol":
                    FormABMRol formABMRol = new FormABMRol();
                    formABMRol.Show(this);
                    break;
                case "ABM de usuario":
                    FormModificacionUsuario formModificacionUsuario = new FormModificacionUsuario();
                    formModificacionUsuario.Show(this);
                    break;
                case "ABM de cliente":
                    FormABMCliente formABMCliente = new FormABMCliente();
                    formABMCliente.Show(this);
                    break;
                case "ABM de cuenta":
                    FormABMCuenta formABMCuenta = new FormABMCuenta();
                    formABMCuenta.Show(this);
                    break;
                /*case "asociar/desasociar tarjetas de credito":
                    Form form = new Form();
                    form.Show(this);
                    break;TODO*/
                case "depositos":
                    FormDeposito formDeposito = new FormDeposito();
                    formDeposito.Show(this);
                    break;
                case "retiro":
                    FormRetiro formRetiro = new FormRetiro();
                    formRetiro.Show(this);
                    break;
                case "transferencias":
                    FormTransferencia formTransferencia = new FormTransferencia();
                    formTransferencia.Show(this);
                    break;
                case "facturacion":
                    FormFacturacion formFacturacion = new FormFacturacion();
                    formFacturacion.Show(this);
                    break;
                case "consulta saldos":
                    FormConsultaSaldo formConsultaSaldo = new FormConsultaSaldo(idUser);
                    formConsultaSaldo.Show(this);
                    break;
                case "listado estadistico":
                    FormListado formListado = new FormListado(idUser);
                    formListado.Show(this);
                    break;
                default:
                    break;
            }
            if (comboBox2.Text != "Seleccione Funcionalidad")
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Elija un Rol/Funcionalidad");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
