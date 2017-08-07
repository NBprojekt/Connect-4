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

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Login : Form
    {
        Game game = new Game();
        public Login() {
            InitializeComponent();
            labWarnung.Text = "";
        }
        public static string Spieler1 { get; set; }    // Name des Spieler 1
        public static string Spieler2 { get; set; }    // Name des Spieler 2

        private void cmdNewGame_Click(object sender, EventArgs e)
        {
            // Alle Felder Bis auf den StartButton Sichtbar machen
            labUeberschrift.Visible = true;
            labSpieler1.Visible = true;
            labSpieler2.Visible = true;
            labWarnung.Visible = true;
            txtSpieler2.Visible = true;
            txtSpieler1.Visible = true;
            cmdStart.Visible = true;
            // NewGamebutton Unsichtbar
            cmdNewGame.Visible = false;
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            // Prüfen ob die Felder leer sind
            if (txtSpieler2.Text == "" || txtSpieler2.Text == " " || txtSpieler1.Text == "" || txtSpieler1.Text == "")
            {
                labWarnung.Text = "Please fill in all fields!"; // Warnungs Text 
                return; // Abbruch der methode
            }
            // Prüfen ob die Namen gleichsund
            if (txtSpieler2.Text == txtSpieler1.Text)
            {
                labWarnung.Text = "Please choose two different names "; // Warnungs Text 
                return; // Abbruch der methode
            }

            // Wenn keine Fehler 
            // Spielernamen vestlegen
            Spieler1 = txtSpieler2.Text;
            Spieler2 = txtSpieler1.Text;

            // Aktuelles Form Schließen
            Hide();

            // HauptSpiel Form Aufrufen
            game.Show();
        }
    }
}
