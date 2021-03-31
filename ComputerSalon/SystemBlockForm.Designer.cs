
namespace ComputerSalon
{
    partial class SystemBlockForm
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
            this.bCheck = new System.Windows.Forms.Button();
            this.flpComponentsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.bQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCheck
            // 
            this.bCheck.Location = new System.Drawing.Point(22, 342);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(75, 23);
            this.bCheck.TabIndex = 10;
            this.bCheck.Text = "Check!";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.CheckSystemBlock);
            // 
            // flpComponentsLayout
            // 
            this.flpComponentsLayout.Location = new System.Drawing.Point(22, 12);
            this.flpComponentsLayout.Name = "flpComponentsLayout";
            this.flpComponentsLayout.Size = new System.Drawing.Size(1148, 309);
            this.flpComponentsLayout.TabIndex = 16;
            // 
            // bQuit
            // 
            this.bQuit.Location = new System.Drawing.Point(1095, 342);
            this.bQuit.Name = "bQuit";
            this.bQuit.Size = new System.Drawing.Size(75, 23);
            this.bQuit.TabIndex = 17;
            this.bQuit.Text = "Quit";
            this.bQuit.UseVisualStyleBackColor = true;
            this.bQuit.Click += new System.EventHandler(this.Quit);
            // 
            // SystemBlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 380);
            this.Controls.Add(this.bQuit);
            this.Controls.Add(this.flpComponentsLayout);
            this.Controls.Add(this.bCheck);
            this.Name = "SystemBlockForm";
            this.Text = "Collect your own system block";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.FlowLayoutPanel flpComponentsLayout;
        private System.Windows.Forms.Button bQuit;
    }
}

