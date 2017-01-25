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
    public partial class FormPrincipal : Form
    {


        

        string last_string_searched = "";
        int last_index_searched = 0;
        int si = 0;
        int removed = 0;
        int edited = 0;
        int actIndex = 0;

        Socio dadosSocio;
        Atleta dadosAtleta;
        

        void atualizardados(int index)
        {
            
            index = actIndex;
            if (index != Global.clube.listaPessoasClube.Count())
            {
                if (Global.clube.listaPessoasClube[index] is Socio)
                {
                    int n_socio = 0;
                    n_socio++;
                    txt_tipo.Text = "Socio";
                    txt_nome.Text = Global.clube.listaPessoasClube[index].Nome;
                    txt_rua.Text = Global.clube.listaPessoasClube[index].MoradaPessoa.Rua;
                    txt_localidade.Text = Global.clube.listaPessoasClube[index].MoradaPessoa.Localidade;
                    txt_codigo.Text = Global.clube.listaPessoasClube[index].MoradaPessoa.CodigoPostal;
                    txt_idade.Text = Global.clube.listaPessoasClube[index].Idade.ToString() + " Anos";


                }
                else if (Global.clube.listaPessoasClube[index] is Atleta)
                {
                    txt_tipo.Text = "Atleta";


                    txt_nome.Text = Global.clube.listaPessoasClube[index].Nome;
                    txt_rua.Text = Global.clube.listaPessoasClube[index].MoradaPessoa.Rua;
                    txt_localidade.Text = Global.clube.listaPessoasClube[index].MoradaPessoa.Localidade;
                    txt_codigo.Text = Global.clube.listaPessoasClube[index].MoradaPessoa.CodigoPostal;
                    txt_idade.Text = Global.clube.listaPessoasClube[index].Idade.ToString() + " Anos";
                    
                }
                
            }
        }
        public FormPrincipal()
        {
            
            InitializeComponent();



            // Insere um clube
            Global.clube = new Clube(new Pessoa("Carlos Almeida", new DateTime(1968, 11, 19), new Morada("Rua da Liberdade", "Viseu", "3500-293")));

            // Inser um sócio no clube
            Global.clube.InserirPessoa(new Socio("Tia Albertina", new DateTime(1970, 02, 04), new Morada("Rua da Paz", "Lisboa", "1300-472 Lisboa"), 0));
            Global.clube.InserirPessoa(new Socio("Tddbertina", new DateTime(1970, 02, 04), new Morada("Rua dadD Paz", "Lisboa", "1300-472 Lisboa"), 1));


            // Inser um Atleta no clube
            Global.clube.InserirPessoa(new Atleta("Perna Alta", new DateTime(1962, 09, 15), new Morada("Rua da Caminhada", "Lisboa", "1300-470 Lisboa"), 75.3));
            Global.clube.InserirPessoa(new Atleta("Boas Guys", new DateTime(1962, 09, 15), new Morada("Rua da Caminhada", "Lisboa", "1300-470 Lisboa"), 75.3));
            // Altera o treinador no Atleta
            Atleta.Treinador = new Pessoa("Treina BemMal", new DateTime(1965, 10, 02), new Morada("Rua do Dinheiro", "Porto", "4100-367 Porto"));



    




        }

        public void change_edited()
        {
            edited = 1;

        }
        public void change_removed()
        {
            removed = 1;

        }

        public void nomes_lsb()
        {
            List<string> nomesString = new List<string>();
            nomesString.Clear();
            foreach (var item in Global.clube.listaPessoasClube)
            {
                nomesString.Add(item.Nome.ToString());
            }
            lsb_pessoas.DataSource = nomesString;
            
        }


        public void verificar_lista()
        {
            if(Global.clube.listaPessoasClube.Count == 0)
            {
                
                    txt_nome.Text = "";
                    txt_rua.Text = "";
                    txt_localidade.Text ="";
                    txt_codigo.Text = "";
                    txt_idade.Text = "";
                txt_tipo.Text = "";
                txt_peso_e_nsocio.Text = "";
                txt_peso_e_nsocio.Enabled = false;
                txt_nome.Enabled = false;
                txt_rua.Enabled = false;
                txt_localidade.Enabled = false;
                txt_codigo.Enabled = false;
      
                txt_tipo.Enabled = false;
                txt_peso_e_nsocio.Enabled = false;

            }
            else
            {
                txt_nome.Enabled = true;
                txt_rua.Enabled = true;
                txt_localidade.Enabled = true;
                txt_codigo.Enabled = true;
     
      
               
            }
        }
        public void atualizar_lista()
        {

            if (removed == 1)
            {


                si = lsb_pessoas.SelectedIndex - 1;
                
            }
            else {
                si = lsb_pessoas.SelectedIndex;
            }
            // BindData();

            lsb_pessoas.DataSource = null;
            nomes_lsb();
           


            if (Global.clube.listaPessoasClube.Count != 0)
            {
                lsb_pessoas.SelectedIndex = si;
            }
        }
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            FormAdicionar fmradicionar = new FormAdicionar();
            fmradicionar.ShowDialog();
            fmradicionar.Activate();

         /*   if (fmradicionar.DialogResult == DialogResult.OK)
            {
                atualizar_lista();
            }*/
            
            nomes_lsb();

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdicionar fmradicionar = new FormAdicionar();
            fmradicionar.Show();
            fmradicionar.Activate();

            
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           

            txt_peso_e_nsocio.Enabled = false;
            txt_idade.Enabled = false;
            txt_tipo.Enabled = false;
            txt_nome.ReadOnly = true;
            txt_rua.ReadOnly = true;
            txt_localidade.ReadOnly = true;
            txt_codigo.ReadOnly = true;
            txt_peso_e_nsocio.ReadOnly = true;
            txt_idade.ReadOnly = true;



            nomes_lsb();
            /*
            {
                Socio dadossocio;
                Atleta dadosAtleta;

                foreach (var item in Global.clube.listaPessoasClube)
                {
                    if (item is Atleta)
                    {
                        dadosAtleta = (Atleta)item;
                        lbl_nome1.Text = dadosAtleta.Nome;
                        lbl_data1.Text = dadosAtleta.Idade.ToString();
                        lbl_morada1.Text = dadosAtleta.MoradaPessoa.Rua;
                        lbl_morada1.Text = dadosAtleta.MoradaPessoa.Localidade;
                        lbl_morada1.Text = dadosAtleta.MoradaPessoa.CodigoPostal;
                        label_peso.Text = dadosAtleta.Peso.ToString();

                        label_peso.Visible = true;
                        label_socio.Visible = false;
                        label1.Visible = false;
                        lbl_peso.Visible = true;


                    }
                    if (item is Socio)
                    {
                        dadossocio = (Socio)item;
                        lbl_nome1.Text = dadossocio.Nome;
                        lbl_data1.Text = dadossocio.Idade.ToString();
                        lbl_morada1.Text = dadossocio.MoradaPessoa.Rua;
                        lbl_morada1.Text = dadossocio.MoradaPessoa.Localidade;
                        lbl_morada1.Text = dadossocio.MoradaPessoa.CodigoPostal;
                        label_socio.Text = dadossocio.NumSocio.ToString();

                        label_peso.Visible = false;
                        label_socio.Visible = true;
                        label1.Visible = true;
                        lbl_peso.Visible = false;

                    }
                }
                */
        }

      
        private void lsb_pessoas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            verificar_lista();
            if (edited == 0 && removed == 0)
            {


                si = lsb_pessoas.SelectedIndex;
            }
            

            edited = 0;
            removed = 0;

            // nomes_lsb();
            lsb_pessoas.Refresh();
            lsb_pessoas.SelectedIndex = si;
            if (lsb_pessoas.SelectedIndex == -1)
            {
                lsb_pessoas.SelectedIndex = 0;
            }
            
            if (Global.clube.listaPessoasClube.Count != 0)
            {
                if (Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex] is Atleta)
                {
                    txt_tipo.Text = "Atleta";
                    lbl_fpeso_e_nsocio.Text = "Peso:";
                    txt_peso_e_nsocio.Size = new System.Drawing.Size(175, 20);
                    txt_peso_e_nsocio.Location = new Point(251, 213);
                    txt_peso_e_nsocio.Enabled = true;
                    txt_peso_e_nsocio.Text = "";
                 
                    dadosAtleta = (Atleta)Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex];

                    txt_peso_e_nsocio.Text = dadosAtleta.Peso.ToString();
                    txt_nome.Text = Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].Nome;
                    txt_rua.Text = Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].MoradaPessoa.Rua;
                    txt_localidade.Text = Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex ].MoradaPessoa.Localidade;
                    txt_codigo.Text = Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].MoradaPessoa.CodigoPostal;
                    txt_idade.Text = Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].Idade.ToString() + " Anos";
                }
                else
                {
                    txt_tipo.Text = "Socio";

                    dadosSocio = (Socio)Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex];
                    txt_peso_e_nsocio.Size = new System.Drawing.Size(175, 20);
                    txt_peso_e_nsocio.Location = new Point(251, 213);
                    lbl_fpeso_e_nsocio.Text = "Número de sócio:";
                    txt_peso_e_nsocio.Text = "";

                    txt_peso_e_nsocio.Text = dadosSocio.NumSocio.ToString();

                    txt_peso_e_nsocio.Enabled = false;

                    txt_nome.Text = Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].Nome ;
                    txt_rua.Text = Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].MoradaPessoa.Rua;
                    txt_localidade.Text = Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].MoradaPessoa.Localidade;
                    txt_codigo.Text = Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].MoradaPessoa.CodigoPostal;
                    txt_idade.Text = Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].Idade.ToString() + " Anos";
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (Global.clube.listaPessoasClube.Count != 0)
            {
                btn_remover.Enabled = false;
                btn_confirmar.Visible = true;
                btn_voltar.Visible = true;

                txt_rua.ReadOnly = false;
                txt_nome.ReadOnly = false;
                txt_rua.ReadOnly = false;
                txt_localidade.ReadOnly = false;
                txt_codigo.ReadOnly = false;
                txt_peso_e_nsocio.ReadOnly = false;
                txt_idade.ReadOnly = false;

            }
     
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (Global.clube.listaPessoasClube.Count != 0)
            {
                si = lsb_pessoas.SelectedIndex;
                
                Global.clube.listaPessoasClube.RemoveAt(lsb_pessoas.SelectedIndex);
                removed = 1;
                atualizar_lista();

                
            }
            
        }



        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            edited = 1;
            int index_space_anos = txt_idade.Text.IndexOf(' ');
            Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].Nome = txt_nome.Text;
            Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].MoradaPessoa.Rua = txt_rua.Text;
            Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].MoradaPessoa.Localidade = txt_localidade.Text;
            Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].MoradaPessoa.CodigoPostal = txt_codigo.Text;
            atualizar_lista();

            MessageBox.Show("Editado com sucesso!", "Clube Holla", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            btn_confirmar.Visible = false;
            btn_voltar.Visible = false;
            btn_remover.Enabled = true;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
         
            Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].Nome = Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].Nome;
            Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].MoradaPessoa.Rua = Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].MoradaPessoa.Rua;
            Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].MoradaPessoa.Localidade = Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].MoradaPessoa.Localidade;
            Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].MoradaPessoa.CodigoPostal = Global.clube.listaPessoasClube[lsb_pessoas.SelectedIndex].MoradaPessoa.CodigoPostal;
            atualizar_lista();
            btn_confirmar.Visible = false;
            btn_voltar.Visible = false;

            txt_rua.ReadOnly = true;
            txt_nome.ReadOnly = true;
            txt_rua.ReadOnly = true;
            txt_localidade.ReadOnly = true;
            txt_codigo.ReadOnly = true;
            txt_peso_e_nsocio.ReadOnly = true;
            txt_idade.ReadOnly = true;
            btn_confirmar.Visible = false;
            btn_voltar.Visible = false;
            btn_remover.Enabled = true;


        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            int found = 0;
            int index = 0;
            int z = 0;
     
            string myString = txt_procurar.Text.ToUpper();
            if (last_string_searched == myString)
            {
                z = last_index_searched+1;
            }
                for (int i = z; i < Global.clube.listaPessoasClube.Count(); i++)
            {
                
                if (Global.clube.listaPessoasClube[i].Nome.ToUpper().IndexOf(myString) > -1)
                {

                    lsb_pessoas.SetSelected(i, true);
                    index = i;
                    found = 1;
                    break;
                }
              
            }
            if (found == 1)
            {
                last_index_searched = index;
                last_string_searched = myString;
            }

            else
                MessageBox.Show("Pessoa não encontrada.");


        }

 
    

        private void button1_Click(object sender, EventArgs e)
        {
          
        }






        /*public void adicionar()
{
string ola = Formadicionar.Nome;

Global.clube.InserirPessoa(new Atleta(ola, new DateTime(Convert.ToInt32(Formadicionar.Year), Convert.ToInt32(Formadicionar.Month), Convert.ToInt32(Formadicionar.Day)), new Morada(Formadicionar.Rua, Formadicionar.Localidade, Formadicionar.Codigo), Convert.ToDouble(Formadicionar.Peso)));


}*/


    }
}
