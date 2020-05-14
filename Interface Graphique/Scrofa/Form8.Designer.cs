namespace Scrofa
{
    partial class Form8
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() { 
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxModule = new System.Windows.Forms.GroupBox();
            this.groupBoxModule2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_1 = new System.Windows.Forms.ComboBox();
            this.labelModuleLocal = new System.Windows.Forms.Label();
            this.groupBoxDisque = new System.Windows.Forms.GroupBox();
            this.ecrireDisque = new System.Windows.Forms.Button();
            this.lireDisque = new System.Windows.Forms.Button();
            this.comboBox_section = new System.Windows.Forms.ComboBox();
            this.groupBoxModule.SuspendLayout();
            this.groupBoxModule2.SuspendLayout();
            this.groupBoxDisque.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sélectionnez la section à afficher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBoxModule
            // 
            this.groupBoxModule.Controls.Add(this.groupBoxModule2);
            this.groupBoxModule.Controls.Add(this.comboBox_1);
            this.groupBoxModule.Controls.Add(this.labelModuleLocal);
            this.groupBoxModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxModule.Location = new System.Drawing.Point(22, 165);
            this.groupBoxModule.Name = "groupBoxModule";
            this.groupBoxModule.Size = new System.Drawing.Size(745, 253);
            this.groupBoxModule.TabIndex = 6;
            this.groupBoxModule.TabStop = false;
            this.groupBoxModule.Text = "Communiquer avec/via un module qui est connecté à cet ordinateur";
            // 
            // groupBoxModule2
            // 
            this.groupBoxModule2.Controls.Add(this.button4);
            this.groupBoxModule2.Controls.Add(this.button3);
            this.groupBoxModule2.Controls.Add(this.button2);
            this.groupBoxModule2.Controls.Add(this.button1);
            this.groupBoxModule2.Location = new System.Drawing.Point(39, 86);
            this.groupBoxModule2.Name = "groupBoxModule2";
            this.groupBoxModule2.Size = new System.Drawing.Size(666, 148);
            this.groupBoxModule2.TabIndex = 2;
            this.groupBoxModule2.TabStop = false;
            this.groupBoxModule2.Text = "Direct avec le module connecté";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(399, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Module de redémarrage";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exportation des logs";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ecrire les paramètres à partir du module";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lire les paramètres du module";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox_1
            // 
            this.comboBox_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Items.AddRange(new object[] {
            "COM 1",
            "COM 2",
            "COM 3"});
            this.comboBox_1.Location = new System.Drawing.Point(358, 36);
            this.comboBox_1.Name = "comboBox_1";
            this.comboBox_1.Size = new System.Drawing.Size(150, 28);
            this.comboBox_1.TabIndex = 1;
            // 
            // labelModuleLocal
            // 
            this.labelModuleLocal.AutoSize = true;
            this.labelModuleLocal.Location = new System.Drawing.Point(210, 44);
            this.labelModuleLocal.Name = "labelModuleLocal";
            this.labelModuleLocal.Size = new System.Drawing.Size(127, 13);
            this.labelModuleLocal.TabIndex = 0;
            this.labelModuleLocal.Text = "Module local connecté à ";
            // 
            // groupBoxDisque
            // 
            this.groupBoxDisque.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxDisque.Controls.Add(this.ecrireDisque);
            this.groupBoxDisque.Controls.Add(this.lireDisque);
            this.groupBoxDisque.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxDisque.Location = new System.Drawing.Point(22, 29);
            this.groupBoxDisque.Name = "groupBoxDisque";
            this.groupBoxDisque.Size = new System.Drawing.Size(745, 100);
            this.groupBoxDisque.TabIndex = 5;
            this.groupBoxDisque.TabStop = false;
            this.groupBoxDisque.Text = "Paramètres de lecture/écriture depuis/vers le disque";
            // 
            // ecrireDisque
            // 
            this.ecrireDisque.Location = new System.Drawing.Point(390, 46);
            this.ecrireDisque.Name = "ecrireDisque";
            this.ecrireDisque.Size = new System.Drawing.Size(315, 23);
            this.ecrireDisque.TabIndex = 1;
            this.ecrireDisque.Text = "Ecrire les paramètres sur le disque";
            this.ecrireDisque.UseVisualStyleBackColor = true;
            // 
            // lireDisque
            // 
            this.lireDisque.Location = new System.Drawing.Point(39, 46);
            this.lireDisque.Name = "lireDisque";
            this.lireDisque.Size = new System.Drawing.Size(315, 23);
            this.lireDisque.TabIndex = 0;
            this.lireDisque.Text = "Lire les paramètres sur le disque";
            this.lireDisque.UseVisualStyleBackColor = true;
            // 
            // comboBox_section
            // 
            this.comboBox_section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_section.FormattingEnabled = true;
            this.comboBox_section.Items.AddRange(new object[] {
            "101. Module SYSTEM : Paramètres standards",
            "201. Module Capteur GPS ",
            "202. Module capteur alerte mortalité (GPS & Accéléromètre)",
            "203. Module capteur drop-off ",
            "301. Module Transmission",
            "302. Module Transmission calendrier"});
            this.comboBox_section.Location = new System.Drawing.Point(56, 491);
            this.comboBox_section.Name = "comboBox_section";
            this.comboBox_section.Size = new System.Drawing.Size(659, 21);
            this.comboBox_section.TabIndex = 8;
            this.comboBox_section.SelectedIndexChanged += new System.EventHandler(this.comboBox_section_SelectedIndexChanged);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 551);
            this.Controls.Add(this.comboBox_section);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxModule);
            this.Controls.Add(this.groupBoxDisque);
            this.Name = "Form8";
            this.Text = "Scrofa Loc V2";
            this.groupBoxModule.ResumeLayout(false);
            this.groupBoxModule.PerformLayout();
            this.groupBoxModule2.ResumeLayout(false);
            this.groupBoxDisque.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxModule;
        private System.Windows.Forms.GroupBox groupBoxModule2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_1;
        private System.Windows.Forms.Label labelModuleLocal;
        private System.Windows.Forms.GroupBox groupBoxDisque;
        private System.Windows.Forms.Button ecrireDisque;
        private System.Windows.Forms.Button lireDisque;
        private System.Windows.Forms.ComboBox comboBox_section;
    }
}