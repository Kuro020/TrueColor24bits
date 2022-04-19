
namespace TrueColor24bits
{
    partial class TelaPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblCores = new System.Windows.Forms.Label();
            this.tbxRed = new System.Windows.Forms.TextBox();
            this.tbxGreen = new System.Windows.Forms.TextBox();
            this.tbxBlue = new System.Windows.Forms.TextBox();
            this.hsbRed = new System.Windows.Forms.HScrollBar();
            this.hsbGreen = new System.Windows.Forms.HScrollBar();
            this.hsbBlue = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitulo.Location = new System.Drawing.Point(136, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(326, 44);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Paleta de Cores";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(81, 109);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(22, 23);
            this.lblRed.TabIndex = 1;
            // 
            // lblGreen
            // 
            this.lblGreen.BackColor = System.Drawing.Color.Green;
            this.lblGreen.Location = new System.Drawing.Point(81, 141);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(22, 23);
            this.lblGreen.TabIndex = 2;
            // 
            // lblBlue
            // 
            this.lblBlue.BackColor = System.Drawing.Color.Blue;
            this.lblBlue.Location = new System.Drawing.Point(81, 174);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(22, 23);
            this.lblBlue.TabIndex = 3;
            // 
            // lblCores
            // 
            this.lblCores.BackColor = System.Drawing.Color.White;
            this.lblCores.Location = new System.Drawing.Point(81, 222);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(408, 139);
            this.lblCores.TabIndex = 4;
            this.lblCores.Click += new System.EventHandler(this.lblCores_Click);
            // 
            // tbxRed
            // 
            this.tbxRed.Location = new System.Drawing.Point(121, 109);
            this.tbxRed.Name = "tbxRed";
            this.tbxRed.Size = new System.Drawing.Size(63, 23);
            this.tbxRed.TabIndex = 5;
            // 
            // tbxGreen
            // 
            this.tbxGreen.Location = new System.Drawing.Point(121, 141);
            this.tbxGreen.Name = "tbxGreen";
            this.tbxGreen.Size = new System.Drawing.Size(63, 23);
            this.tbxGreen.TabIndex = 6;
            // 
            // tbxBlue
            // 
            this.tbxBlue.Location = new System.Drawing.Point(121, 174);
            this.tbxBlue.Name = "tbxBlue";
            this.tbxBlue.Size = new System.Drawing.Size(63, 23);
            this.tbxBlue.TabIndex = 7;
            // 
            // hsbRed
            // 
            this.hsbRed.LargeChange = 1;
            this.hsbRed.Location = new System.Drawing.Point(201, 109);
            this.hsbRed.Maximum = 255;
            this.hsbRed.Name = "hsbRed";
            this.hsbRed.Size = new System.Drawing.Size(288, 23);
            this.hsbRed.TabIndex = 8;
            this.hsbRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbRed_Scroll);
            // 
            // hsbGreen
            // 
            this.hsbGreen.LargeChange = 1;
            this.hsbGreen.Location = new System.Drawing.Point(201, 141);
            this.hsbGreen.Maximum = 255;
            this.hsbGreen.Name = "hsbGreen";
            this.hsbGreen.Size = new System.Drawing.Size(288, 23);
            this.hsbGreen.TabIndex = 9;
            this.hsbGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbGreen_Scroll);
            // 
            // hsbBlue
            // 
            this.hsbBlue.LargeChange = 1;
            this.hsbBlue.Location = new System.Drawing.Point(201, 174);
            this.hsbBlue.Maximum = 255;
            this.hsbBlue.Name = "hsbBlue";
            this.hsbBlue.Size = new System.Drawing.Size(288, 23);
            this.hsbBlue.TabIndex = 10;
            this.hsbBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbBlue_Scroll);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.hsbBlue);
            this.Controls.Add(this.hsbGreen);
            this.Controls.Add(this.hsbRed);
            this.Controls.Add(this.tbxBlue);
            this.Controls.Add(this.tbxGreen);
            this.Controls.Add(this.tbxRed);
            this.Controls.Add(this.lblCores);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblTitulo);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cores 24 Bits";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.TextBox tbxRed;
        private System.Windows.Forms.TextBox tbxGreen;
        private System.Windows.Forms.TextBox tbxBlue;
        private System.Windows.Forms.HScrollBar hsbRed;
        private System.Windows.Forms.HScrollBar hsbGreen;
        private System.Windows.Forms.HScrollBar hsbBlue;
    }
}