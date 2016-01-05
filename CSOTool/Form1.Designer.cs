namespace CSOTool
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInfo1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbChar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInfo2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInfo3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInfo4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1?";
            // 
            // txtInfo1
            // 
            this.txtInfo1.Location = new System.Drawing.Point(127, 69);
            this.txtInfo1.Name = "txtInfo1";
            this.txtInfo1.Size = new System.Drawing.Size(121, 20);
            this.txtInfo1.TabIndex = 1;
            this.txtInfo1.TextChanged += new System.EventHandler(this.txtInfo1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(268, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // cbChar
            // 
            this.cbChar.FormattingEnabled = true;
            this.cbChar.Location = new System.Drawing.Point(127, 31);
            this.cbChar.Name = "cbChar";
            this.cbChar.Size = new System.Drawing.Size(121, 21);
            this.cbChar.TabIndex = 3;
            this.cbChar.SelectedIndexChanged += new System.EventHandler(this.cbChar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Character/Costume";
            // 
            // txtInfo2
            // 
            this.txtInfo2.Location = new System.Drawing.Point(127, 95);
            this.txtInfo2.Name = "txtInfo2";
            this.txtInfo2.Size = new System.Drawing.Size(121, 20);
            this.txtInfo2.TabIndex = 6;
            this.txtInfo2.TextChanged += new System.EventHandler(this.txtInfo2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vox File";
            // 
            // txtInfo3
            // 
            this.txtInfo3.Location = new System.Drawing.Point(127, 121);
            this.txtInfo3.Name = "txtInfo3";
            this.txtInfo3.Size = new System.Drawing.Size(121, 20);
            this.txtInfo3.TabIndex = 8;
            this.txtInfo3.TextChanged += new System.EventHandler(this.txtInfo3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "3?";
            // 
            // txtInfo4
            // 
            this.txtInfo4.Location = new System.Drawing.Point(127, 147);
            this.txtInfo4.Name = "txtInfo4";
            this.txtInfo4.Size = new System.Drawing.Size(121, 20);
            this.txtInfo4.TabIndex = 10;
            this.txtInfo4.TextChanged += new System.EventHandler(this.txtInfo4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "4?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 188);
            this.Controls.Add(this.txtInfo4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInfo3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInfo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbChar);
            this.Controls.Add(this.txtInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CSO Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInfo1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbChar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInfo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInfo3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInfo4;
        private System.Windows.Forms.Label label5;
    }
}

