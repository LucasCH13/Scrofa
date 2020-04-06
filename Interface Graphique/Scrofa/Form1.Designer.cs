namespace Scrofa
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_Annuler = new System.Windows.Forms.Button();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.comboBox_Vitesse = new System.Windows.Forms.ComboBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.label_Vitesse = new System.Windows.Forms.Label();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Lire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Annuler
            // 
            this.button_Annuler.Location = new System.Drawing.Point(214, 183);
            this.button_Annuler.Name = "button_Annuler";
            this.button_Annuler.Size = new System.Drawing.Size(75, 23);
            this.button_Annuler.TabIndex = 1;
            this.button_Annuler.Text = "Annuler";
            this.button_Annuler.UseVisualStyleBackColor = true;
            this.button_Annuler.Click += new System.EventHandler(this.button_Annuler_Click);
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(71, 20);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Port.TabIndex = 4;
            this.comboBox_Port.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // comboBox_Vitesse
            // 
            this.comboBox_Vitesse.FormattingEnabled = true;
            this.comboBox_Vitesse.Items.AddRange(new object[] {
            "115200",
            "57600",
            "38400",
            "9600"});
            this.comboBox_Vitesse.Location = new System.Drawing.Point(71, 55);
            this.comboBox_Vitesse.Name = "comboBox_Vitesse";
            this.comboBox_Vitesse.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Vitesse.TabIndex = 5;
            this.comboBox_Vitesse.Text = "9600";
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(12, 20);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(26, 13);
            this.label_Port.TabIndex = 6;
            this.label_Port.Text = "Port";
            // 
            // label_Vitesse
            // 
            this.label_Vitesse.AutoSize = true;
            this.label_Vitesse.Location = new System.Drawing.Point(12, 55);
            this.label_Vitesse.Name = "label_Vitesse";
            this.label_Vitesse.Size = new System.Drawing.Size(41, 13);
            this.label_Vitesse.TabIndex = 7;
            this.label_Vitesse.Text = "Vitesse";
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(297, 183);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 8;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(33, 154);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(75, 23);
            this.button_Open.TabIndex = 9;
            this.button_Open.Text = "OPEN";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(117, 154);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 10;
            this.button_Close.Text = "CLOSE";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(33, 183);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(159, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 145);
            this.textBox1.TabIndex = 12;
            // 
            // button_Lire
            // 
            this.button_Lire.Location = new System.Drawing.Point(117, 125);
            this.button_Lire.Name = "button_Lire";
            this.button_Lire.Size = new System.Drawing.Size(75, 23);
            this.button_Lire.TabIndex = 13;
            this.button_Lire.Text = "Lire";
            this.button_Lire.UseVisualStyleBackColor = true;
            this.button_Lire.Click += new System.EventHandler(this.button_Lire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.button_Lire);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.label_Vitesse);
            this.Controls.Add(this.label_Port);
            this.Controls.Add(this.comboBox_Vitesse);
            this.Controls.Add(this.comboBox_Port);
            this.Controls.Add(this.button_Annuler);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scrofa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Annuler;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.ComboBox comboBox_Vitesse;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.Label label_Vitesse;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Close;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Lire;
    }
}

