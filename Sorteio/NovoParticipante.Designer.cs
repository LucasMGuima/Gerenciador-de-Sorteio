namespace Sorteio
{
    partial class NovoParticipante
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.btnConfrimar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(23, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(179, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(82, 38);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(179, 20);
            this.txtContato.TabIndex = 3;
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(12, 38);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(65, 17);
            this.lblContato.TabIndex = 2;
            this.lblContato.Text = "Contato: ";
            // 
            // btnConfrimar
            // 
            this.btnConfrimar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfrimar.Location = new System.Drawing.Point(171, 75);
            this.btnConfrimar.Name = "btnConfrimar";
            this.btnConfrimar.Size = new System.Drawing.Size(90, 28);
            this.btnConfrimar.TabIndex = 4;
            this.btnConfrimar.Text = "Confirmar";
            this.btnConfrimar.UseVisualStyleBackColor = true;
            this.btnConfrimar.Click += new System.EventHandler(this.btnConfrimar_Click);
            // 
            // NovoParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 123);
            this.Controls.Add(this.btnConfrimar);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(307, 162);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(307, 162);
            this.Name = "NovoParticipante";
            this.Text = "Novo Participante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Button btnConfrimar;
    }
}