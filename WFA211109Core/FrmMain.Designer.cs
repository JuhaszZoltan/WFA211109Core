namespace WFA211109Core
{
    partial class FrmMain
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
            this.lblHelloCore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHelloCore
            // 
            this.lblHelloCore.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHelloCore.Location = new System.Drawing.Point(12, 9);
            this.lblHelloCore.Name = "lblHelloCore";
            this.lblHelloCore.Size = new System.Drawing.Size(260, 143);
            this.lblHelloCore.TabIndex = 0;
            this.lblHelloCore.Text = "Hello .NET 6!";
            this.lblHelloCore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHelloCore.Click += new System.EventHandler(this.LblHelloCore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblHelloCore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblHelloCore;
    }
}