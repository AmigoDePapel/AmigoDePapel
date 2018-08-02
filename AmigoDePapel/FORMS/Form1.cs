using System;
using System.Windows.Forms;
using AmigoDePapel.FORMS;
using AmigoDePapel.CLASS;
using AmigoDePapel.CLASS.load;
using System.IO;
using System.Data;
using System.Drawing;

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
            cadastralivro.FormClosing  += new FormClosingEventHandler(this.atualiza_FormClosing);
            cadastralivro.Show();

        }

        //ações
        private void Index_Load(object sender, EventArgs e)
        {
            LoadGrids();
        }

        private void tsb_reflesh_Click(object sender, EventArgs e)
        {
            //LIMPA 
            dg_livro.DataSource = null;
            dg_user.DataSource = null;

            dg_livro.Rows.Clear();
            dg_user.Rows.Clear();

            //PREENCHE NOVAMENTE 
            LoadGrids();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Configuracao conf = new Configuracao();
            conf.Show();
        }

        private void tsb_add_userr_Click(object sender, EventArgs e)
        {
            CadastraUser newUser = new CadastraUser();
            newUser.FormClosing += new FormClosingEventHandler(this.atualiza_FormClosing);
            newUser.Show();
        }


        private void LoadGrids()
        {
            ValidaInicializacao validacao = new ValidaInicializacao();
            //VERIFICA OS ARQUIVOS BASICOS, RETORNA FALSE SE A PLANILHA NÃO EXISTIR
            string[] txt = validacao.VerifinicaInicializacao();

            //DESENHA OS GRIDS
            LoadGDLivros gdLivros = new LoadGDLivros();
            DataTable dtLivros = gdLivros.DesenhaGridLivro();
            DataTable dtUsers = gdLivros.DesenhaGridUser();


            //BASE EXISTE?
            if (!File.Exists(txt[0]))
            {
                tss_img.Image = global::AmigoDePapel.Properties.Resources.cancel;
            }
            else
            {
                //A BASE EXISTE, ENTÃO VAMOS PREENCHER OS GRIDS COM OS RESULTADOS.
                dg_livro.DataSource = gdLivros.PreencheGridLivro(dtLivros);
                dg_user.DataSource = gdLivros.PreencheGridUser(dtUsers);
            }
        }

        private void atualiza_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadGrids();
        }

        private void dg_livro_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Point p = this.PointToClient(Cursor.Position);

            capa.Size = new Size(96, 139);
            capa.Location = new Point(p.X - 20, p.Y - 45);
            capa.Image = Image.FromFile(GetURLImg(dg_livro.Rows[e.RowIndex].Cells[0].Value.ToString()));
            capa.BorderStyle = BorderStyle.FixedSingle;
            capa.Visible = true;
        }

        private void capa_Click(object sender, EventArgs e)
        {
            capa.Visible = false;
        }

        private string GetURLImg(string id)
        {
            return "";
        }
    }
}
