namespace sistemaDesligamento
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMinutos = new System.Windows.Forms.TextBox();
            this.btnAgendarMin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDesliga = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbxAgendar = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESCOLHA O HORÁRIO";
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(259, 113);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(75, 23);
            this.btnAgendar.TabIndex = 2;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desligar daqui";
            // 
            // txbMinutos
            // 
            this.txbMinutos.Location = new System.Drawing.Point(232, 212);
            this.txbMinutos.Name = "txbMinutos";
            this.txbMinutos.Size = new System.Drawing.Size(140, 20);
            this.txbMinutos.TabIndex = 4;
            // 
            // btnAgendarMin
            // 
            this.btnAgendarMin.Location = new System.Drawing.Point(259, 249);
            this.btnAgendarMin.Name = "btnAgendarMin";
            this.btnAgendarMin.Size = new System.Drawing.Size(75, 23);
            this.btnAgendarMin.TabIndex = 5;
            this.btnAgendarMin.Text = "Agendar";
            this.btnAgendarMin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "OUTROS";
            // 
            // btnDesliga
            // 
            this.btnDesliga.Location = new System.Drawing.Point(249, 381);
            this.btnDesliga.Name = "btnDesliga";
            this.btnDesliga.Size = new System.Drawing.Size(100, 23);
            this.btnDesliga.TabIndex = 7;
            this.btnDesliga.Text = "Desligar Agora";
            this.btnDesliga.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(249, 410);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tbxAgendar
            // 
            this.tbxAgendar.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tbxAgendar.Location = new System.Drawing.Point(195, 69);
            this.tbxAgendar.Name = "tbxAgendar";
            this.tbxAgendar.Size = new System.Drawing.Size(200, 20);
            this.tbxAgendar.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxAgendar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDesliga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgendarMin);
            this.Controls.Add(this.txbMinutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMinutos;
        private System.Windows.Forms.Button btnAgendarMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDesliga;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker tbxAgendar;
    }
}

