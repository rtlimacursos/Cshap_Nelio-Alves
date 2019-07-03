using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultarCeps
{
    public partial class FrmConsultarCeps : Form
    {
        public FrmConsultarCeps()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txtCep.Text.Trim());

                        TxtEstado.Text = endereco.uf;
                        txtCidade.Text = endereco.cidade;
                        txtRua.Text = endereco.end;
                        txtBairro.Text = endereco.bairro;
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido..", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCep.Text     = string.Empty;
            TxtEstado.Text  = string.Empty;
            txtRua.Text     = string.Empty;
            txtCidade.Text  = string.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
