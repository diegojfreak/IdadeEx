﻿namespace Aula5do4ex2
{
    partial class frmCNH
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Verifica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataUsuario = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Verifica
            // 
            this.Verifica.Location = new System.Drawing.Point(88, 99);
            this.Verifica.Name = "Verifica";
            this.Verifica.Size = new System.Drawing.Size(75, 23);
            this.Verifica.TabIndex = 0;
            this.Verifica.Text = "Verificar";
            this.Verifica.UseVisualStyleBackColor = true;
            this.Verifica.Click += new System.EventHandler(this.Verifica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione sua data de nascimento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataUsuario
            // 
            this.dataUsuario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataUsuario.Location = new System.Drawing.Point(51, 49);
            this.dataUsuario.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dataUsuario.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dataUsuario.Name = "dataUsuario";
            this.dataUsuario.Size = new System.Drawing.Size(150, 20);
            this.dataUsuario.TabIndex = 2;
            // 
            // frmCNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 131);
            this.Controls.Add(this.dataUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Verifica);
            this.MaximizeBox = false;
            this.Name = "frmCNH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerificaCNH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Verifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataUsuario;
    }
}

