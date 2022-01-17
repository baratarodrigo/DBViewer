﻿using PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms.Forms_principais.Form_configuracoes.Área;
using PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms.Forms_principais.Form_configuracoes.sub_area;
using PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms.Forms_principais.Form_configuracoes.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms
{
    public partial class logiinadmin : Form

    {
        private Form currentChildForm;
        public logiinadmin()
        {
            InitializeComponent();
            panel_config.Hide();

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Equals("Admin") && txtpass.Text.Equals("Admin"))
            {
                panel_config.Show();
            }
            else
            {
                MessageBox.Show("User e Password errados");
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_config_desk.Controls.Add(childForm);
            panel_config_desk.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new consultar_areas());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new consultar_subarea());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new users());
        }
    }
}
