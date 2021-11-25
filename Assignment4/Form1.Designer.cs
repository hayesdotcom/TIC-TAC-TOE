
namespace Assignment4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.B1 = new System.Windows.Forms.Button();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.U1 = new System.Windows.Forms.Button();
            this.T1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.U2 = new System.Windows.Forms.Button();
            this.T2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.U3 = new System.Windows.Forms.Button();
            this.T3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(191, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hToolStripMenuItem.Text = "Help";
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B1.Cursor = System.Windows.Forms.Cursors.No;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.B1.Location = new System.Drawing.Point(14, 27);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(50, 50);
            this.B1.TabIndex = 1;
            this.B1.Text = "  ";
            this.B1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "Instructions";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // U1
            // 
            this.U1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.U1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.U1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.U1.Location = new System.Drawing.Point(14, 83);
            this.U1.Name = "U1";
            this.U1.Size = new System.Drawing.Size(50, 50);
            this.U1.TabIndex = 2;
            this.U1.Text = "  ";
            this.U1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.U1.UseVisualStyleBackColor = false;
            this.U1.Click += new System.EventHandler(this.button_click);
            // 
            // T1
            // 
            this.T1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.T1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.T1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.T1.Location = new System.Drawing.Point(14, 139);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(50, 50);
            this.T1.TabIndex = 3;
            this.T1.Text = " ";
            this.T1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.T1.UseVisualStyleBackColor = false;
            this.T1.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.B2.Location = new System.Drawing.Point(70, 27);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(50, 50);
            this.B2.TabIndex = 4;
            this.B2.Text = "  ";
            this.B2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // U2
            // 
            this.U2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.U2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.U2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.U2.Location = new System.Drawing.Point(70, 83);
            this.U2.Name = "U2";
            this.U2.Size = new System.Drawing.Size(50, 50);
            this.U2.TabIndex = 5;
            this.U2.Text = "  ";
            this.U2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.U2.UseVisualStyleBackColor = false;
            this.U2.Click += new System.EventHandler(this.button_click);
            // 
            // T2
            // 
            this.T2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.T2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.T2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.T2.Location = new System.Drawing.Point(70, 139);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(50, 50);
            this.T2.TabIndex = 6;
            this.T2.Text = " ";
            this.T2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.T2.UseVisualStyleBackColor = false;
            this.T2.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.B3.Location = new System.Drawing.Point(126, 27);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(50, 50);
            this.B3.TabIndex = 7;
            this.B3.Text = "  ";
            this.B3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // U3
            // 
            this.U3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.U3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.U3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.U3.Location = new System.Drawing.Point(126, 83);
            this.U3.Name = "U3";
            this.U3.Size = new System.Drawing.Size(50, 50);
            this.U3.TabIndex = 8;
            this.U3.Text = "  ";
            this.U3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.U3.UseVisualStyleBackColor = false;
            this.U3.Click += new System.EventHandler(this.button_click);
            // 
            // T3
            // 
            this.T3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.T3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.T3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.T3.Location = new System.Drawing.Point(126, 139);
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(50, 50);
            this.T3.TabIndex = 9;
            this.T3.Text = " ";
            this.T3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.T3.UseVisualStyleBackColor = false;
            this.T3.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 204);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.T3);
            this.Controls.Add(this.U3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.U2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.U1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button U1;
        private System.Windows.Forms.Button T1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button U2;
        private System.Windows.Forms.Button T2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button U3;
        private System.Windows.Forms.Button T3;
    }
}

