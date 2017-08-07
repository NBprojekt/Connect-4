/*   Connect 4 is a PC version of the board game 'Connect four'
 *
 *   Copyright (C) 2017 Norbert Bartko
 *
 *   This program is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation, either version 3 of the License, or
 *   (at your option) any later version.
 *
 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

﻿namespace Connect4
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.cmdNewGame = new System.Windows.Forms.Button();
            this.labUeberschrift = new System.Windows.Forms.Label();
            this.labSpieler1 = new System.Windows.Forms.Label();
            this.labSpieler2 = new System.Windows.Forms.Label();
            this.txtSpieler1 = new System.Windows.Forms.TextBox();
            this.txtSpieler2 = new System.Windows.Forms.TextBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.labWarnung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdNewGame
            // 
            this.cmdNewGame.BackColor = System.Drawing.Color.Transparent;
            this.cmdNewGame.BackgroundImage = global::Connect4.Properties.Resources.schoner;
            this.cmdNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNewGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdNewGame.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNewGame.Location = new System.Drawing.Point(0, 0);
            this.cmdNewGame.Name = "cmdNewGame";
            this.cmdNewGame.Size = new System.Drawing.Size(479, 269);
            this.cmdNewGame.TabIndex = 0;
            this.cmdNewGame.Text = "New Game";
            this.cmdNewGame.UseVisualStyleBackColor = false;
            this.cmdNewGame.Click += new System.EventHandler(this.cmdNewGame_Click);
            // 
            // labUeberschrift
            // 
            this.labUeberschrift.AutoSize = true;
            this.labUeberschrift.BackColor = System.Drawing.Color.Transparent;
            this.labUeberschrift.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUeberschrift.ForeColor = System.Drawing.Color.Gainsboro;
            this.labUeberschrift.Location = new System.Drawing.Point(12, 35);
            this.labUeberschrift.Name = "labUeberschrift";
            this.labUeberschrift.Size = new System.Drawing.Size(458, 27);
            this.labUeberschrift.TabIndex = 1;
            this.labUeberschrift.Text = "Please enter the names and you\'re ready to go!";
            this.labUeberschrift.Visible = false;
            // 
            // labSpieler1
            // 
            this.labSpieler1.AutoSize = true;
            this.labSpieler1.BackColor = System.Drawing.Color.Transparent;
            this.labSpieler1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSpieler1.ForeColor = System.Drawing.Color.Gainsboro;
            this.labSpieler1.Location = new System.Drawing.Point(65, 102);
            this.labSpieler1.Name = "labSpieler1";
            this.labSpieler1.Size = new System.Drawing.Size(75, 23);
            this.labSpieler1.TabIndex = 2;
            this.labSpieler1.Text = "Player 1";
            this.labSpieler1.Visible = false;
            // 
            // labSpieler2
            // 
            this.labSpieler2.AutoSize = true;
            this.labSpieler2.BackColor = System.Drawing.Color.Transparent;
            this.labSpieler2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSpieler2.ForeColor = System.Drawing.Color.Gainsboro;
            this.labSpieler2.Location = new System.Drawing.Point(65, 144);
            this.labSpieler2.Name = "labSpieler2";
            this.labSpieler2.Size = new System.Drawing.Size(82, 23);
            this.labSpieler2.TabIndex = 3;
            this.labSpieler2.Text = "Player 2 ";
            this.labSpieler2.Visible = false;
            // 
            // txtSpieler1
            // 
            this.txtSpieler1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.txtSpieler1.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtSpieler1.Location = new System.Drawing.Point(154, 102);
            this.txtSpieler1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSpieler1.Name = "txtSpieler1";
            this.txtSpieler1.Size = new System.Drawing.Size(257, 24);
            this.txtSpieler1.TabIndex = 5;
            this.txtSpieler1.Visible = false;
            // 
            // txtSpieler2
            // 
            this.txtSpieler2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.txtSpieler2.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtSpieler2.Location = new System.Drawing.Point(154, 144);
            this.txtSpieler2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSpieler2.Name = "txtSpieler2";
            this.txtSpieler2.Size = new System.Drawing.Size(257, 24);
            this.txtSpieler2.TabIndex = 6;
            this.txtSpieler2.Visible = false;
            // 
            // cmdStart
            // 
            this.cmdStart.BackColor = System.Drawing.Color.Transparent;
            this.cmdStart.BackgroundImage = global::Connect4.Properties.Resources.go;
            this.cmdStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.cmdStart.Location = new System.Drawing.Point(201, 174);
            this.cmdStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(81, 69);
            this.cmdStart.TabIndex = 7;
            this.cmdStart.UseVisualStyleBackColor = false;
            this.cmdStart.Visible = false;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // labWarnung
            // 
            this.labWarnung.AutoSize = true;
            this.labWarnung.BackColor = System.Drawing.Color.Transparent;
            this.labWarnung.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWarnung.ForeColor = System.Drawing.Color.White;
            this.labWarnung.Location = new System.Drawing.Point(150, 62);
            this.labWarnung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labWarnung.Name = "labWarnung";
            this.labWarnung.Size = new System.Drawing.Size(185, 19);
            this.labWarnung.TabIndex = 8;
            this.labWarnung.Text = "################";
            this.labWarnung.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Connect4.Properties.Resources.schoner;
            this.ClientSize = new System.Drawing.Size(479, 269);
            this.Controls.Add(this.labWarnung);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.txtSpieler2);
            this.Controls.Add(this.txtSpieler1);
            this.Controls.Add(this.labSpieler2);
            this.Controls.Add(this.labSpieler1);
            this.Controls.Add(this.labUeberschrift);
            this.Controls.Add(this.cmdNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdNewGame;
        private System.Windows.Forms.Label labUeberschrift;
        private System.Windows.Forms.Label labSpieler1;
        private System.Windows.Forms.Label labSpieler2;
        private System.Windows.Forms.TextBox txtSpieler1;
        private System.Windows.Forms.TextBox txtSpieler2;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label labWarnung;
    }
}
