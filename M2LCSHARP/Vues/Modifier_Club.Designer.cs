﻿namespace M2LCSHARP.Vues
{
    partial class Modifier_Club
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
            this.ajout = new System.Windows.Forms.GroupBox();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.lbl_erreur = new System.Windows.Forms.Label();
            this.txt_Tel_Club = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Tel_Club = new System.Windows.Forms.Label();
            this.txt_Mail_Club = new System.Windows.Forms.MaskedTextBox();
            this.fermeraj = new System.Windows.Forms.Button();
            this.btn_Club_Modif = new System.Windows.Forms.Button();
            this.txt_Titre_Club = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Mail_Club = new System.Windows.Forms.Label();
            this.lbl_Titre_club = new System.Windows.Forms.Label();
            this.lbl_Adr_Club = new System.Windows.Forms.Label();
            this.txt_Url_Club = new System.Windows.Forms.MaskedTextBox();
            this.txt_Adr_Club = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Url_Club = new System.Windows.Forms.Label();
            this.lbl_Ville_Club = new System.Windows.Forms.Label();
            this.txt_Ville_CLub = new System.Windows.Forms.MaskedTextBox();
            this.txt_Cp_Club = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Cp_Club = new System.Windows.Forms.Label();
            this.ajout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ajout
            // 
            this.ajout.Controls.Add(this.btn_Annuler);
            this.ajout.Controls.Add(this.lbl_erreur);
            this.ajout.Controls.Add(this.txt_Tel_Club);
            this.ajout.Controls.Add(this.lbl_Tel_Club);
            this.ajout.Controls.Add(this.txt_Mail_Club);
            this.ajout.Controls.Add(this.fermeraj);
            this.ajout.Controls.Add(this.btn_Club_Modif);
            this.ajout.Controls.Add(this.txt_Titre_Club);
            this.ajout.Controls.Add(this.lbl_Mail_Club);
            this.ajout.Controls.Add(this.lbl_Titre_club);
            this.ajout.Controls.Add(this.lbl_Adr_Club);
            this.ajout.Controls.Add(this.txt_Url_Club);
            this.ajout.Controls.Add(this.txt_Adr_Club);
            this.ajout.Controls.Add(this.lbl_Url_Club);
            this.ajout.Controls.Add(this.lbl_Ville_Club);
            this.ajout.Controls.Add(this.txt_Ville_CLub);
            this.ajout.Controls.Add(this.txt_Cp_Club);
            this.ajout.Controls.Add(this.lbl_Cp_Club);
            this.ajout.Location = new System.Drawing.Point(1, 0);
            this.ajout.Name = "ajout";
            this.ajout.Size = new System.Drawing.Size(540, 314);
            this.ajout.TabIndex = 19;
            this.ajout.TabStop = false;
            this.ajout.Text = "modifier";
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(390, 210);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuler.TabIndex = 24;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // lbl_erreur
            // 
            this.lbl_erreur.AutoSize = true;
            this.lbl_erreur.ForeColor = System.Drawing.Color.Red;
            this.lbl_erreur.Location = new System.Drawing.Point(364, 155);
            this.lbl_erreur.Name = "lbl_erreur";
            this.lbl_erreur.Size = new System.Drawing.Size(0, 13);
            this.lbl_erreur.TabIndex = 23;
            // 
            // txt_Tel_Club
            // 
            this.txt_Tel_Club.Location = new System.Drawing.Point(149, 246);
            this.txt_Tel_Club.Mask = "0000000000";
            this.txt_Tel_Club.Name = "txt_Tel_Club";
            this.txt_Tel_Club.PromptChar = ' ';
            this.txt_Tel_Club.Size = new System.Drawing.Size(119, 20);
            this.txt_Tel_Club.TabIndex = 20;
            // 
            // lbl_Tel_Club
            // 
            this.lbl_Tel_Club.AutoSize = true;
            this.lbl_Tel_Club.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tel_Club.Location = new System.Drawing.Point(6, 246);
            this.lbl_Tel_Club.Name = "lbl_Tel_Club";
            this.lbl_Tel_Club.Size = new System.Drawing.Size(76, 17);
            this.lbl_Tel_Club.TabIndex = 19;
            this.lbl_Tel_Club.Text = "Téléphone";
            // 
            // txt_Mail_Club
            // 
            this.txt_Mail_Club.Location = new System.Drawing.Point(149, 209);
            this.txt_Mail_Club.Name = "txt_Mail_Club";
            this.txt_Mail_Club.PromptChar = ' ';
            this.txt_Mail_Club.Size = new System.Drawing.Size(119, 20);
            this.txt_Mail_Club.TabIndex = 18;
            // 
            // fermeraj
            // 
            this.fermeraj.Location = new System.Drawing.Point(388, 274);
            this.fermeraj.Name = "fermeraj";
            this.fermeraj.Size = new System.Drawing.Size(75, 23);
            this.fermeraj.TabIndex = 17;
            this.fermeraj.Text = "Fermer";
            this.fermeraj.UseVisualStyleBackColor = true;
            // 
            // btn_Club_Modif
            // 
            this.btn_Club_Modif.Location = new System.Drawing.Point(390, 240);
            this.btn_Club_Modif.Name = "btn_Club_Modif";
            this.btn_Club_Modif.Size = new System.Drawing.Size(75, 23);
            this.btn_Club_Modif.TabIndex = 16;
            this.btn_Club_Modif.Text = "Modifier";
            this.btn_Club_Modif.UseVisualStyleBackColor = true;
            this.btn_Club_Modif.Click += new System.EventHandler(this.btn_Club_Modif_Click);
            // 
            // txt_Titre_Club
            // 
            this.txt_Titre_Club.Location = new System.Drawing.Point(149, 17);
            this.txt_Titre_Club.Name = "txt_Titre_Club";
            this.txt_Titre_Club.PromptChar = ' ';
            this.txt_Titre_Club.ReadOnly = true;
            this.txt_Titre_Club.Size = new System.Drawing.Size(119, 20);
            this.txt_Titre_Club.TabIndex = 0;
            // 
            // lbl_Mail_Club
            // 
            this.lbl_Mail_Club.AutoSize = true;
            this.lbl_Mail_Club.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mail_Club.Location = new System.Drawing.Point(6, 212);
            this.lbl_Mail_Club.Name = "lbl_Mail_Club";
            this.lbl_Mail_Club.Size = new System.Drawing.Size(33, 17);
            this.lbl_Mail_Club.TabIndex = 12;
            this.lbl_Mail_Club.Text = "Mail";
            // 
            // lbl_Titre_club
            // 
            this.lbl_Titre_club.AutoSize = true;
            this.lbl_Titre_club.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titre_club.Location = new System.Drawing.Point(6, 20);
            this.lbl_Titre_club.Name = "lbl_Titre_club";
            this.lbl_Titre_club.Size = new System.Drawing.Size(36, 17);
            this.lbl_Titre_club.TabIndex = 1;
            this.lbl_Titre_club.Text = "Titre";
            // 
            // lbl_Adr_Club
            // 
            this.lbl_Adr_Club.AutoSize = true;
            this.lbl_Adr_Club.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adr_Club.Location = new System.Drawing.Point(6, 175);
            this.lbl_Adr_Club.Name = "lbl_Adr_Club";
            this.lbl_Adr_Club.Size = new System.Drawing.Size(62, 17);
            this.lbl_Adr_Club.TabIndex = 11;
            this.lbl_Adr_Club.Text = "Adresse";
            // 
            // txt_Url_Club
            // 
            this.txt_Url_Club.Location = new System.Drawing.Point(149, 58);
            this.txt_Url_Club.Name = "txt_Url_Club";
            this.txt_Url_Club.PromptChar = ' ';
            this.txt_Url_Club.Size = new System.Drawing.Size(119, 20);
            this.txt_Url_Club.TabIndex = 2;
            // 
            // txt_Adr_Club
            // 
            this.txt_Adr_Club.Location = new System.Drawing.Point(149, 172);
            this.txt_Adr_Club.Name = "txt_Adr_Club";
            this.txt_Adr_Club.PromptChar = ' ';
            this.txt_Adr_Club.Size = new System.Drawing.Size(119, 20);
            this.txt_Adr_Club.TabIndex = 10;
            // 
            // lbl_Url_Club
            // 
            this.lbl_Url_Club.AutoSize = true;
            this.lbl_Url_Club.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Url_Club.Location = new System.Drawing.Point(6, 61);
            this.lbl_Url_Club.Name = "lbl_Url_Club";
            this.lbl_Url_Club.Size = new System.Drawing.Size(26, 17);
            this.lbl_Url_Club.TabIndex = 3;
            this.lbl_Url_Club.Text = "Url";
            // 
            // lbl_Ville_Club
            // 
            this.lbl_Ville_Club.AutoSize = true;
            this.lbl_Ville_Club.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ville_Club.Location = new System.Drawing.Point(10, 140);
            this.lbl_Ville_Club.Name = "lbl_Ville_Club";
            this.lbl_Ville_Club.Size = new System.Drawing.Size(34, 17);
            this.lbl_Ville_Club.TabIndex = 9;
            this.lbl_Ville_Club.Text = "Ville";
            // 
            // txt_Ville_CLub
            // 
            this.txt_Ville_CLub.Location = new System.Drawing.Point(149, 137);
            this.txt_Ville_CLub.Name = "txt_Ville_CLub";
            this.txt_Ville_CLub.PromptChar = ' ';
            this.txt_Ville_CLub.Size = new System.Drawing.Size(119, 20);
            this.txt_Ville_CLub.TabIndex = 8;
            // 
            // txt_Cp_Club
            // 
            this.txt_Cp_Club.Location = new System.Drawing.Point(149, 100);
            this.txt_Cp_Club.Mask = "00000";
            this.txt_Cp_Club.Name = "txt_Cp_Club";
            this.txt_Cp_Club.PromptChar = ' ';
            this.txt_Cp_Club.Size = new System.Drawing.Size(119, 20);
            this.txt_Cp_Club.TabIndex = 6;
            // 
            // lbl_Cp_Club
            // 
            this.lbl_Cp_Club.AutoSize = true;
            this.lbl_Cp_Club.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cp_Club.Location = new System.Drawing.Point(6, 100);
            this.lbl_Cp_Club.Name = "lbl_Cp_Club";
            this.lbl_Cp_Club.Size = new System.Drawing.Size(88, 17);
            this.lbl_Cp_Club.TabIndex = 7;
            this.lbl_Cp_Club.Text = "Code Postal";
            // 
            // Modifier_Club
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 275);
            this.Controls.Add(this.ajout);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 314);
            this.MinimumSize = new System.Drawing.Size(540, 314);
            this.Name = "Modifier_Club";
            this.Text = "Modifier_Club";
            this.Load += new System.EventHandler(this.Modifier_Club_Load);
            this.ajout.ResumeLayout(false);
            this.ajout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ajout;
        private System.Windows.Forms.Label lbl_erreur;
        private System.Windows.Forms.MaskedTextBox txt_Tel_Club;
        private System.Windows.Forms.Label lbl_Tel_Club;
        private System.Windows.Forms.MaskedTextBox txt_Mail_Club;
        private System.Windows.Forms.Button fermeraj;
        private System.Windows.Forms.Button btn_Club_Modif;
        private System.Windows.Forms.MaskedTextBox txt_Titre_Club;
        private System.Windows.Forms.Label lbl_Mail_Club;
        private System.Windows.Forms.Label lbl_Titre_club;
        private System.Windows.Forms.Label lbl_Adr_Club;
        private System.Windows.Forms.MaskedTextBox txt_Url_Club;
        private System.Windows.Forms.MaskedTextBox txt_Adr_Club;
        private System.Windows.Forms.Label lbl_Url_Club;
        private System.Windows.Forms.Label lbl_Ville_Club;
        private System.Windows.Forms.MaskedTextBox txt_Ville_CLub;
        private System.Windows.Forms.MaskedTextBox txt_Cp_Club;
        private System.Windows.Forms.Label lbl_Cp_Club;
        private System.Windows.Forms.Button btn_Annuler;
    }
}