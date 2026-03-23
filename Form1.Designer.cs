namespace VinculoComUC5
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
            this.lboDados = new System.Windows.Forms.ListBox();
            this.btnObterDados = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblClasseA = new System.Windows.Forms.Label();
            this.lblClasseB = new System.Windows.Forms.Label();
            this.lblClasseC = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSalvarComo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboDados
            // 
            this.lboDados.FormattingEnabled = true;
            this.lboDados.ItemHeight = 20;
            this.lboDados.Location = new System.Drawing.Point(18, 19);
            this.lboDados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lboDados.Name = "lboDados";
            this.lboDados.Size = new System.Drawing.Size(178, 144);
            this.lboDados.TabIndex = 0;
            this.lboDados.SelectedIndexChanged += new System.EventHandler(this.lboDados_SelectedIndexChanged);
            // 
            // btnObterDados
            // 
            this.btnObterDados.Location = new System.Drawing.Point(19, 175);
            this.btnObterDados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnObterDados.Name = "btnObterDados";
            this.btnObterDados.Size = new System.Drawing.Size(179, 35);
            this.btnObterDados.TabIndex = 1;
            this.btnObterDados.Text = "Extrair dados";
            this.btnObterDados.UseVisualStyleBackColor = true;
            this.btnObterDados.Click += new System.EventHandler(this.btnObterDados_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(205, 175);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(186, 35);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblClasseA
            // 
            this.lblClasseA.AutoSize = true;
            this.lblClasseA.Location = new System.Drawing.Point(228, 19);
            this.lblClasseA.Name = "lblClasseA";
            this.lblClasseA.Size = new System.Drawing.Size(83, 20);
            this.lblClasseA.TabIndex = 3;
            this.lblClasseA.Text = "lblClasseA";
            // 
            // lblClasseB
            // 
            this.lblClasseB.AutoSize = true;
            this.lblClasseB.Location = new System.Drawing.Point(228, 49);
            this.lblClasseB.Name = "lblClasseB";
            this.lblClasseB.Size = new System.Drawing.Size(83, 20);
            this.lblClasseB.TabIndex = 4;
            this.lblClasseB.Text = "lblClasseB";
            // 
            // lblClasseC
            // 
            this.lblClasseC.AutoSize = true;
            this.lblClasseC.Location = new System.Drawing.Point(228, 79);
            this.lblClasseC.Name = "lblClasseC";
            this.lblClasseC.Size = new System.Drawing.Size(83, 20);
            this.lblClasseC.TabIndex = 5;
            this.lblClasseC.Text = "lblClasseC";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(205, 121);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(186, 42);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSalvarComo
            // 
            this.btnSalvarComo.Location = new System.Drawing.Point(19, 219);
            this.btnSalvarComo.Name = "btnSalvarComo";
            this.btnSalvarComo.Size = new System.Drawing.Size(372, 38);
            this.btnSalvarComo.TabIndex = 7;
            this.btnSalvarComo.Text = "Salvar como";
            this.btnSalvarComo.UseVisualStyleBackColor = true;
            this.btnSalvarComo.Click += new System.EventHandler(this.btnSalvarComo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 269);
            this.Controls.Add(this.btnSalvarComo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblClasseC);
            this.Controls.Add(this.lblClasseB);
            this.Controls.Add(this.lblClasseA);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnObterDados);
            this.Controls.Add(this.lboDados);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboDados;
        private System.Windows.Forms.Button btnObterDados;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblClasseA;
        private System.Windows.Forms.Label lblClasseB;
        private System.Windows.Forms.Label lblClasseC;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSalvarComo;
    }
}

