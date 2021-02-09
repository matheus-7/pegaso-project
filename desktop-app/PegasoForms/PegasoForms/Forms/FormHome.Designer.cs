
namespace PegasoForms.Forms
{
    partial class FormHome
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
            this.MainStripMenu = new System.Windows.Forms.MenuStrip();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EntitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnitMeasurementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MovementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcModules = new System.Windows.Forms.TabControl();
            this.MainStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStripMenu
            // 
            this.MainStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.MovementsToolStripMenuItem,
            this.ReportsToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.MainStripMenu.Location = new System.Drawing.Point(0, 0);
            this.MainStripMenu.Name = "MainStripMenu";
            this.MainStripMenu.Size = new System.Drawing.Size(682, 24);
            this.MainStripMenu.TabIndex = 0;
            this.MainStripMenu.Text = "menuStrip1";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompanyToolStripMenuItem,
            this.EntitiesToolStripMenuItem,
            this.MaterialsToolStripMenuItem,
            this.UsersToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.SettingsToolStripMenuItem.Text = "Settings";
            // 
            // CompanyToolStripMenuItem
            // 
            this.CompanyToolStripMenuItem.Name = "CompanyToolStripMenuItem";
            this.CompanyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CompanyToolStripMenuItem.Text = "Company";
            this.CompanyToolStripMenuItem.Click += new System.EventHandler(this.CompanyToolStripMenuItem_Click);
            // 
            // EntitiesToolStripMenuItem
            // 
            this.EntitiesToolStripMenuItem.Name = "EntitiesToolStripMenuItem";
            this.EntitiesToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.EntitiesToolStripMenuItem.Text = "Entities";
            // 
            // MaterialsToolStripMenuItem
            // 
            this.MaterialsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoriesToolStripMenuItem,
            this.ProductsToolStripMenuItem,
            this.UnitMeasurementsToolStripMenuItem});
            this.MaterialsToolStripMenuItem.Name = "MaterialsToolStripMenuItem";
            this.MaterialsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.MaterialsToolStripMenuItem.Text = "Materials";
            // 
            // CategoriesToolStripMenuItem
            // 
            this.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem";
            this.CategoriesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.CategoriesToolStripMenuItem.Text = "Categories";
            // 
            // ProductsToolStripMenuItem
            // 
            this.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem";
            this.ProductsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ProductsToolStripMenuItem.Text = "Products";
            // 
            // UnitMeasurementsToolStripMenuItem
            // 
            this.UnitMeasurementsToolStripMenuItem.Name = "UnitMeasurementsToolStripMenuItem";
            this.UnitMeasurementsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.UnitMeasurementsToolStripMenuItem.Text = "Unit Measurements";
            // 
            // UsersToolStripMenuItem
            // 
            this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            this.UsersToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.UsersToolStripMenuItem.Text = "Users";
            this.UsersToolStripMenuItem.Click += new System.EventHandler(this.UsersToolStripMenuItem_Click);
            // 
            // MovementsToolStripMenuItem
            // 
            this.MovementsToolStripMenuItem.Name = "MovementsToolStripMenuItem";
            this.MovementsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.MovementsToolStripMenuItem.Text = "Movements";
            // 
            // ReportsToolStripMenuItem
            // 
            this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            this.ReportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ReportsToolStripMenuItem.Text = "Reports";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // tbcModules
            // 
            this.tbcModules.Location = new System.Drawing.Point(0, 27);
            this.tbcModules.Name = "tbcModules";
            this.tbcModules.SelectedIndex = 0;
            this.tbcModules.Size = new System.Drawing.Size(682, 352);
            this.tbcModules.TabIndex = 1;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 385);
            this.Controls.Add(this.tbcModules);
            this.Controls.Add(this.MainStripMenu);
            this.MainMenuStrip = this.MainStripMenu;
            this.Name = "FormHome";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.FormHome_ResizeEnd);
            this.MainStripMenu.ResumeLayout(false);
            this.MainStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainStripMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MovementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MaterialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EntitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnitMeasurementsToolStripMenuItem;
        private System.Windows.Forms.TabControl tbcModules;
    }
}

