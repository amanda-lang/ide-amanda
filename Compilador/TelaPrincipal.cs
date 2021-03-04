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
        private bool isMaximizaded = false;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            GraphicsPath path = new GraphicsPath();
            path = Design.RoundedRectPath(0, 0, this.Width, this.Height, 20, 20);
            this.Region = new Region(path);*/
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

        //Verificar se tem um tab aberto
        private bool VerificarTabs()
        {
            var numer = heyechTabControlDark1.RowCount;
            if (numer > 0)
            {
                return true;
            }
            return false;
        }

        //Executar
        public TabView tabCurrent; // cada tabe é idependente e tem a sua propria barra para o console
        private void Executar_Click(object sender, EventArgs e)
        {
            
            if (VerificarTabs())
            {
                var result = SaveFile();
                if (result)
                {
                    tabCurrent = heyechTabControlDark1.SelectedTab.Controls.OfType<TabView>().FirstOrDefault();
                    tabCurrent.Executar();
                }
            }

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
                tp.Controls.Add(tv);
                tv.EnderecoDoArquivo = ender;
                tv.code.Text = File.ReadAllText(ender, System.Text.Encoding.UTF8);
                label5.Text = Path.GetFileName(ender) + " - Amanda"; // depois passar para ontabchange
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            if (VerificarTabs())
            {
                SaveFile();
            }
        }

        private bool SaveFile()
        {
            tabCurrent = heyechTabControlDark1.SelectedTab.Controls.OfType<TabView>().FirstOrDefault();

            if (tabCurrent.EnderecoDoArquivo != "" && System.IO.File.Exists(tabCurrent.EnderecoDoArquivo))
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(tabCurrent.EnderecoDoArquivo); //open the file for writing.
                writer.Write(tabCurrent.code.Text); //write the current date to the file. change this with your date or something.
                writer.Close(); //remember to close the file again.
                writer.Dispose(); //remember to dispose it from the memory.
                return true;
            }
            else
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.Title = "Salvar ficheiro ama";
                saveFileDialog1.DefaultExt = "ama";
                saveFileDialog1.Filter = "ama files (*.ama)|*.ama";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    tabCurrent.code.SaveFile(saveFileDialog1.FileName);
                    tabCurrent.EnderecoDoArquivo = saveFileDialog1.FileName;
                    heyechTabControlDark1.SelectedTab.Text = Path.GetFileName(saveFileDialog1.FileName);
                    return true;
                }
            }
            return false;
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("Novo Documento");
            heyechTabControlDark1.TabPages.Add(tp);
            TabView tv = new TabView();
            tp.Controls.Add(tv);
        }
        
        private void HeyechCirclePictureBox2_Click(object sender, EventArgs e)
        {
            if (isMaximizaded)
            {
                Width = 1030;
                Height = 682;
                isMaximizaded = false;
            }
            else
            {
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                isMaximizaded = true;
            }
        }

        private void HeyechCirclePictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox4_MouseHover(object sender, EventArgs e)
        {
            if (VerificarTabs())
            {
                pictureBox4.Cursor = label3.Cursor = System.Windows.Forms.Cursors.Hand;
            }
            else
            {
                pictureBox4.Cursor = label3.Cursor = System.Windows.Forms.Cursors.No;
            }
        }

        private void PictureBox2_MouseHover(object sender, EventArgs e)
        {
            if (VerificarTabs())
            {
                pictureBox2.Cursor = label4.Cursor = System.Windows.Forms.Cursors.Hand;
            }
            else
            {
                pictureBox2.Cursor = label4.Cursor = System.Windows.Forms.Cursors.No;
            }
        }

        private void heyechTabControlDark1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
