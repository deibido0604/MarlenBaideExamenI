namespace MarlenBaideExamenI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.MenuEjercicio1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEjercicio2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEjercicio3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBase = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEjercicio1,
            this.MenuEjercicio2,
            this.MenuEjercicio3});
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            // 
            // MenuEjercicio1
            // 
            this.MenuEjercicio1.Name = "MenuEjercicio1";
            resources.ApplyResources(this.MenuEjercicio1, "MenuEjercicio1");
            this.MenuEjercicio1.Click += new System.EventHandler(this.ejercicioIToolStripMenuItem_Click);
            // 
            // MenuEjercicio2
            // 
            this.MenuEjercicio2.Name = "MenuEjercicio2";
            resources.ApplyResources(this.MenuEjercicio2, "MenuEjercicio2");
            this.MenuEjercicio2.Click += new System.EventHandler(this.MenuEjercicio2_Click);
            // 
            // MenuEjercicio3
            // 
            this.MenuEjercicio3.Name = "MenuEjercicio3";
            resources.ApplyResources(this.MenuEjercicio3, "MenuEjercicio3");
            this.MenuEjercicio3.Click += new System.EventHandler(this.MenuEjercicio3_Click);
            // 
            // panelBase
            // 
            resources.ApplyResources(this.panelBase, "panelBase");
            this.panelBase.Name = "panelBase";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem MenuEjercicio1;
        private ToolStripMenuItem MenuEjercicio2;
        private ToolStripMenuItem MenuEjercicio3;
        private Panel panelBase;
    }
}