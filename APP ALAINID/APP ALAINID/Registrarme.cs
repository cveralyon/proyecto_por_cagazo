﻿using Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_ALAINID
{
    public partial class Registrarme : Form
    {
        public Registrarme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_crearcuenta_Click(object sender, EventArgs e)
        {
            string nombre = registro_nombre.Text + " " + registro_apellido.Text;
            User user = new User(nombre, registro_nombre_usuario.Text, registro_correo.Text, registro_contraseña.Text);
           
            foreach (User user1 in ALAINID.listausuarios)
            {
                if (user.Nombreusuario == user1.Nombreusuario)
                {
                    Usuario_ya_Existe usuario_Ya_Existe = new Usuario_ya_Existe();
                }
                else if (user.Email_ == user1.Email_)
                {
                    correo_usadp correo_Usadp = new correo_usadp();
                }

            }
            ALAINID.Activarlista();
            ALAINID.Agregarusuarioalalista(user);
        }
    }
}
