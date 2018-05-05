using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoDePapel.FORMS
{
    public partial class CadastraLivro : Form
    {
        public CadastraLivro()
        {
            InitializeComponent();
        }

        public CadastraLivro(string[] livro)
        {

            InitializeComponent();
        }

        private void tsb_retirar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja remover do sistema esse livro?","ATENÇÃO",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
        }

        private void CadastraLivro_Load(object sender, EventArgs e)
        {
            ValidacoesBasicas();
        }

        private void ValidacoesBasicas()
        {
            //VALIDAÇÕES BÁSICAS
            //se o código do itemm for 00 (cadastro novo) - desativar botão de retirada do sistema. 
            if (lb_codigo.Text.Equals("00"))
                tsb_retirar.Enabled = false;
        }
    }
}
