namespace PublierDocuments2017
{
    partial class FormMotPasseInitialisation
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label login_Label;
            System.Windows.Forms.Label passeLabel;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.login_ComboBox = new System.Windows.Forms.ComboBox();
            this.mombreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passeTextBox = new System.Windows.Forms.TextBox();
            this.btnInitialisation = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            login_Label = new System.Windows.Forms.Label();
            passeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mombreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(63, 66);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 13);
            label1.TabIndex = 5;
            label1.Text = "passe:";
            // 
            // login_Label
            // 
            login_Label.AutoSize = true;
            login_Label.Location = new System.Drawing.Point(63, 39);
            login_Label.Name = "login_Label";
            login_Label.Size = new System.Drawing.Size(35, 13);
            login_Label.TabIndex = 6;
            login_Label.Text = "login :";
            // 
            // passeLabel
            // 
            passeLabel.AutoSize = true;
            passeLabel.Location = new System.Drawing.Point(63, 92);
            passeLabel.Name = "passeLabel";
            passeLabel.Size = new System.Drawing.Size(74, 13);
            passeLabel.TabIndex = 8;
            passeLabel.Text = " Confirmation :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            // 
            // login_ComboBox
            // 
            this.login_ComboBox.DataSource = this.mombreBindingSource;
            this.login_ComboBox.DisplayMember = "login_";
            this.login_ComboBox.FormattingEnabled = true;
            this.login_ComboBox.Location = new System.Drawing.Point(142, 36);
            this.login_ComboBox.Name = "login_ComboBox";
            this.login_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.login_ComboBox.TabIndex = 7;
            this.login_ComboBox.ValueMember = "login_";
            this.login_ComboBox.SelectedIndexChanged += new System.EventHandler(this.login_ComboBox_SelectedIndexChanged);
            // 
            // mombreBindingSource
            // 
            this.mombreBindingSource.DataSource = typeof(PublierDocuments2017.Mombre);
            // 
            // passeTextBox
            // 
            this.passeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mombreBindingSource, "passe", true));
            this.passeTextBox.Location = new System.Drawing.Point(142, 89);
            this.passeTextBox.Name = "passeTextBox";
            this.passeTextBox.Size = new System.Drawing.Size(121, 20);
            this.passeTextBox.TabIndex = 9;
            // 
            // btnInitialisation
            // 
            this.btnInitialisation.Location = new System.Drawing.Point(124, 126);
            this.btnInitialisation.Name = "btnInitialisation";
            this.btnInitialisation.Size = new System.Drawing.Size(75, 23);
            this.btnInitialisation.TabIndex = 10;
            this.btnInitialisation.Text = "Initialisation";
            this.btnInitialisation.UseVisualStyleBackColor = true;
            this.btnInitialisation.Click += new System.EventHandler(this.btnInitialisation_Click);
            // 
            // FormMotPasseInitialisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 208);
            this.Controls.Add(this.btnInitialisation);
            this.Controls.Add(login_Label);
            this.Controls.Add(this.login_ComboBox);
            this.Controls.Add(passeLabel);
            this.Controls.Add(this.passeTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label1);
            this.Name = "FormMotPasseInitialisation";
            this.Text = "FormMotPasseInitialisation";
            ((System.ComponentModel.ISupportInitialize)(this.mombreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mombreBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox login_ComboBox;
        private System.Windows.Forms.TextBox passeTextBox;
        private System.Windows.Forms.Button btnInitialisation;
    }
}