using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SOS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class SOS : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SOS));
            Label1 = new Label();
            btn_Submit = new Button();
            Label2 = new Label();
            lbl_Date = new Label();
            lbl_User = new Label();
            btn_Cancel = new Button();
            prgrs_Submit = new ProgressBar();
            grpbx_Issue = new GroupBox();
            txtbx_Problem = new TextBox();
            PictureBox2 = new PictureBox();
            lbl_Progress = new Label();
            Label3 = new Label();
            grpbx_Issue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Calibri", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(30, 27);
            Label1.Name = "Label1";
            Label1.Size = new Size(43, 19);
            Label1.TabIndex = 0;
            Label1.Text = "User:";
            // 
            // btn_Submit
            // 
            btn_Submit.Location = new Point(469, 319);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(75, 23);
            btn_Submit.TabIndex = 1;
            btn_Submit.Text = "Submit";
            btn_Submit.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Calibri", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(28, 49);
            Label2.Name = "Label2";
            Label2.Size = new Size(46, 19);
            Label2.TabIndex = 2;
            Label2.Text = "Time:";
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Font = new Font("Calibri", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Date.Location = new Point(77, 49);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(16, 19);
            lbl_Date.TabIndex = 4;
            lbl_Date.Text = "?";
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Font = new Font("Calibri", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_User.Location = new Point(77, 27);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(16, 19);
            lbl_User.TabIndex = 3;
            lbl_User.Text = "?";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(388, 319);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 5;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // prgrs_Submit
            // 
            prgrs_Submit.Location = new Point(31, 309);
            prgrs_Submit.Name = "prgrs_Submit";
            prgrs_Submit.Size = new Size(334, 23);
            prgrs_Submit.TabIndex = 6;
            // 
            // grpbx_Issue
            // 
            grpbx_Issue.Controls.Add(txtbx_Problem);
            grpbx_Issue.Font = new Font("Calibri", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbx_Issue.Location = new Point(30, 90);
            grpbx_Issue.Name = "grpbx_Issue";
            grpbx_Issue.Size = new Size(514, 213);
            grpbx_Issue.TabIndex = 7;
            grpbx_Issue.TabStop = false;
            grpbx_Issue.Text = "Problem";
            // 
            // txtbx_Problem
            // 
            txtbx_Problem.Location = new Point(24, 26);
            txtbx_Problem.Multiline = true;
            txtbx_Problem.Name = "txtbx_Problem";
            txtbx_Problem.ScrollBars = ScrollBars.Vertical;
            txtbx_Problem.Size = new Size(472, 167);
            txtbx_Problem.TabIndex = 8;
            // 
            // PictureBox2
            // 
            PictureBox2.BackgroundImage = (Image)resources.GetObject("PictureBox2.BackgroundImage");
            PictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox2.Location = new Point(388, 14);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(147, 70);
            PictureBox2.TabIndex = 10;
            PictureBox2.TabStop = false;
            // 
            // lbl_Progress
            // 
            lbl_Progress.AutoSize = true;
            lbl_Progress.Location = new Point(32, 335);
            lbl_Progress.Name = "lbl_Progress";
            lbl_Progress.Size = new Size(13, 13);
            lbl_Progress.TabIndex = 11;
            lbl_Progress.Text = "?";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(477, 349);
            Label3.Name = "Label3";
            Label3.Size = new Size(94, 12);
            Label3.TabIndex = 12;
            Label3.Text = "© Keith Harrison 2017";
            // 
            // SOS
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 361);
            Controls.Add(Label3);
            Controls.Add(lbl_Progress);
            Controls.Add(PictureBox2);
            Controls.Add(grpbx_Issue);
            Controls.Add(prgrs_Submit);
            Controls.Add(btn_Cancel);
            Controls.Add(lbl_Date);
            Controls.Add(lbl_User);
            Controls.Add(Label2);
            Controls.Add(btn_Submit);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SOS";
            Text = "SOS";
            grpbx_Issue.ResumeLayout(false);
            grpbx_Issue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label Label1;
        internal Button btn_Submit;
        internal Label Label2;
        internal Label lbl_Date;
        internal Label lbl_User;
        internal Button btn_Cancel;
        internal ProgressBar prgrs_Submit;
        internal GroupBox grpbx_Issue;
        internal TextBox txtbx_Problem;
        internal PictureBox PictureBox2;
        internal Label lbl_Progress;
        internal Label Label3;

    }
}