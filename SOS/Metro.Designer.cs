using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SOS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Metro : MetroFramework.Forms.MetroForm
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Metro));
            MetroLabel1 = new MetroFramework.Controls.MetroLabel();
            btn_Submit = new MetroFramework.Controls.MetroButton();
            btn_Submit.Click += new EventHandler(btn_Submit_Click);
            GroupBox1 = new GroupBox();
            txtbx_Problem = new TextBox();
            txtbx_Problem.LostFocus += new EventHandler(TextBox1_LostFocus);
            PictureBox1 = new PictureBox();
            lbl_User = new MetroFramework.Controls.MetroLabel();
            MetroLabel3 = new MetroFramework.Controls.MetroLabel();
            lbl_Date = new MetroFramework.Controls.MetroLabel();
            btn_Cancel = new MetroFramework.Controls.MetroButton();
            btn_Cancel.Click += new EventHandler(btn_Cancel_Click);
            lbl_Progress = new MetroFramework.Controls.MetroLabel();
            Label3 = new Label();
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            GroupBox2 = new GroupBox();
            cb_Fix = new ComboBox();
            rb_Fix = new RadioButton();
            rb_Critical = new RadioButton();
            Label1 = new Label();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            GroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // MetroLabel1
            // 
            MetroLabel1.AutoSize = true;
            MetroLabel1.Location = new Point(452, 138);
            MetroLabel1.Name = "MetroLabel1";
            MetroLabel1.Size = new Size(38, 19);
            MetroLabel1.TabIndex = 32;
            MetroLabel1.Text = "User:";
            MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_Submit
            // 
            btn_Submit.Location = new Point(542, 299);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(75, 23);
            btn_Submit.TabIndex = 1;
            btn_Submit.Text = "Submit";
            btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(txtbx_Problem);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBox1.ForeColor = SystemColors.ControlDark;
            GroupBox1.Location = new Point(23, 132);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(420, 190);
            GroupBox1.TabIndex = 47;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Problem";
            // 
            // txtbx_Problem
            // 
            txtbx_Problem.BackColor = Color.FromArgb(35, 35, 35);
            txtbx_Problem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtbx_Problem.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbx_Problem.ForeColor = Color.ForestGreen;
            txtbx_Problem.Location = new Point(18, 25);
            txtbx_Problem.Multiline = true;
            txtbx_Problem.Name = "txtbx_Problem";
            txtbx_Problem.ScrollBars = ScrollBars.Vertical;
            txtbx_Problem.Size = new Size(384, 148);
            txtbx_Problem.TabIndex = 52;
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImage = (Image)resources.GetObject("PictureBox1.BackgroundImage");
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.Location = new Point(209, 22);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(234, 85);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(487, 138);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(15, 19);
            lbl_User.TabIndex = 48;
            lbl_User.Text = "?";
            lbl_User.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MetroLabel3
            // 
            MetroLabel3.AutoSize = true;
            MetroLabel3.Location = new Point(452, 159);
            MetroLabel3.Name = "MetroLabel3";
            MetroLabel3.Size = new Size(41, 19);
            MetroLabel3.TabIndex = 49;
            MetroLabel3.Text = "Time:";
            MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(488, 159);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(15, 19);
            lbl_Date.TabIndex = 50;
            lbl_Date.Text = "?";
            lbl_Date.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(461, 299);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 2;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_Progress
            // 
            lbl_Progress.AutoSize = true;
            lbl_Progress.Location = new Point(461, 271);
            lbl_Progress.Name = "lbl_Progress";
            lbl_Progress.Size = new Size(15, 19);
            lbl_Progress.TabIndex = 51;
            lbl_Progress.Text = "?";
            lbl_Progress.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.Gray;
            Label3.Location = new Point(0, 329);
            Label3.Name = "Label3";
            Label3.Size = new Size(94, 12);
            Label3.TabIndex = 52;
            Label3.Text = "© Keith Harrison 2021";
            // 
            // Timer1
            // 
            Timer1.Interval = 2000;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(cb_Fix);
            GroupBox2.Controls.Add(rb_Fix);
            GroupBox2.Controls.Add(rb_Critical);
            GroupBox2.ForeColor = SystemColors.ControlDark;
            GroupBox2.Location = new Point(449, 182);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(168, 77);
            GroupBox2.TabIndex = 53;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Urgency";
            // 
            // cb_Fix
            // 
            cb_Fix.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Fix.FormattingEnabled = true;
            cb_Fix.Location = new Point(68, 49);
            cb_Fix.Name = "cb_Fix";
            cb_Fix.Size = new Size(94, 21);
            cb_Fix.TabIndex = 2;
            // 
            // rb_Fix
            // 
            rb_Fix.AutoSize = true;
            rb_Fix.Location = new Point(7, 51);
            rb_Fix.Name = "rb_Fix";
            rb_Fix.Size = new Size(41, 17);
            rb_Fix.TabIndex = 1;
            rb_Fix.TabStop = true;
            rb_Fix.Text = "Fix:";
            rb_Fix.UseVisualStyleBackColor = true;
            // 
            // rb_Critical
            // 
            rb_Critical.AutoSize = true;
            rb_Critical.Location = new Point(7, 23);
            rb_Critical.Name = "rb_Critical";
            rb_Critical.Size = new Size(56, 17);
            rb_Critical.TabIndex = 0;
            rb_Critical.TabStop = true;
            rb_Critical.Text = "Critical";
            rb_Critical.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Gray;
            Label1.Location = new Point(607, 329);
            Label1.Name = "Label1";
            Label1.Size = new Size(24, 12);
            Label1.TabIndex = 54;
            Label1.Text = "v1.5";
            // 
            // Metro
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 341);
            ControlBox = false;
            Controls.Add(Label1);
            Controls.Add(GroupBox2);
            Controls.Add(Label3);
            Controls.Add(lbl_Progress);
            Controls.Add(btn_Cancel);
            Controls.Add(lbl_Date);
            Controls.Add(MetroLabel3);
            Controls.Add(lbl_User);
            Controls.Add(PictureBox1);
            Controls.Add(GroupBox1);
            Controls.Add(btn_Submit);
            Controls.Add(MetroLabel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Metro";
            Resizable = false;
            ShowIcon = false;
            Theme = MetroFramework.MetroThemeStyle.Dark;
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal MetroFramework.Controls.MetroLabel MetroLabel1;
        internal MetroFramework.Controls.MetroButton btn_Submit;
        internal GroupBox GroupBox1;
        internal PictureBox PictureBox1;
        internal MetroFramework.Controls.MetroLabel lbl_User;
        internal MetroFramework.Controls.MetroLabel MetroLabel3;
        internal MetroFramework.Controls.MetroLabel lbl_Date;
        internal MetroFramework.Controls.MetroButton btn_Cancel;
        internal TextBox txtbx_Problem;
        internal MetroFramework.Controls.MetroLabel lbl_Progress;
        internal Label Label3;
        internal Timer Timer1;
        internal GroupBox GroupBox2;
        internal ComboBox cb_Fix;
        internal RadioButton rb_Fix;
        internal RadioButton rb_Critical;
        internal Label Label1;
    }
}