namespace PublierDocuments2017
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.interfacesDesMiseAJoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrateursDinitialiserLeMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrateursMotDePasseInitialisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesCommentairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membreComentairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etatDocumentCommentaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interfacesDesMiseAJoursToolStripMenuItem,
            this.administrateursDinitialiserLeMotDePasseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // interfacesDesMiseAJoursToolStripMenuItem
            // 
            this.interfacesDesMiseAJoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentsToolStripMenuItem,
            this.commentaireToolStripMenuItem,
            this.membresToolStripMenuItem});
            this.interfacesDesMiseAJoursToolStripMenuItem.Name = "interfacesDesMiseAJoursToolStripMenuItem";
            this.interfacesDesMiseAJoursToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.interfacesDesMiseAJoursToolStripMenuItem.Text = "interfaces des mise a jours";
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.documentsToolStripMenuItem.Text = "Documents";
            this.documentsToolStripMenuItem.Click += new System.EventHandler(this.documentsToolStripMenuItem_Click);
            // 
            // commentaireToolStripMenuItem
            // 
            this.commentaireToolStripMenuItem.Name = "commentaireToolStripMenuItem";
            this.commentaireToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.commentaireToolStripMenuItem.Text = "Commentaires";
            // 
            // membresToolStripMenuItem
            // 
            this.membresToolStripMenuItem.Name = "membresToolStripMenuItem";
            this.membresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.membresToolStripMenuItem.Text = "Membres";
            // 
            // administrateursDinitialiserLeMotDePasseToolStripMenuItem
            // 
            this.administrateursDinitialiserLeMotDePasseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrateursMotDePasseInitialisationToolStripMenuItem,
            this.afficherLesCommentairesToolStripMenuItem,
            this.membreComentairesToolStripMenuItem,
            this.etatDocumentCommentaireToolStripMenuItem});
            this.administrateursDinitialiserLeMotDePasseToolStripMenuItem.Name = "administrateursDinitialiserLeMotDePasseToolStripMenuItem";
            this.administrateursDinitialiserLeMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.administrateursDinitialiserLeMotDePasseToolStripMenuItem.Text = "other";
            // 
            // administrateursMotDePasseInitialisationToolStripMenuItem
            // 
            this.administrateursMotDePasseInitialisationToolStripMenuItem.Name = "administrateursMotDePasseInitialisationToolStripMenuItem";
            this.administrateursMotDePasseInitialisationToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.administrateursMotDePasseInitialisationToolStripMenuItem.Text = "administrateurs mot de passe initialisation";
            this.administrateursMotDePasseInitialisationToolStripMenuItem.Click += new System.EventHandler(this.administrateursMotDePasseInitialisationToolStripMenuItem_Click);
            // 
            // afficherLesCommentairesToolStripMenuItem
            // 
            this.afficherLesCommentairesToolStripMenuItem.Name = "afficherLesCommentairesToolStripMenuItem";
            this.afficherLesCommentairesToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.afficherLesCommentairesToolStripMenuItem.Text = "afficher les commentaires ";
            this.afficherLesCommentairesToolStripMenuItem.Click += new System.EventHandler(this.afficherLesCommentairesToolStripMenuItem_Click);
            // 
            // membreComentairesToolStripMenuItem
            // 
            this.membreComentairesToolStripMenuItem.Name = "membreComentairesToolStripMenuItem";
            this.membreComentairesToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.membreComentairesToolStripMenuItem.Text = "Membre Comentaires";
            this.membreComentairesToolStripMenuItem.Click += new System.EventHandler(this.membreComentairesToolStripMenuItem_Click);
            // 
            // etatDocumentCommentaireToolStripMenuItem
            // 
            this.etatDocumentCommentaireToolStripMenuItem.Name = "etatDocumentCommentaireToolStripMenuItem";
            this.etatDocumentCommentaireToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.etatDocumentCommentaireToolStripMenuItem.Text = "EtatDocumentCommentaire";
            this.etatDocumentCommentaireToolStripMenuItem.Click += new System.EventHandler(this.etatDocumentCommentaireToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem interfacesDesMiseAJoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrateursDinitialiserLeMotDePasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrateursMotDePasseInitialisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesCommentairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membreComentairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etatDocumentCommentaireToolStripMenuItem;
    }
}

