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
