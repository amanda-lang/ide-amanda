namespace Compilador.Objetos
{
    partial class TabView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabView));
            this.code = new FastColoredTextBoxNS.FastColoredTextBox();
            this.console_panel = new System.Windows.Forms.Panel();
            this.console_text = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.seta = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numerros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.code)).BeginInit();
            this.console_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seta)).BeginInit();
            this.SuspendLayout();
            // 
            // code
            // 
            this.code.AutoScrollMinSize = new System.Drawing.Size(299, 238);
            this.code.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.code.BackBrush = null;
            this.code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(54)))));
            this.code.CharHeight = 14;
            this.code.CharWidth = 8;
            this.code.CurrentLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(6)))), ((int)(((byte)(46)))));
            this.code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.code.DisabledColor = System.Drawing.Color.Transparent;
            this.code.Dock = System.Windows.Forms.DockStyle.Top;
            this.code.ForeColor = System.Drawing.Color.White;
            this.code.ImeMode = System.Windows.Forms.ImeMode.On;
            this.code.IndentBackColor = System.Drawing.Color.Transparent;
            this.code.IsReplaceMode = false;
            this.code.Language = FastColoredTextBoxNS.Language.CSharp;
            this.code.LeftBracket = '(';
            this.code.Location = new System.Drawing.Point(0, 0);
            this.code.Name = "code";
            this.code.Paddings = new System.Windows.Forms.Padding(0);
            this.code.RightBracket = ')';
            this.code.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.code.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(6)))), ((int)(((byte)(46)))));
            this.code.Size = new System.Drawing.Size(720, 469);
            this.code.TabIndex = 1;
            this.code.Text = resources.GetString("code.Text");
            this.code.Zoom = 100;
            // 
            // console_panel
            // 
            this.console_panel.Controls.Add(this.console_text);
            this.console_panel.Controls.Add(this.pictureBox2);
            this.console_panel.Controls.Add(this.seta);
            this.console_panel.Controls.Add(this.label4);
            this.console_panel.Controls.Add(this.numerros);
            this.console_panel.Controls.Add(this.label2);
            this.console_panel.Controls.Add(this.label1);
            this.console_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.console_panel.Location = new System.Drawing.Point(0, 474);
            this.console_panel.Name = "console_panel";
            this.console_panel.Size = new System.Drawing.Size(720, 46);
            this.console_panel.TabIndex = 2;
            // 
            // console_text
            // 
            this.console_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.console_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(54)))));
            this.console_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.console_text.Location = new System.Drawing.Point(4, 47);
            this.console_text.Name = "console_text";
            this.console_text.Size = new System.Drawing.Size(714, 0);
            this.console_text.TabIndex = 6;
            this.console_text.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(6)))), ((int)(((byte)(46)))));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(729, 1);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // seta
            // 
            this.seta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.seta.Image = global::Compilador.Properties.Resources.extend;
            this.seta.Location = new System.Drawing.Point(698, 11);
            this.seta.Name = "seta";
            this.seta.Size = new System.Drawing.Size(12, 11);
            this.seta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.seta.TabIndex = 4;
            this.seta.TabStop = false;
            this.seta.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(641, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "0";
            // 
            // numerros
            // 
            this.numerros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numerros.AutoSize = true;
            this.numerros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerros.ForeColor = System.Drawing.Color.White;
            this.numerros.Location = new System.Drawing.Point(533, 10);
            this.numerros.Name = "numerros";
            this.numerros.Size = new System.Drawing.Size(13, 13);
            this.numerros.TabIndex = 2;
            this.numerros.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.label2.Location = new System.Drawing.Point(587, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alerta(s):";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.label1.Location = new System.Drawing.Point(490, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Erro(s):";
            // 
            // TabView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.console_panel);
            this.Controls.Add(this.code);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(720, 520);
            this.Name = "TabView";
            this.Size = new System.Drawing.Size(720, 520);
            this.Load += new System.EventHandler(this.TabView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.code)).EndInit();
            this.console_panel.ResumeLayout(false);
            this.console_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel console_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox seta;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.RichTextBox console_text;
        public FastColoredTextBoxNS.FastColoredTextBox code;
        public System.Windows.Forms.Label numerros;
    }
}
