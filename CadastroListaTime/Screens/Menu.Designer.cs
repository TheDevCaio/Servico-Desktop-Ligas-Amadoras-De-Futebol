namespace CadastroListaTime
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbcadastrados = new System.Windows.Forms.ComboBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnexibir = new System.Windows.Forms.Button();
            this.txtexibir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(84, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de time de futebol para copa JF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(84, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(84, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Consulte a lista de times já cadastrados:";
            // 
            // cmbcadastrados
            // 
            this.cmbcadastrados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcadastrados.FormattingEnabled = true;
            this.cmbcadastrados.Location = new System.Drawing.Point(400, 161);
            this.cmbcadastrados.Name = "cmbcadastrados";
            this.cmbcadastrados.Size = new System.Drawing.Size(137, 21);
            this.cmbcadastrados.TabIndex = 3;
            // 
            // txttime
            // 
            this.txttime.BackColor = System.Drawing.SystemColors.InfoText;
            this.txttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txttime.Location = new System.Drawing.Point(229, 101);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(174, 20);
            this.txttime.TabIndex = 4;
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncadastrar.Location = new System.Drawing.Point(462, 96);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 5;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexcluir.Location = new System.Drawing.Point(462, 287);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 6;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnexibir
            // 
            this.btnexibir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexibir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexibir.Location = new System.Drawing.Point(462, 242);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(75, 23);
            this.btnexibir.TabIndex = 7;
            this.btnexibir.Text = "Exibir";
            this.btnexibir.UseVisualStyleBackColor = false;
            this.btnexibir.Click += new System.EventHandler(this.btnexibir_Click);
            // 
            // txtexibir
            // 
            this.txtexibir.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtexibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexibir.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtexibir.Location = new System.Drawing.Point(84, 204);
            this.txtexibir.Multiline = true;
            this.txtexibir.Name = "txtexibir";
            this.txtexibir.Size = new System.Drawing.Size(319, 106);
            this.txtexibir.TabIndex = 8;
            this.txtexibir.TextChanged += new System.EventHandler(this.txtexibir_TextChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(647, 340);
            this.Controls.Add(this.txtexibir);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.cmbcadastrados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de times para JF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbcadastrados;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnexibir;
        private System.Windows.Forms.TextBox txtexibir;
    }
}

