
namespace AdoNetWindow
{
    partial class frmSubjectAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.btnSubjectAdd = new System.Windows.Forms.Button();
            this.grdSubject = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSubjectAdd);
            this.panel1.Controls.Add(this.txtSubjectName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 89);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "과목명:";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(120, 26);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(213, 28);
            this.txtSubjectName.TabIndex = 1;
            // 
            // btnSubjectAdd
            // 
            this.btnSubjectAdd.Location = new System.Drawing.Point(352, 29);
            this.btnSubjectAdd.Name = "btnSubjectAdd";
            this.btnSubjectAdd.Size = new System.Drawing.Size(74, 28);
            this.btnSubjectAdd.TabIndex = 2;
            this.btnSubjectAdd.Text = "등록";
            this.btnSubjectAdd.UseVisualStyleBackColor = true;
            this.btnSubjectAdd.Click += new System.EventHandler(this.btnSubjectAdd_Click);
            // 
            // grdSubject
            // 
            this.grdSubject.AllowUserToAddRows = false;
            this.grdSubject.AllowUserToDeleteRows = false;
            this.grdSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdSubject.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSubject.Location = new System.Drawing.Point(0, 89);
            this.grdSubject.Name = "grdSubject";
            this.grdSubject.RowHeadersWidth = 62;
            this.grdSubject.RowTemplate.Height = 30;
            this.grdSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSubject.Size = new System.Drawing.Size(800, 361);
            this.grdSubject.TabIndex = 1;
            this.grdSubject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grdSubject_MouseClick);
            // 
            // frmSubjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdSubject);
            this.Controls.Add(this.panel1);
            this.Name = "frmSubjectAdd";
            this.Text = "과목관리";
            this.Load += new System.EventHandler(this.frmSubjectAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubjectAdd;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.DataGridView grdSubject;
    }
}