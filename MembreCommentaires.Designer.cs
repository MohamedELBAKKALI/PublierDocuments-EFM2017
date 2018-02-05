namespace PublierDocuments2017
{
    partial class MembreCommentaires
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
            this.commentaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mombreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBloquer = new System.Windows.Forms.Button();
            this.commentaireDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.commentaireBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mombreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentaireDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // commentaireBindingSource
            // 
            this.commentaireBindingSource.DataSource = typeof(PublierDocuments2017.Commentaire);
            // 
            // mombreBindingSource
            // 
            this.mombreBindingSource.DataSource = typeof(PublierDocuments2017.Mombre);
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(PublierDocuments2017.Document);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.commentaireBindingSource;
            this.comboBox1.DisplayMember = "login_";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(352, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "login_";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnBloquer
            // 
            this.btnBloquer.Location = new System.Drawing.Point(68, 332);
            this.btnBloquer.Name = "btnBloquer";
            this.btnBloquer.Size = new System.Drawing.Size(86, 32);
            this.btnBloquer.TabIndex = 3;
            this.btnBloquer.Text = "Bloquer";
            this.btnBloquer.UseVisualStyleBackColor = true;
            // 
            // commentaireDataGridView
            // 
            this.commentaireDataGridView.AutoGenerateColumns = false;
            this.commentaireDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentaireDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.commentaireDataGridView.DataSource = this.commentaireBindingSource;
            this.commentaireDataGridView.Location = new System.Drawing.Point(53, 84);
            this.commentaireDataGridView.Name = "commentaireDataGridView";
            this.commentaireDataGridView.Size = new System.Drawing.Size(642, 220);
            this.commentaireDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "code_commentaire";
            this.dataGridViewTextBoxColumn1.HeaderText = "code_commentaire";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date_commentaire";
            this.dataGridViewTextBoxColumn2.HeaderText = "date_commentaire";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "text_commentaire";
            this.dataGridViewTextBoxColumn3.HeaderText = "text_commentaire";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "etat_commentaire";
            this.dataGridViewTextBoxColumn4.HeaderText = "etat_commentaire";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "code_document";
            this.dataGridViewTextBoxColumn5.HeaderText = "code_document";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "login_";
            this.dataGridViewTextBoxColumn6.HeaderText = "login_";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // MembraCommentaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 521);
            this.Controls.Add(this.commentaireDataGridView);
            this.Controls.Add(this.btnBloquer);
            this.Controls.Add(this.comboBox1);
            this.Name = "MembraCommentaires";
            this.Text = "MembraCommentaires";
            ((System.ComponentModel.ISupportInitialize)(this.commentaireBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mombreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentaireDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource commentaireBindingSource;
        private System.Windows.Forms.BindingSource mombreBindingSource;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBloquer;
        private System.Windows.Forms.DataGridView commentaireDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}