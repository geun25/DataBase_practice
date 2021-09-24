
namespace AdoNetWindow
{
    partial class WinMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.학생관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mb학생등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.수강신청ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.과목관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tm종료 = new System.Windows.Forms.ToolStripMenuItem();
            this.mb과목등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.학생관리ToolStripMenuItem,
            this.과목관리ToolStripMenuItem,
            this.tm종료});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 학생관리ToolStripMenuItem
            // 
            this.학생관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb학생등록,
            this.수강신청ToolStripMenuItem});
            this.학생관리ToolStripMenuItem.Name = "학생관리ToolStripMenuItem";
            this.학생관리ToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.학생관리ToolStripMenuItem.Text = "학생관리";
            // 
            // mb학생등록
            // 
            this.mb학생등록.Name = "mb학생등록";
            this.mb학생등록.Size = new System.Drawing.Size(270, 34);
            this.mb학생등록.Text = "학생등록";
            this.mb학생등록.Click += new System.EventHandler(this.mb학생등록_Click);
            // 
            // 수강신청ToolStripMenuItem
            // 
            this.수강신청ToolStripMenuItem.Name = "수강신청ToolStripMenuItem";
            this.수강신청ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.수강신청ToolStripMenuItem.Text = "수강신청";
            // 
            // 과목관리ToolStripMenuItem
            // 
            this.과목관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb과목등록});
            this.과목관리ToolStripMenuItem.Name = "과목관리ToolStripMenuItem";
            this.과목관리ToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.과목관리ToolStripMenuItem.Text = "과목관리";
            // 
            // tm종료
            // 
            this.tm종료.Name = "tm종료";
            this.tm종료.Size = new System.Drawing.Size(64, 29);
            this.tm종료.Text = "종료";
            // 
            // mb과목등록
            // 
            this.mb과목등록.Name = "mb과목등록";
            this.mb과목등록.Size = new System.Drawing.Size(270, 34);
            this.mb과목등록.Text = "과목등록";
            this.mb과목등록.Click += new System.EventHandler(this.mb과목등록_Click);
            // 
            // WinMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WinMain";
            this.Text = "WinMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 학생관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mb학생등록;
        private System.Windows.Forms.ToolStripMenuItem 수강신청ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 과목관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tm종료;
        private System.Windows.Forms.ToolStripMenuItem mb과목등록;
    }
}