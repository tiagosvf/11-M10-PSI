using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestClubBest
{
    public partial class FormAdicionar : Form
    {


        public FormAdicionar()
        {


            InitializeComponent();



            cbo_tipo.Text = "Selecione o tipo";



           

        }

        private void cbo_tipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_tipo.SelectedIndex == 0)
                txt_apeso.Enabled = false;
            else
                txt_apeso.Enabled = true;

        }



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                string message = "Tem a certeza que quer saír?";
                string caption = "Programa pronto para fechar";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btn_aadicionar_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Convert.ToString(Global.clube.listaPessoasClube.Count()));
            if (cbo_tipo.SelectedIndex == 0)
            {
               
                    if (Global.clube.GetCountSocios() == 0)
                    {
                        DateTime data = Convert.ToDateTime(msk_data.Text);
                        Global.clube.InserirPessoa(new Socio(txt_anome.Text, data, new Morada(txt_arua.Text,txt_alocalidade.Text, msk_codigo.Text), 1));
                        MessageBox.Show("Adicionado com sucesso!\n O seu numero de socio é: 1", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {

                        DateTime data = Convert.ToDateTime(msk_data.Text);
                        Global.clube.InserirPessoa(new Socio(txt_anome.Text, data, new Morada(txt_arua.Text, txt_alocalidade.Text, msk_codigo.Text),  1));
                        MessageBox.Show("Adicionado com sucesso!\n O seu numero de socio é: " + 1, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                MessageBox.Show(Convert.ToString(Global.clube.listaPessoasClube.Count()));
                
            }
            else if (cbo_tipo.SelectedIndex == 1)
            {

                DateTime data = Convert.ToDateTime(msk_data.Text);
                Global.clube.InserirPessoa(new Atleta(txt_anome.Text, data, new Morada(txt_arua.Text, txt_alocalidade.Text, msk_codigo.Text), Convert.ToInt32(txt_apeso.Text)));
                MessageBox.Show("Adicionado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            




           
        }

        private void btn_avoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }






    }
}
    

 

