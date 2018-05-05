using System;
using System.Windows.Forms;
using AmigoDePapel.FORMS;
using AmigoDePapel.CLASS;
using AmigoDePapel.CLASS.load;
using System.IO;

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
            //VERIFICA OS ARQUIVOS BASICOS, RETORNA FALSE SE A PLANILHA NÃO EXISTIR
            string[] txt = validacao.VerifinicaInicializacao();

            //DESENHA OS GRIDS
            LoadGDLivros gdLivros = new LoadGDLivros();
            dg_livro.DataSource = gdLivros.CarregaGridLivro();
            dg_user.DataSource = gdLivros.CarregaGridUser();

            //PLANILHA EXISTE?
            if (!File.Exists(txt[0]))
             tss_img.Image = global::AmigoDePapel.Properties.Resources.cancel;

        }
    }
}
