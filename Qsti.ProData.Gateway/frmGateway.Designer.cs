
namespace Qsti.ProData.Gateway
{
    partial class frmGateway
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGateway));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOuvirPorta = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ProData - Gateway";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(744, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORTAS:";
            // 
            // lblOuvirPorta
            // 
            this.lblOuvirPorta.AutoSize = true;
            this.lblOuvirPorta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOuvirPorta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOuvirPorta.Location = new System.Drawing.Point(73, 99);
            this.lblOuvirPorta.Name = "lblOuvirPorta";
            this.lblOuvirPorta.Size = new System.Drawing.Size(103, 15);
            this.lblOuvirPorta.TabIndex = 2;
            this.lblOuvirPorta.Text = "0000, 0000, 0000";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.Location = new System.Drawing.Point(460, 131);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(438, 34);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP:";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIp.Location = new System.Drawing.Point(73, 74);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(58, 15);
            this.lblIp.TabIndex = 5;
            this.lblIp.Text = "127.0.0.1";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(12, 171);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(886, 321);
            this.txtMensagem.TabIndex = 6;
            // 
            // btnParar
            // 
            this.btnParar.Enabled = false;
            this.btnParar.Location = new System.Drawing.Point(12, 131);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(438, 33);
            this.btnParar.TabIndex = 7;
            this.btnParar.Text = "PARAR";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(814, 498);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 34);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmGateway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 536);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblOuvirPorta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmGateway";
            this.Text = "Qsti.ProData.Gateway";
            this.Load += new System.EventHandler(this.frmGateway_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOuvirPorta;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

