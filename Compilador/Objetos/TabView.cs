using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Text;

namespace Compilador.Objetos
{
    public partial class TabView : UserControl
    {

        public string EnderecoDoArquivo
        {
            get;
            set;
        }

        // Elemento de texto da Console
        private  RichTextBox ConsoleRich;

        // Caminho do compilador
        private String CompilerFile = @"amanda.exe";

        //caminho da font
        private String FontFile = @"assets/fonts/font.ttf";

        // Resize console
        bool allowResize = false;

        public TabView()
        {
            InitializeComponent();
        }

        private void TabView_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.Location = new Point(0, 0);
            //code.Size = new Size(714, 578);
            code.Location = new Point(2, 17);

            //Pegar a RichTextBox de dentro do console
            ConsoleRich = consoleControl1.InternalRichTextBox;
            ConfiguracaoInicialConsole();
            //UseCustomFont();
        }

        private void ConfiguracaoInicialConsole()
        {
            ConsoleRich.BackColor = Color.FromArgb(19, 17, 54);
            ConsoleRich.BorderStyle = BorderStyle.None;
            ConsoleRich.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

        private void console()
        {
            if(console_panel.Height < 200)
                console_panel.Height = 200;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (console_panel.Height >= 200)
                console_panel.Height = 46;
            else if (console_panel.Height < 200)
                console_panel.Height = 200;
        }

        public void Executar()
        {
            console();
            consoleControl1.ClearOutput();
            consoleControl1.StartProcess(CompilerFile, "\"" + EnderecoDoArquivo + "\"");
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            allowResize = false;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (allowResize)
            {
                this.console_panel.Height = pictureBox1.Top - e.Y;
               // this.console_panel.Width = pictureBox1.Left + e.X;
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            allowResize = true;
        }

        private void UseCustomFont()
        {
            PrivateFontCollection modernFont = new PrivateFontCollection();
            modernFont.AddFontFile(FontFile);
            ConsoleRich.Font = new Font(modernFont.Families[0], 12, FontStyle.Regular);
        }
    }
}
