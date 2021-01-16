using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Compilador.Objetos
{
    public partial class TabView : UserControl
    {

        public string EnderecoDoArquivo
        {
            get;
            set;
        }

        /* Criar um processo*/
        private readonly Process Proc = new Process();

        /*Informação usada para iniciar o processo*/
        private readonly ProcessStartInfo ProcInfo = new ProcessStartInfo();

        public TabView()
        {
            InitializeComponent();
        }

        private void TabView_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.Location = new Point(0, 0);
            code.Size = new Size(714, 460);
            code.Location = new Point(2, 17);

            /* Caminho para o executável do compilador de amanda. É só mudar para o caminho aonde vamos por
        	o executável depois da instalação.*/
            ProcInfo.FileName = @"amanda.exe";
        }

        private void console()
        {
            console_panel.Height = 200;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (console_panel.Height == 200)
                console_panel.Height = 46;
            else
                console_panel.Height = 200;
        }

        public void Executar()
        {
            console();

            var box = console_text;
            box.Clear();

            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = Color.Gray;
            box.AppendText("\nIniciando a compilação...\n\n");
            box.SelectionColor = box.ForeColor;

            // calculo do tempo
            long t = DateTime.Now.Millisecond;

            File.WriteAllText(EnderecoDoArquivo, code.Text);


            /*Caminho para o ficheiro que vai ser executado é passado como argumento. Basta substituir pelo ficheiro que está
        	aberto na IDE*/
            ProcInfo.Arguments = EnderecoDoArquivo;

            /*Permitir o redirecionamento do stdout*/
            ProcInfo.UseShellExecute = false;
            ProcInfo.RedirectStandardOutput = true;
            Proc.StartInfo = ProcInfo;
            Proc.Start();

            /*Ler o stdout do processo. Podemos redirecionar o output para uma outra janela e e.t.c*/
            String str;
            /*Isso deveria ser assícrono para ler sempre que houver algo para ler, mas como eu sou um noob em C# vou deixar
        	isso com vocês (Mestres).*/
            while ((str = Proc.StandardOutput.ReadLine()) != null)
                box.AppendText(str + "\n");


            long tempo = DateTime.Now.Millisecond - t;

            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = Color.Green;
            box.AppendText("\nTempo de execução: " + tempo + " ms\n\n");
            box.SelectionColor = box.ForeColor;
        }

    }
}
