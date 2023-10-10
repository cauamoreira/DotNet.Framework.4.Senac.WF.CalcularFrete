using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularFrete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularFrete_Click_1(object sender, EventArgs e)
        {

            if (!ValidarCampos())
                return;

            // tentar executar o código
            try
            {
                // convertendo texto em decimal
                var Freteminimo = Convert.ToDecimal(txtFreteminimo.Text);
                // convertendo objeto em string
                var uf = (string)cbxUF.SelectedItem;

                CalcularFrete(Freteminimo, uf);
            }
            // capturar o erro se ocorrer
            catch(Exception ex ) {

                // log de erro
                Console.WriteLine(ex.Message);

                // limpar o campo
                txtFreteminimo.Text = string.Empty;

                // coloca o foco do teclado no txt
                txtFreteminimo.Focus();

                // mensagem para o usuario
                MessageBox.Show("Informe o valor do frete",
                    "Erro!", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            
            }
            
        }
    


        void CalcularFrete(decimal Freteminimo, string uf)
        {
            // variavel do tipo decimal
            var adicional = 5.0M;
            var freteFinal = Freteminimo;

            // se uf == RS
            if (uf.Equals("RS")) 
            {
                freteFinal = Freteminimo + 0.5M;

            }else if (uf == "SC")
            {
                freteFinal = Freteminimo + 1.0M;
            }
            else if (uf == "PR")
            {
                freteFinal = Freteminimo + 2.0M;
            }
            else if (uf == "SP")
            {
                freteFinal = Freteminimo + 3.0M;
            }
            else
            {
                freteFinal = Freteminimo + adicional;
            }

            txtTotalFrete.Text = freteFinal.ToString("F2");

        }

        bool ValidarCampos()
        {
            // verifica se o texto do txt está vazio seta o foco e exibe msg
            if(string.IsNullOrEmpty(txtFreteminimo.Text))
            {
                txtFreteminimo.Focus();
                ExibirMensagem("Informe frete mínino!");
                return false;
            }
            // verificar se o texto do cbx esta vazio seta o foco e exibe mensagem
            if (string.IsNullOrEmpty(cbxUF.Text))
            {
                cbxUF.Focus();
                ExibirMensagem("Informe a UF!");
                return false;
            }

            return true;

        }

        private void ExibirMensagem(string msg)
        {
            MessageBox.Show(msg,
               "",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }
    }
}
