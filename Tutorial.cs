using System;
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
