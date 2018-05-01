using System;
using System.Windows.Forms;
using AmigoDePapel.FORMS;
using AmigoDePapel.CLASS;
using AmigoDePapel.CLASS.load;
using Microsoft.Office.Interop.Excel;

namespace AmigoDePapel
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CadastraLivro cadastralivro = new CadastraLivro();
            cadastralivro.Show();
        }

        //ações
        private void Index_Load(object sender, EventArgs e)
        {
            ValidaInicializacao validacao = new ValidaInicializacao();
            validacao.VerifinicaInicializacao();
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            //ALIMENTA OS GRIDS
            LoadGDLivros gdLivros = new LoadGDLivros();
            dg_livro.DataSource = gdLivros.CarregaGridLivro();
            dg_user.DataSource = gdLivros.CarregaGridUser();

        }
    }
}
