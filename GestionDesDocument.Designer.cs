namespace PublierDocuments2017
{
    partial class GestionDesDocument
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label code_documentLabel;
            System.Windows.Forms.Label date_envoiLabel;
            System.Windows.Forms.Label description_documentLabel;
            System.Windows.Forms.Label themeLabel;
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.code_documentTextBox = new System.Windows.Forms.TextBox();
            this.date_envoiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.description_documentTextBox = new System.Windows.Forms.TextBox();
            this.themeTextBox = new System.Windows.Forms.TextBox();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrivie = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            code_documentLabel = new System.Windows.Forms.Label();
            date_envoiLabel = new System.Windows.Forms.Label();
            description_documentLabel = new System.Windows.Forms.Label();
            themeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // code_documentLabel
            // 
            code_documentLabel.AutoSize = true;
            code_documentLabel.Location = new System.Drawing.Point(17, 61);
            code_documentLabel.Name = "code_documentLabel";
            code_documentLabel.Size = new System.Drawing.Size(84, 13);
            code_documentLabel.TabIndex = 1;
            code_documentLabel.Text = "code document:";
            // 
            // date_envoiLabel
            // 
            date_envoiLabel.AutoSize = true;
            date_envoiLabel.Location = new System.Drawing.Point(17, 88);
            date_envoiLabel.Name = "date_envoiLabel";
            date_envoiLabel.Size = new System.Drawing.Size(60, 13);
            date_envoiLabel.TabIndex = 3;
            date_envoiLabel.Text = "date envoi:";
            // 
            // description_documentLabel
            // 
            description_documentLabel.AutoSize = true;
            description_documentLabel.Location = new System.Drawing.Point(17, 113);
            description_documentLabel.Name = "description_documentLabel";
            description_documentLabel.Size = new System.Drawing.Size(111, 13);
            description_documentLabel.TabIndex = 5;
            description_documentLabel.Text = "description document:";
            // 
            // themeLabel
            // 
            themeLabel.AutoSize = true;
            themeLabel.Location = new System.Drawing.Point(17, 139);
            themeLabel.Name = "themeLabel";
            themeLabel.Size = new System.Drawing.Size(39, 13);
            themeLabel.TabIndex = 7;
            themeLabel.Text = "theme:";
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(PublierDocuments2017.Document);
            // 
            // code_documentTextBox
            // 
            this.code_documentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentBindingSource, "code_document", true));
            this.code_documentTextBox.Location = new System.Drawing.Point(134, 58);
            this.code_documentTextBox.Name = "code_documentTextBox";
            this.code_documentTextBox.Size = new System.Drawing.Size(200, 20);
            this.code_documentTextBox.TabIndex = 2;
            // 
            // date_envoiDateTimePicker
            // 
            this.date_envoiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.documentBindingSource, "date_envoi", true));
            this.date_envoiDateTimePicker.Location = new System.Drawing.Point(134, 84);
            this.date_envoiDateTimePicker.Name = "date_envoiDateTimePicker";
            this.date_envoiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_envoiDateTimePicker.TabIndex = 4;
            // 
            // description_documentTextBox
            // 
            this.description_documentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentBindingSource, "description_document", true));
            this.description_documentTextBox.Location = new System.Drawing.Point(134, 110);
            this.description_documentTextBox.Name = "description_documentTextBox";
            this.description_documentTextBox.Size = new System.Drawing.Size(200, 20);
            this.description_documentTextBox.TabIndex = 6;
            // 
            // themeTextBox
            // 
            this.themeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentBindingSource, "theme", true));
            this.themeTextBox.Location = new System.Drawing.Point(134, 136);
            this.themeTextBox.Name = "themeTextBox";
            this.themeTextBox.Size = new System.Drawing.Size(200, 20);
            this.themeTextBox.TabIndex = 8;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(351, 35);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(75, 23);
            this.btnNouveau.TabIndex = 9;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(351, 64);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(351, 93);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(351, 123);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(351, 152);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 13;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(45, 210);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 14;
            this.btnFirst.Text = "Firs";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrivie
            // 
            this.btnPrivie.Location = new System.Drawing.Point(126, 210);
            this.btnPrivie.Name = "btnPrivie";
            this.btnPrivie.Size = new System.Drawing.Size(75, 23);
            this.btnPrivie.TabIndex = 15;
            this.btnPrivie.Text = "Privieus";
            this.btnPrivie.UseVisualStyleBackColor = true;
            this.btnPrivie.Click += new System.EventHandler(this.btnPrivie_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(207, 210);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(288, 210);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 17;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // GestionDesDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 316);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrivie);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(code_documentLabel);
            this.Controls.Add(this.code_documentTextBox);
            this.Controls.Add(date_envoiLabel);
            this.Controls.Add(this.date_envoiDateTimePicker);
            this.Controls.Add(description_documentLabel);
            this.Controls.Add(this.description_documentTextBox);
            this.Controls.Add(themeLabel);
            this.Controls.Add(this.themeTextBox);
            this.Name = "GestionDesDocument";
            this.Text = "GestionDesDocument";
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource documentBindingSource;
        private System.Windows.Forms.TextBox code_documentTextBox;
        private System.Windows.Forms.DateTimePicker date_envoiDateTimePicker;
        private System.Windows.Forms.TextBox description_documentTextBox;
        private System.Windows.Forms.TextBox themeTextBox;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrivie;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
    }
}