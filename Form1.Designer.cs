namespace Customers_accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstDeck = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtBetAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHi = new System.Windows.Forms.Button();
            this.btnLow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDeck
            // 
            this.lstDeck.FormattingEnabled = true;
            this.lstDeck.Location = new System.Drawing.Point(18, 52);
            this.lstDeck.Name = "lstDeck";
            this.lstDeck.Size = new System.Drawing.Size(60, 186);
            this.lstDeck.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Deck";
            // 
            // pbx1
            // 
            this.pbx1.Image = ((System.Drawing.Image)(resources.GetObject("pbx1.Image")));
            this.pbx1.Location = new System.Drawing.Point(100, 52);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(120, 181);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 2;
            this.pbx1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(398, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(541, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 181);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // txtBetAmount
            // 
            this.txtBetAmount.Location = new System.Drawing.Point(706, 75);
            this.txtBetAmount.Name = "txtBetAmount";
            this.txtBetAmount.Size = new System.Drawing.Size(118, 20);
            this.txtBetAmount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(706, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bet Amount";
            // 
            // btnHi
            // 
            this.btnHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHi.ForeColor = System.Drawing.Color.Blue;
            this.btnHi.Location = new System.Drawing.Point(706, 110);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(118, 49);
            this.btnHi.TabIndex = 8;
            this.btnHi.Text = "Go High";
            this.btnHi.UseVisualStyleBackColor = true;
            // 
            // btnLow
            // 
            this.btnLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLow.ForeColor = System.Drawing.Color.Blue;
            this.btnLow.Location = new System.Drawing.Point(709, 184);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(115, 49);
            this.btnLow.TabIndex = 9;
            this.btnLow.Text = "Go Low";
            this.btnLow.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(856, 267);
            this.ControlBox = false;
            this.Controls.Add(this.btnLow);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBetAmount);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDeck);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "My Hi Low Card Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDeck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtBetAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Button btnLow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
    }
}

