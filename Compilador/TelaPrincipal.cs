using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Compilador.Objetos;
using HeyechTree;

namespace Compilador
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void HeyechCirclePictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        // colocar o formulario com bordas redondas
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            GraphicsPath path = new GraphicsPath();
            path = Design.RoundedRectPath(0, 0, this.Width, this.Height, 20, 20);
            this.Region = new Region(path);
        }

        // para se mover o formulario personalisado
        private bool dragging;
        private Point pointClicked;

        private void HeyechTabControlDark1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                pointClicked = new Point(e.X, e.Y);
            }
            else
            {
                dragging = false;
            }
        }

        private void HeyechTabControlDark1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point pointMoveTo;
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));
                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);
                this.Location = pointMoveTo;
            }
        }

        private void HeyechTabControlDark1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // Teste de carregamento da Tree de arquivos
        public void carregarFiles()
        {
            ButtonNode btnNode = new ButtonNode();
            ButtonNode btnNode2 = new ButtonNode();
            ButtonNode btnNode3 = new ButtonNode();


            btnNode2.AddChild(btnNode3);

            btnNode2.NodeButton.Texto("Main");
            btnNode3.NodeButton.Texto("main.ama");
            btnNode3.NodeButton.pictureBox1.Image = Properties.Resources.c;
            btnNode.NodeButton.Texto("Projecto");
            btnNode.AddChild(btnNode2);

            buttonTree1.Add(btnNode);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarFiles();
        }

        //Executar
        public TabView tabCurrent; // cada tabe é idependente e tem a sua propria barra para o console
        private void Executar_Click(object sender, EventArgs e)
        {

            tabCurrent = heyechTabControlDark1.SelectedTab.Controls.OfType<TabView>().FirstOrDefault();
            tabCurrent.Executar();

        }
        // Abrindo um arquivo com o dialog
        private void Label2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Abrir arquivo .ama",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "c",
                Filter = "ama files (*.ama)|*.ama",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var ender = openFileDialog1.FileName;
                TabPage tp = new TabPage(Path.GetFileName(ender));
                heyechTabControlDark1.TabPages.Add(tp);
                TabView tv = new TabView();
                tv.EnderecoDoArquivo = ender;

                tv.code.Text = File.ReadAllText(ender, System.Text.Encoding.UTF8);

                tp.Controls.Add(tv);

                label5.Text = Path.GetFileName(ender) + " - Amanda"; // depois passar para ontabchange

            }
        }
    }
}
