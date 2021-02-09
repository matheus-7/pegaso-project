
namespace PegasoForms.Forms
{
    partial class FormCompany
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(3, 26);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(200, 20);
            this.TbNome.TabIndex = 5;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(0, 10);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(49, 13);
            this.LblNome.TabIndex = 4;
            this.LblNome.Text = "LblNome";
            // 
            // FormCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.LblNome);
            this.Name = "FormCompany";
            this.Size = new System.Drawing.Size(642, 324);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.Label LblNome;
    }
}
