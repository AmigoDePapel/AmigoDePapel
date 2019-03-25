using System;
using System.Windows.Forms;
using AmigoDePapel.FORMS;
using AmigoDePapel.CLASS;
using AmigoDePapel.CLASS.conSql;
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
                pb_livro_capa.Visible = false;
                pb_livro_capa.Image = null;
                livro.Show();
            }
            catch
            {
                pb_livro_capa.Visible = false;
                pb_livro_capa.Image = null;
            }
        }

        private void FormUser(int e)
        {
            CadastraUser newUser;
            if(e < 0)
            {
                newUser = new CadastraUser();
            }
            else
            {
                newUser = new CadastraUser(dg_user.Rows[e].Cells[0].Value.ToString());
            }

            newUser.FormClosing += new FormClosingEventHandler(this.atualiza_FormClosing);
            newUser.Show();
        }

        private void LoadGrids()
        {

            ValidaInicializacao validacao = new ValidaInicializacao();
            //VERIFICA OS ARQUIVOS BASICOS
            string[] txt = validacao.VerifinicaInicializacao();

            //BASE EXISTE?
            if (!File.Exists(txt[0]))
            {
                tss_img.Image = Properties.Resources.cancel;
            }
            else
            {
                //DESENHA OS GRIDS
                LoadGDLivros gdLivros = new LoadGDLivros();
                DataTable dtLivros = gdLivros.DesenhaGridLivro();
                DataTable dtUsers = gdLivros.DesenhaGridUser();

                //A BASE (VEM FORTE) EXISTE, ENTÃO VAMOS PREENCHER OS GRIDS COM OS RESULTADOS.
                dg_livro.DataSource = gdLivros.PreencheGridLivro(dtLivros);
                dg_user.DataSource = gdLivros.PreencheGridUser(dtUsers);
            }
        }

        private void RefreshGrids()
        {
            //ABA LIVROS
            if (tc_main.SelectedIndex == 1)
            {
                dg_livro.DataSource = null;
                dg_livro.Rows.Clear();
                LoadGDLivros gdLivros = new LoadGDLivros();
                DataTable dtLivros = gdLivros.DesenhaGridLivro();
                dg_livro.DataSource = gdLivros.PreencheGridLivro(dtLivros);
            }
            else if (tc_main.SelectedIndex == 2)
            {
                dg_user.DataSource = null;
                dg_user.Rows.Clear();
                LoadGDLivros gdLivros = new LoadGDLivros();
                DataTable dtUsers = gdLivros.DesenhaGridUser();
                dg_user.DataSource = gdLivros.PreencheGridUser(dtUsers);
            }
        }

        private string GetURLImg(string id, string tipo)
        {
            return Environment.CurrentDirectory.ToString() + @"\img\"+tipo+@"\" + id + ".jpg";
        }

        private void CarregaImg(string id, string tipo, PictureBox pb)
        {
            try
            {
                Point p = PointToClient(Cursor.Position);
                pb.Size = new Size(96, 139);
                pb.Location = new Point(p.X - 20, p.Y - 45);
                pb.Image = Image.FromFile(GetURLImg(id, tipo));
                pb.BorderStyle = BorderStyle.FixedSingle;
                pb.Visible = true;
            }
            catch
            {
                pb.Visible = false;
            }
        }

        private void RealizaPesquisa()
        {
            //para tratar a query 
            Connection con = new Connection();
            string pesquisa = con.TrataQuery(tb_pesquisaLivro.Text);

            if (!string.IsNullOrEmpty(pesquisa))
            {
                dg_livro.DataSource = null;
                dg_livro.Rows.Clear();
                LoadGDLivros gdLivros = new LoadGDLivros();
                DataTable dtLivros = gdLivros.DesenhaGridLivro();
                dg_livro.DataSource = gdLivros.PreencheGridLivro(dtLivros, pesquisa);
                pb_cancelaPesquisa.Visible = true;
            }
            else
            {
                pb_cancelaPesquisa.Visible = false;
                tb_pesquisaLivro.Text = null;
                dg_livro.DataSource = null;
                dg_livro.Rows.Clear();
                LoadGDLivros gdLivros = new LoadGDLivros();
                DataTable dtLivros = gdLivros.DesenhaGridLivro();
                dg_livro.DataSource = gdLivros.PreencheGridLivro(dtLivros);
            }
        }

        //ações
        private void Index_Load(object sender, EventArgs e)
        {
            LoadGrids();
            tb_pesquisaLivro.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormLivro(-1);
        }

        private void tsb_reflesh_Click(object sender, EventArgs e)
        {
            RefreshGrids();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Configuracao conf = new Configuracao();
            conf.Show();
        }

        private void tsb_add_userr_Click(object sender, EventArgs e)
        {
            FormUser(-1);
        }

        private void atualiza_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadGrids();
            Focus();
        }

        private void dg_livro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaImg(dg_livro.Rows[e.RowIndex].Cells[0].Value.ToString(), "capa", pb_livro_capa);
        }

        private void capa_Click(object sender, EventArgs e)
        {
            pb_livro_capa.Visible = false;
            pb_livro_capa.Image = null;
        }

        private void dg_livro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormLivro(e.RowIndex);
        }

        private void dg_user_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormUser(e.RowIndex);
        }

        private void pb_pesquisa_livro_Click(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }

        private void tb_pesquisaLivro_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                RealizaPesquisa();
        }
        
        private void pb_cancelaPesquisa_Click(object sender, EventArgs e)
        {
            pb_cancelaPesquisa.Visible = false;
            tb_pesquisaLivro.Text = null;
            dg_livro.DataSource = null;
            dg_livro.Rows.Clear();
            LoadGDLivros gdLivros = new LoadGDLivros();
            DataTable dtLivros = gdLivros.DesenhaGridLivro();
            dg_livro.DataSource = gdLivros.PreencheGridLivro(dtLivros);
        }

        private void dg_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaImg(dg_user.Rows[e.RowIndex].Cells[0].Value.ToString(), "user", pb_userFoto);
        }

        private void pb_userFoto_Click(object sender, EventArgs e)
        {
            pb_userFoto.Visible = false;
            pb_userFoto.Image = null;
        }
    }
}
