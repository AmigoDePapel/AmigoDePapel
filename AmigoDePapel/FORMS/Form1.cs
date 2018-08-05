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

        //METODOS NÃO SISTEMICOS 
        private void FormLivro(int e)
        {
            try
            {
                CadastraLivro livro;

                if (e < 0)
                {
                    livro = new CadastraLivro();
                }
                else
                { 
                    livro = new CadastraLivro(dg_livro.Rows[e].Cells[0].Value.ToString());
                }

                livro.FormClosing += new FormClosingEventHandler(this.atualiza_FormClosing);
                livro.Show();
                capa.Visible = false;
                capa.Image = null;
                livro.Show();
            }
            catch
            {
                capa.Visible = false;
                capa.Image = null;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormLivro(-1);
        }

        //ações
        private void Index_Load(object sender, EventArgs e)
        {
            LoadGrids();
        }

        private void tsb_reflesh_Click(object sender, EventArgs e)
        {
            //PREENCHE NOVAMENTE 
            RefreshGrids();
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
            //VERIFICA OS ARQUIVOS BASICOS;
            string[] txt = validacao.VerifinicaInicializacao();

            //BASE EXISTE?
            if (!File.Exists(txt[0]))
            {
                tss_img.Image = global::AmigoDePapel.Properties.Resources.cancel;
            }
            else
            { 
            //DESENHA OS GRIDS
                LoadGDLivros gdLivros = new LoadGDLivros();
                DataTable dtLivros = gdLivros.DesenhaGridLivro();
                DataTable dtUsers = gdLivros.DesenhaGridUser();

            //A BASE EXISTE, ENTÃO VAMOS PREENCHER OS GRIDS COM OS RESULTADOS.
                dg_livro.DataSource = gdLivros.PreencheGridLivro(dtLivros);
                dg_user.DataSource = gdLivros.PreencheGridUser(dtUsers);
            }
        }

        private void RefreshGrids()
        {
            //ABA LIVROS
            if(tc_main.SelectedIndex == 1)
            {
                dg_livro.DataSource = null;
                dg_livro.Rows.Clear();
                LoadGDLivros gdLivros = new LoadGDLivros();
                DataTable dtLivros = gdLivros.DesenhaGridLivro();
                dg_livro.DataSource = gdLivros.PreencheGridLivro(dtLivros);
            }
            else if(tc_main.SelectedIndex == 2)
            {
                dg_user.DataSource = null;
                dg_user.Rows.Clear();
                LoadGDLivros gdLivros = new LoadGDLivros();
                DataTable dtUsers = gdLivros.DesenhaGridUser();
                dg_user.DataSource = gdLivros.PreencheGridUser(dtUsers);
            }

        }

        private void atualiza_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadGrids();
        }

        private void dg_livro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                Point p = this.PointToClient(Cursor.Position);
                capa.Size = new Size(96, 139);
                capa.Location = new Point(p.X - 20, p.Y - 45);
                capa.Image = Image.FromFile(GetURLImg(dg_livro.Rows[e.RowIndex].Cells[0].Value.ToString()));
                capa.BorderStyle = BorderStyle.FixedSingle;
                capa.Visible = true;
            }
            catch
            {
                capa.Visible = false;
            }
        }

        private void capa_Click(object sender, EventArgs e)
        {
            capa.Visible = false;
            capa.Image = null;
        }

        private string GetURLImg(string id)
        {
            return System.Environment.CurrentDirectory.ToString() + @"\img\capa\" + id + ".jpg";
        }

        private void tb_pesquisaLivro_TextChanged(object sender, EventArgs e)
        {

        }

        private void pb_pesquisa_user_Click(object sender, EventArgs e)
        {

        }

        private void dg_livro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormLivro(e.RowIndex);
        }

        private void tsb_help_Click(object sender, EventArgs e)
        {

        }

        private void dg_livro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
