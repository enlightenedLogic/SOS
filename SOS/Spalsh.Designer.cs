using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SOS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Splash : MetroFramework.Forms.MetroForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            PictureBox1 = new PictureBox();
            Label3 = new Label();
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImage = (Image)resources.GetObject("PictureBox1.BackgroundImage");
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.Location = new Point(38, 36);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(234, 85);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.Gray;
            Label3.Location = new Point(0, 329);
            Label3.Name = "Label3";
            Label3.Size = new Size(0, 12);
            Label3.TabIndex = 52;
            // 
            // Timer1
            // 
            Timer1.Interval = 2000;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 251);
            ControlBox = false;
            Controls.Add(Label3);
            Controls.Add(PictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Splash";
            Resizable = false;
            ShowIcon = false;
            Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(Splash_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal PictureBox PictureBox1;
        internal Label Label3;
        internal Timer Timer1;
    }
}