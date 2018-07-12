namespace ExemploBancoDados02
{
    partial class EstatisticasHerois
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalContasBancarias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total das Contas Bancárias";
            // 
            // lblTotalContasBancarias
            // 
            this.lblTotalContasBancarias.AutoSize = true;
            this.lblTotalContasBancarias.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalContasBancarias.Location = new System.Drawing.Point(264, 20);
            this.lblTotalContasBancarias.Name = "lblTotalContasBancarias";
            this.lblTotalContasBancarias.Size = new System.Drawing.Size(21, 20);
            this.lblTotalContasBancarias.TabIndex = 8;
            this.lblTotalContasBancarias.Text = "0";
            // 
            // EstatisticasHerois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 404);
            this.Controls.Add(this.lblTotalContasBancarias);
            this.Controls.Add(this.label1);
            this.Name = "EstatisticasHerois";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EstatisticasHerois";
            this.Load += new System.EventHandler(this.EstatisticasHerois_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalContasBancarias;
    }
}