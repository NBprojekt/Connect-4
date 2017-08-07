namespace Connect4
{
    partial class Tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorial));
            this.cmdRechts = new System.Windows.Forms.Button();
            this.cmdLinks = new System.Windows.Forms.Button();
            this.picAusgabe = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labHinweis = new System.Windows.Forms.Label();
            this.labUnterueberschrift = new System.Windows.Forms.Label();
            this.labUeberschrift = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAusgabe)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdRechts
            // 
            this.cmdRechts.Location = new System.Drawing.Point(503, 210);
            this.cmdRechts.Name = "cmdRechts";
            this.cmdRechts.Size = new System.Drawing.Size(75, 23);
            this.cmdRechts.TabIndex = 16;
            this.cmdRechts.Text = "--->";
            this.cmdRechts.UseVisualStyleBackColor = true;
            this.cmdRechts.Click += new System.EventHandler(this.cmdRechts_Click);
            // 
            // cmdLinks
            // 
            this.cmdLinks.Location = new System.Drawing.Point(293, 210);
            this.cmdLinks.Name = "cmdLinks";
            this.cmdLinks.Size = new System.Drawing.Size(75, 23);
            this.cmdLinks.TabIndex = 15;
            this.cmdLinks.Text = "<---";
            this.cmdLinks.UseVisualStyleBackColor = true;
            this.cmdLinks.Click += new System.EventHandler(this.cmdLinks_Click);
            // 
            // picAusgabe
            // 
            this.picAusgabe.BackColor = System.Drawing.Color.Transparent;
            this.picAusgabe.BackgroundImage = global::Connect4.Properties.Resources.Beispiel1;
            this.picAusgabe.Location = new System.Drawing.Point(334, 60);
            this.picAusgabe.Name = "picAusgabe";
            this.picAusgabe.Size = new System.Drawing.Size(180, 144);
            this.picAusgabe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAusgabe.TabIndex = 14;
            this.picAusgabe.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(24, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 100);
            this.label2.TabIndex = 13;
            this.label2.Text = "Connect 4 in a row to win\r\npossible connects:\r\n - diagonal\r\n - horizontal\r\n - ver" +
    "tikal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(24, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Rules :";
            // 
            // labHinweis
            // 
            this.labHinweis.AutoSize = true;
            this.labHinweis.BackColor = System.Drawing.Color.Transparent;
            this.labHinweis.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHinweis.ForeColor = System.Drawing.Color.White;
            this.labHinweis.Location = new System.Drawing.Point(289, 27);
            this.labHinweis.Name = "labHinweis";
            this.labHinweis.Size = new System.Drawing.Size(282, 20);
            this.labHinweis.TabIndex = 11;
            this.labHinweis.Text = "( Examples for winning of the red side )";
            // 
            // labUnterueberschrift
            // 
            this.labUnterueberschrift.AutoSize = true;
            this.labUnterueberschrift.BackColor = System.Drawing.Color.Transparent;
            this.labUnterueberschrift.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUnterueberschrift.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labUnterueberschrift.Location = new System.Drawing.Point(24, 32);
            this.labUnterueberschrift.Name = "labUnterueberschrift";
            this.labUnterueberschrift.Size = new System.Drawing.Size(116, 20);
            this.labUnterueberschrift.TabIndex = 10;
            this.labUnterueberschrift.Text = "( jut for fools )";
            // 
            // labUeberschrift
            // 
            this.labUeberschrift.AutoSize = true;
            this.labUeberschrift.BackColor = System.Drawing.Color.Transparent;
            this.labUeberschrift.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUeberschrift.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labUeberschrift.Location = new System.Drawing.Point(23, 12);
            this.labUeberschrift.Name = "labUeberschrift";
            this.labUeberschrift.Size = new System.Drawing.Size(150, 23);
            this.labUeberschrift.TabIndex = 9;
            this.labUeberschrift.Text = "Connect 4 totorial";
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Connect4.Properties.Resources.bg_totourial;
            this.ClientSize = new System.Drawing.Size(600, 244);
            this.Controls.Add(this.cmdRechts);
            this.Controls.Add(this.cmdLinks);
            this.Controls.Add(this.picAusgabe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labHinweis);
            this.Controls.Add(this.labUnterueberschrift);
            this.Controls.Add(this.labUeberschrift);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutorial for fools";
            ((System.ComponentModel.ISupportInitialize)(this.picAusgabe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRechts;
        private System.Windows.Forms.Button cmdLinks;
        private System.Windows.Forms.PictureBox picAusgabe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labHinweis;
        private System.Windows.Forms.Label labUnterueberschrift;
        private System.Windows.Forms.Label labUeberschrift;
    }
}