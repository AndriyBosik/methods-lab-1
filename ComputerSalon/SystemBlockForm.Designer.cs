
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bCheck = new System.Windows.Forms.Button();
            this.lbProcessors = new System.Windows.Forms.ListBox();
            this.lbMotherboards = new System.Windows.Forms.ListBox();
            this.lbMemoryCards = new System.Windows.Forms.ListBox();
            this.lbSystemBlocks = new System.Windows.Forms.ListBox();
            this.lbPowerSuppliers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Processor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Motherboard:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Memory Card:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Power Supply:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select System Block:";
            // 
            // bCheck
            // 
            this.bCheck.Location = new System.Drawing.Point(34, 347);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(75, 23);
            this.bCheck.TabIndex = 10;
            this.bCheck.Text = "Check!";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.CheckSystemBlock);
            // 
            // lbProcessors
            // 
            this.lbProcessors.FormattingEnabled = true;
            this.lbProcessors.ItemHeight = 15;
            this.lbProcessors.Location = new System.Drawing.Point(34, 49);
            this.lbProcessors.Name = "lbProcessors";
            this.lbProcessors.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbProcessors.Size = new System.Drawing.Size(231, 94);
            this.lbProcessors.TabIndex = 11;
            // 
            // lbMotherboards
            // 
            this.lbMotherboards.FormattingEnabled = true;
            this.lbMotherboards.ItemHeight = 15;
            this.lbMotherboards.Location = new System.Drawing.Point(279, 49);
            this.lbMotherboards.Name = "lbMotherboards";
            this.lbMotherboards.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbMotherboards.Size = new System.Drawing.Size(231, 94);
            this.lbMotherboards.TabIndex = 12;
            // 
            // lbMemoryCards
            // 
            this.lbMemoryCards.FormattingEnabled = true;
            this.lbMemoryCards.ItemHeight = 15;
            this.lbMemoryCards.Location = new System.Drawing.Point(527, 49);
            this.lbMemoryCards.Name = "lbMemoryCards";
            this.lbMemoryCards.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbMemoryCards.Size = new System.Drawing.Size(231, 94);
            this.lbMemoryCards.TabIndex = 13;
            // 
            // lbSystemBlocks
            // 
            this.lbSystemBlocks.FormattingEnabled = true;
            this.lbSystemBlocks.ItemHeight = 15;
            this.lbSystemBlocks.Location = new System.Drawing.Point(34, 181);
            this.lbSystemBlocks.Name = "lbSystemBlocks";
            this.lbSystemBlocks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSystemBlocks.Size = new System.Drawing.Size(231, 94);
            this.lbSystemBlocks.TabIndex = 14;
            // 
            // lbPowerSuppliers
            // 
            this.lbPowerSuppliers.FormattingEnabled = true;
            this.lbPowerSuppliers.ItemHeight = 15;
            this.lbPowerSuppliers.Location = new System.Drawing.Point(279, 181);
            this.lbPowerSuppliers.Name = "lbPowerSuppliers";
            this.lbPowerSuppliers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPowerSuppliers.Size = new System.Drawing.Size(231, 94);
            this.lbPowerSuppliers.TabIndex = 15;
            // 
            // SystemBlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 382);
            this.Controls.Add(this.lbPowerSuppliers);
            this.Controls.Add(this.lbSystemBlocks);
            this.Controls.Add(this.lbMemoryCards);
            this.Controls.Add(this.lbMotherboards);
            this.Controls.Add(this.lbProcessors);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SystemBlockForm";
            this.Text = "Collect your own system block";
            this.Load += new System.EventHandler(this.FormLoads);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.ListBox lbProcessors;
        private System.Windows.Forms.ListBox lbMotherboards;
        private System.Windows.Forms.ListBox lbMemoryCards;
        private System.Windows.Forms.ListBox lbSystemBlocks;
        private System.Windows.Forms.ListBox lbPowerSuppliers;
    }
}

