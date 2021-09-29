
namespace AdoNetWindow
{
    partial class frmCourseRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourseRegistration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCourseRegistration = new System.Windows.Forms.ToolStripButton();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCourseResistration = new System.Windows.Forms.DataGridView();
            this.gridSubject = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseResistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.cbStudent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 93);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCourseRegistration});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(618, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCourseRegistration
            // 
            this.btnCourseRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnCourseRegistration.Image")));
            this.btnCourseRegistration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCourseRegistration.Name = "btnCourseRegistration";
            this.btnCourseRegistration.Size = new System.Drawing.Size(112, 29);
            this.btnCourseRegistration.Text = "수강신청";
            this.btnCourseRegistration.Click += new System.EventHandler(this.btnCourseRegistration_Click);
            // 
            // cbStudent
            // 
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(120, 47);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(126, 26);
            this.cbStudent.TabIndex = 1;
            this.cbStudent.SelectionChangeCommitted += new System.EventHandler(this.cbStudent_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "학생선택:";
            // 
            // gridCourseResistration
            // 
            this.gridCourseResistration.AllowUserToAddRows = false;
            this.gridCourseResistration.AllowUserToDeleteRows = false;
            this.gridCourseResistration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridCourseResistration.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridCourseResistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourseResistration.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridCourseResistration.Location = new System.Drawing.Point(0, 93);
            this.gridCourseResistration.MultiSelect = false;
            this.gridCourseResistration.Name = "gridCourseResistration";
            this.gridCourseResistration.ReadOnly = true;
            this.gridCourseResistration.RowHeadersWidth = 62;
            this.gridCourseResistration.RowTemplate.Height = 30;
            this.gridCourseResistration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCourseResistration.Size = new System.Drawing.Size(282, 357);
            this.gridCourseResistration.TabIndex = 1;
            // 
            // gridSubject
            // 
            this.gridSubject.AllowUserToAddRows = false;
            this.gridSubject.AllowUserToDeleteRows = false;
            this.gridSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridSubject.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSubject.Location = new System.Drawing.Point(282, 93);
            this.gridSubject.Name = "gridSubject";
            this.gridSubject.ReadOnly = true;
            this.gridSubject.RowHeadersWidth = 62;
            this.gridSubject.RowTemplate.Height = 30;
            this.gridSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSubject.Size = new System.Drawing.Size(340, 357);
            this.gridSubject.TabIndex = 2;
            // 
            // frmCourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.gridSubject);
            this.Controls.Add(this.gridCourseResistration);
            this.Controls.Add(this.panel1);
            this.Name = "frmCourseRegistration";
            this.Text = "수강신청";
            this.Load += new System.EventHandler(this.frmCourseRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseResistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView gridCourseResistration;
        private System.Windows.Forms.DataGridView gridSubject;
        private System.Windows.Forms.ToolStripButton btnCourseRegistration;
    }
}