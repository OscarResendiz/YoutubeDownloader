namespace YoutubeDownloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textUrl = new TextBox();
            bntDescargar = new Button();
            checkBoxPlayList = new CheckBox();
            panel1 = new Panel();
            bntDirectorio = new Button();
            textDirectorio = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            textMensaje = new RichTextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "url";
            // 
            // textUrl
            // 
            textUrl.Location = new Point(33, 16);
            textUrl.Name = "textUrl";
            textUrl.Size = new Size(388, 23);
            textUrl.TabIndex = 1;
            // 
            // bntDescargar
            // 
            bntDescargar.Location = new Point(427, 15);
            bntDescargar.Name = "bntDescargar";
            bntDescargar.Size = new Size(75, 23);
            bntDescargar.TabIndex = 2;
            bntDescargar.Text = "Descargar";
            bntDescargar.UseVisualStyleBackColor = true;
            bntDescargar.Click += button1_Click;
            // 
            // checkBoxPlayList
            // 
            checkBoxPlayList.AutoSize = true;
            checkBoxPlayList.Location = new Point(508, 18);
            checkBoxPlayList.Name = "checkBoxPlayList";
            checkBoxPlayList.Size = new Size(63, 19);
            checkBoxPlayList.TabIndex = 3;
            checkBoxPlayList.Text = "playlist";
            checkBoxPlayList.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(bntDirectorio);
            panel1.Controls.Add(textDirectorio);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textUrl);
            panel1.Controls.Add(checkBoxPlayList);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bntDescargar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 76);
            panel1.TabIndex = 4;
            // 
            // bntDirectorio
            // 
            bntDirectorio.Location = new Point(427, 47);
            bntDirectorio.Name = "bntDirectorio";
            bntDirectorio.Size = new Size(75, 23);
            bntDirectorio.TabIndex = 6;
            bntDirectorio.Text = "...";
            bntDirectorio.UseVisualStyleBackColor = true;
            bntDirectorio.Click += bntDirectorio_Click;
            // 
            // textDirectorio
            // 
            textDirectorio.Location = new Point(71, 47);
            textDirectorio.Name = "textDirectorio";
            textDirectorio.Size = new Size(350, 23);
            textDirectorio.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 47);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Directorio";
            // 
            // panel2
            // 
            panel2.Controls.Add(textMensaje);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 374);
            panel2.TabIndex = 5;
            // 
            // textMensaje
            // 
            textMensaje.BackColor = Color.Black;
            textMensaje.Dock = DockStyle.Fill;
            textMensaje.ForeColor = Color.Green;
            textMensaje.Location = new Point(0, 0);
            textMensaje.Name = "textMensaje";
            textMensaje.ReadOnly = true;
            textMensaje.Size = new Size(800, 374);
            textMensaje.TabIndex = 7;
            textMensaje.Text = "";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "YoutubeDonloader";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textUrl;
        private Button bntDescargar;
        private CheckBox checkBoxPlayList;
        private Panel panel1;
        private Panel panel2;
        private Button bntDirectorio;
        private TextBox textDirectorio;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private RichTextBox textMensaje;
    }
}