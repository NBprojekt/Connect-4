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
    public partial class Tutorial : Form
    {
        public Tutorial() {
            InitializeComponent();
        }
        // Golbale Variable zum mitzählen
        int i = 1;

        // Bild nach links 
        private void cmdRechts_Click(object sender, EventArgs e) {
            i++;
            bildauswerten(i);
        }
        // Bild nach rechts
        private void cmdLinks_Click(object sender, EventArgs e) {
            i--;
            bildauswerten(i);
        }

        // Bildauswerten 
        private void bildauswerten(int var) {
            // Normale bildausgabe
            if (var == 1) picAusgabe.Image = Connect4.Properties.Resources.Beispiel1;
            if (var == 2) picAusgabe.Image = Connect4.Properties.Resources.Beispiel2;
            if (var == 3) picAusgabe.Image = Connect4.Properties.Resources.Beispiel3;
            // wenn der index überschritten wird
            if (var > 3) {
                picAusgabe.Image = Connect4.Properties.Resources.Beispiel1;
                i = 1;
            }
            if (var < 1) {
                picAusgabe.Image = Connect4.Properties.Resources.Beispiel3;
                i = 3;
            }
        }
    }
}
