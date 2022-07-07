namespace Sorteio
{
    partial class GerenciadorSorteios
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
            this.lblSorteio = new System.Windows.Forms.Label();
            this.cbbSorteios = new System.Windows.Forms.ComboBox();
            this.btnCrirarSorteio = new System.Windows.Forms.Button();
            this.btnCarregarSorteio = new System.Windows.Forms.Button();
            this.btnDeletarSorteio = new System.Windows.Forms.Button();
            this.gpbSorteio = new System.Windows.Forms.GroupBox();
            this.btnRemoverParticipante = new System.Windows.Forms.Button();
            this.btnAddParticipante = new System.Windows.Forms.Button();
            this.btnEfetuarSorteio = new System.Windows.Forms.Button();
            this.lblParticipantes = new System.Windows.Forms.Label();
            this.lstParticipantes = new System.Windows.Forms.ListBox();
            this.gpbSorteio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSorteio
            // 
            this.lblSorteio.AutoSize = true;
            this.lblSorteio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorteio.Location = new System.Drawing.Point(13, 13);
            this.lblSorteio.Name = "lblSorteio";
            this.lblSorteio.Size = new System.Drawing.Size(57, 17);
            this.lblSorteio.TabIndex = 0;
            this.lblSorteio.Text = "Sorteio:";
            // 
            // cbbSorteios
            // 
            this.cbbSorteios.FormattingEnabled = true;
            this.cbbSorteios.Location = new System.Drawing.Point(77, 13);
            this.cbbSorteios.Name = "cbbSorteios";
            this.cbbSorteios.Size = new System.Drawing.Size(236, 21);
            this.cbbSorteios.TabIndex = 1;
            this.cbbSorteios.SelectedValueChanged += new System.EventHandler(this.cbbSorteios_SelectedValueChanged);
            // 
            // btnCrirarSorteio
            // 
            this.btnCrirarSorteio.Location = new System.Drawing.Point(12, 41);
            this.btnCrirarSorteio.Name = "btnCrirarSorteio";
            this.btnCrirarSorteio.Size = new System.Drawing.Size(79, 23);
            this.btnCrirarSorteio.TabIndex = 2;
            this.btnCrirarSorteio.Text = "Criar Sorteio";
            this.btnCrirarSorteio.UseVisualStyleBackColor = true;
            // 
            // btnCarregarSorteio
            // 
            this.btnCarregarSorteio.Location = new System.Drawing.Point(238, 41);
            this.btnCarregarSorteio.Name = "btnCarregarSorteio";
            this.btnCarregarSorteio.Size = new System.Drawing.Size(75, 23);
            this.btnCarregarSorteio.TabIndex = 3;
            this.btnCarregarSorteio.Text = "Carregar";
            this.btnCarregarSorteio.UseVisualStyleBackColor = true;
            this.btnCarregarSorteio.Click += new System.EventHandler(this.btnCarregarSorteio_Click);
            // 
            // btnDeletarSorteio
            // 
            this.btnDeletarSorteio.Location = new System.Drawing.Point(157, 41);
            this.btnDeletarSorteio.Name = "btnDeletarSorteio";
            this.btnDeletarSorteio.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarSorteio.TabIndex = 4;
            this.btnDeletarSorteio.Text = "Deletar";
            this.btnDeletarSorteio.UseVisualStyleBackColor = true;
            // 
            // gpbSorteio
            // 
            this.gpbSorteio.Controls.Add(this.btnRemoverParticipante);
            this.gpbSorteio.Controls.Add(this.btnAddParticipante);
            this.gpbSorteio.Controls.Add(this.btnEfetuarSorteio);
            this.gpbSorteio.Controls.Add(this.lblParticipantes);
            this.gpbSorteio.Controls.Add(this.lstParticipantes);
            this.gpbSorteio.Location = new System.Drawing.Point(12, 86);
            this.gpbSorteio.Name = "gpbSorteio";
            this.gpbSorteio.Size = new System.Drawing.Size(320, 352);
            this.gpbSorteio.TabIndex = 5;
            this.gpbSorteio.TabStop = false;
            this.gpbSorteio.Text = "Sorteio";
            // 
            // btnRemoverParticipante
            // 
            this.btnRemoverParticipante.Location = new System.Drawing.Point(215, 75);
            this.btnRemoverParticipante.Name = "btnRemoverParticipante";
            this.btnRemoverParticipante.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverParticipante.TabIndex = 4;
            this.btnRemoverParticipante.Text = "Remover";
            this.btnRemoverParticipante.UseVisualStyleBackColor = true;
            this.btnRemoverParticipante.Click += new System.EventHandler(this.btnRemoverParticipante_Click);
            // 
            // btnAddParticipante
            // 
            this.btnAddParticipante.Location = new System.Drawing.Point(214, 45);
            this.btnAddParticipante.Name = "btnAddParticipante";
            this.btnAddParticipante.Size = new System.Drawing.Size(75, 23);
            this.btnAddParticipante.TabIndex = 3;
            this.btnAddParticipante.Text = "Adicionar";
            this.btnAddParticipante.UseVisualStyleBackColor = true;
            this.btnAddParticipante.Click += new System.EventHandler(this.btnAddParticipante_Click);
            // 
            // btnEfetuarSorteio
            // 
            this.btnEfetuarSorteio.Location = new System.Drawing.Point(214, 305);
            this.btnEfetuarSorteio.Name = "btnEfetuarSorteio";
            this.btnEfetuarSorteio.Size = new System.Drawing.Size(100, 41);
            this.btnEfetuarSorteio.TabIndex = 2;
            this.btnEfetuarSorteio.Text = "Efetuar Sorteio";
            this.btnEfetuarSorteio.UseVisualStyleBackColor = true;
            // 
            // lblParticipantes
            // 
            this.lblParticipantes.AutoSize = true;
            this.lblParticipantes.Location = new System.Drawing.Point(7, 26);
            this.lblParticipantes.Name = "lblParticipantes";
            this.lblParticipantes.Size = new System.Drawing.Size(71, 13);
            this.lblParticipantes.TabIndex = 1;
            this.lblParticipantes.Text = "Participantes:";
            // 
            // lstParticipantes
            // 
            this.lstParticipantes.FormattingEnabled = true;
            this.lstParticipantes.Location = new System.Drawing.Point(6, 45);
            this.lstParticipantes.Name = "lstParticipantes";
            this.lstParticipantes.Size = new System.Drawing.Size(202, 303);
            this.lstParticipantes.TabIndex = 0;
            // 
            // GerenciadorSorteios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.gpbSorteio);
            this.Controls.Add(this.btnDeletarSorteio);
            this.Controls.Add(this.btnCarregarSorteio);
            this.Controls.Add(this.btnCrirarSorteio);
            this.Controls.Add(this.cbbSorteios);
            this.Controls.Add(this.lblSorteio);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 489);
            this.MinimumSize = new System.Drawing.Size(360, 489);
            this.Name = "GerenciadorSorteios";
            this.Text = "Gerenciador de Sorteios";
            this.Load += new System.EventHandler(this.GerenciadorSorteios_Load);
            this.gpbSorteio.ResumeLayout(false);
            this.gpbSorteio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSorteio;
        private System.Windows.Forms.ComboBox cbbSorteios;
        private System.Windows.Forms.Button btnCrirarSorteio;
        private System.Windows.Forms.Button btnCarregarSorteio;
        private System.Windows.Forms.Button btnDeletarSorteio;
        private System.Windows.Forms.GroupBox gpbSorteio;
        private System.Windows.Forms.Button btnRemoverParticipante;
        private System.Windows.Forms.Button btnAddParticipante;
        private System.Windows.Forms.Button btnEfetuarSorteio;
        private System.Windows.Forms.Label lblParticipantes;
        private System.Windows.Forms.ListBox lstParticipantes;
    }
}