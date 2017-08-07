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
    public partial class Game : Form
    {
        // Globales Array
        int[,] intArray;
        // Aktueller Spieler
        int aktuellerSpieler = 1;
        // Gewinner es matches ist 
        Boolean allesschliesen = true;
        string win = "Here ist just place for one WINNER"; 

        public Game() { 
                // Form Inizalisieren
            InitializeComponent();
        }

        // Beim laden die Werte auslesen
        private void Game_Load(object sender, EventArgs e)
        { 
            labSpieler1.Text = Login.Spieler1;  // Spieler 1 namen ausgeben
            labSpieler2.Text = Login.Spieler2;  // Spieler 2 namen ausgeben
            labSpielerAnderRheie.Text = "It's " + Login.Spieler1 + "'s turn!";  // Wer is denn dran ?

            // Array Deklarieren
            intArray = new int[6, 7];
            // Array Werte zuweisen
            for (int i = 0; i < intArray.GetLength(0); i++)
            {           // Zeilen   
                for (int j = 0; j < intArray.GetLength(1); j++)
                {       // Spalten
                    intArray[i, j] = 0;     // Das Ganze array mit 0 füllen
                }
            }
        } 

        private void cmdZeiger0_Click(object sender, EventArgs e) { Zug(0); }
        private void cmdZeiger1_Click(object sender, EventArgs e) { Zug(1); }
        private void cmdZeiger2_Click(object sender, EventArgs e) { Zug(2); }
        private void cmdZeiger3_Click(object sender, EventArgs e) { Zug(3); }
        private void cmdZeiger4_Click(object sender, EventArgs e) { Zug(4); }
        private void cmdZeiger5_Click(object sender, EventArgs e) { Zug(5); }
        private void cmdZeiger6_Click(object sender, EventArgs e) { Zug(6); }

        private void Zug(int spalte)
        {
            // array rückwärts zählen   
            for (int i = intArray.GetLength(0) - 1; i >= 0; i--)
            {
                // wenn ein feld unbelegt ist 
                if (intArray[i, spalte] == 0)
                {
                    intArray[i, spalte] = aktuellerSpieler; // Nummer des Spielers eintragen
                    BilderLaden();      // Grafig neu laden

                    // Gewinner berechnen
                    if (Gewinner())
                    {
                        // Aktueller Spieler unsichtbar machen
                        labSpielerAktuell.Visible = false;
                        labSpielerAnderRheie.Visible = false;
                        // Spieler farbe unsichtbar
                        picAktuell.Visible = false;
                        // Ausgabe des Gewinners 
                        labWin.Text = "AND THE WINNER IS: \r\n" + win;           // Win Label
                        // Alle Zeiger Sperren
                        cmdZeiger0.Enabled = false;
                        cmdZeiger1.Enabled = false;
                        cmdZeiger2.Enabled = false;
                        cmdZeiger3.Enabled = false;
                        cmdZeiger4.Enabled = false;
                        cmdZeiger5.Enabled = false;
                        cmdZeiger6.Enabled = false;
                        // Nochmal Button aktivieren
                        cmdReset.Visible = true;
                    }
                    // wenn es keinen gewinner gibt geht es weiter
                    else
                    {
                        Spielerwechel();    // Spieler Wechels
                        Untentschieden();   // Prüfen ob es ein untwentschieden gibt
                    }
                    return;
                }
            }

        }

        // Methode zum Spieler wechsel
        private void Spielerwechel()
        {
            // Durchwechseln der Spieler
            if (aktuellerSpieler == 1)
            {
                aktuellerSpieler = 2;   // Spieler 2
                labSpielerAnderRheie.Text = "It's " + Login.Spieler2 + "'s  turn!";  // Namen ändern
                picAktuell.Image = Connect4.Properties.Resources.yellow_;   // Gelber Stein
            }
            else
            {
                aktuellerSpieler = 1;   // Spieler 1
                labSpielerAnderRheie.Text = "It's " + Login.Spieler1 + "'s turn!";  // Namen ändern
                picAktuell.Image = Connect4.Properties.Resources.red_;      // Roter Stein
            }
        }

        // Methode für das unwentschieden
        private void Untentschieden()
        {
            Boolean trottel = true;    // Zum prüfen ob es zwei trottel sind
                                       // Das Array durchgehen ob alle Felder belegt wurden
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (intArray[i, j] == 0) trottel = false;   // wenn es eine leeres Feld gibt
                }
            }

            // ES GIBT WIRKLICH 2 TROTTEL
            if (trottel)
            {
                // Aktueller Spieler unsichtbar machen
                labSpielerAktuell.Visible = false;
                labSpielerAnderRheie.Visible = false;
                // Spieler farbe unsichtbar
                picAktuell.Visible = false;
                // Ausgabe des Gewinners 
                labWin.Text = "No one has won \r\nGG";           // Win Label
                // Alle Zeiger Sperren
                cmdZeiger0.Enabled = false;
                cmdZeiger1.Enabled = false;
                cmdZeiger2.Enabled = false;
                cmdZeiger3.Enabled = false;
                cmdZeiger4.Enabled = false;
                cmdZeiger5.Enabled = false;
                cmdZeiger6.Enabled = false;
                // Nochmal Button aktivieren
                cmdReset.Visible = true;
            }
        }

        // Gewinner gerechnen
        private Boolean Gewinner()
        {   // Boolean ob jemand gewonnen hat
            int x = 1; // Spieler nummer 
            // berechnung für beide spieler 
            do
            {
                // Diagonal
                // Rechts oben nach Links unten
                if (intArray[3, 0] == x && intArray[2, 1] == x && intArray[1, 2] == x && intArray[0, 3] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[4, 0] == x && intArray[3, 1] == x && intArray[2, 2] == x && intArray[1, 3] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[3, 1] == x && intArray[2, 2] == x && intArray[1, 3] == x && intArray[0, 4] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[5, 0] == x && intArray[4, 1] == x && intArray[3, 2] == x && intArray[2, 3] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[4, 1] == x && intArray[3, 2] == x && intArray[2, 3] == x && intArray[1, 4] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[3, 2] == x && intArray[2, 3] == x && intArray[1, 4] == x && intArray[0, 5] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[5, 1] == x && intArray[4, 2] == x && intArray[3, 3] == x && intArray[2, 4] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[4, 2] == x && intArray[3, 3] == x && intArray[2, 4] == x && intArray[1, 5] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[3, 3] == x && intArray[2, 4] == x && intArray[1, 5] == x && intArray[0, 6] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[2, 5] == x && intArray[3, 4] == x && intArray[4, 3] == x && intArray[5, 2] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[4, 3] == x && intArray[3, 4] == x && intArray[2, 5] == x && intArray[1, 6] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[5, 3] == x && intArray[4, 4] == x && intArray[3, 5] == x && intArray[2, 6] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }


                // Diagonal
                // Links oben nach Rechts unten
                if (intArray[0, 3] == x && intArray[1, 4] == x && intArray[2, 5] == x && intArray[3, 6] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[0, 2] == x && intArray[1, 3] == x && intArray[2, 4] == x && intArray[3, 5] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[1, 3] == x && intArray[2, 4] == x && intArray[3, 5] == x && intArray[4, 6] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[0, 1] == x && intArray[1, 2] == x && intArray[2, 3] == x && intArray[3, 4] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[1, 2] == x && intArray[2, 3] == x && intArray[3, 4] == x && intArray[4, 5] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[2, 3] == x && intArray[3, 4] == x && intArray[4, 5] == x && intArray[5, 6] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[0, 0] == x && intArray[1, 1] == x && intArray[2, 2] == x && intArray[3, 3] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[1, 1] == x && intArray[2, 2] == x && intArray[3, 3] == x && intArray[4, 4] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[2, 2] == x && intArray[3, 3] == x && intArray[4, 4] == x && intArray[5, 5] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[1, 0] == x && intArray[2, 1] == x && intArray[3, 2] == x && intArray[4, 3] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[2, 1] == x && intArray[3, 2] == x && intArray[4, 3] == x && intArray[5, 4] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }
                if (intArray[2, 0] == x && intArray[3, 1] == x && intArray[4, 2] == x && intArray[5, 3] == x)
                {
                    if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                    else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                    return true;    // Jemand hat gewonnen zurückgeben
                }


                // ZEILEN
                for (int i = 0; i < intArray.GetLength(0); i++)
                { // Überprüfen der Zeilen
                    if (intArray[i, 0] == x && intArray[i, 1] == x && intArray[i, 2] == x && intArray[i, 3] == x)
                    {
                        if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                        else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                        return true;    // Jemand hat gewonnen zurückgeben
                    }
                    if (intArray[i, 1] == x && intArray[i, 2] == x && intArray[i, 3] == x && intArray[i, 4] == x)
                    {
                        if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                        else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                        return true;    // Jemand hat gewonnen zurückgeben
                    }
                    if (intArray[i, 2] == x && intArray[i, 3] == x && intArray[i, 4] == x && intArray[i, 5] == x)
                    {
                        if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                        else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                        return true;    // Jemand hat gewonnen zurückgeben
                    }
                    if (intArray[i, 3] == x && intArray[i, 4] == x && intArray[i, 5] == x && intArray[i, 6] == x)
                    {
                        if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                        else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                        return true;    // Jemand hat gewonnen zurückgeben
                    }
                }

                // SPALTEN
                for (int i = 0; i < intArray.GetLength(1); i++)
                { // Überprüfen der Zeilen
                    if (intArray[0, i] == x && intArray[1, i] == x && intArray[2, i] == x && intArray[3, i] == x)
                    {
                        if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                        else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                        return true;    // Jemand hat gewonnen zurückgeben
                    }
                    if (intArray[1, i] == x && intArray[2, i] == x && intArray[3, i] == x && intArray[4, i] == x)
                    {
                        if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                        else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                        return true;    // Jemand hat gewonnen zurückgeben
                    }
                    if (intArray[2, i] == x && intArray[3, i] == x && intArray[4, i] == x && intArray[5, i] == x)
                    {
                        if (x == 1) win = Convert.ToString(Login.Spieler1);    // Spieler 1 hat gewonnen
                        else win = Convert.ToString(Login.Spieler2);           // Spieler 2 hat gewonnen
                        return true;    // Jemand hat gewonnen zurückgeben
                    }
                }
                x++;    // Spieler hochzahlen
            } while (x < 3);    // Beenden wenn alle spieler dran waren
            // Wenn return false  hat keiner gewonnen
            return false;
        }
        // Methode für die Grafische Ausgabe
        private void BilderLaden()
        {
            /*  #####################
             *  #   Für Spieler 1   #
             *  #  Rot Steine und   # 
             *  #  und Array wert 1 #
             *  * #####################
             */
            // Zeile 0
            if (intArray[0, 0] == 1) picBox0_0.Image = Connect4.Properties.Resources.red_;
            if (intArray[0, 1] == 1) picBox0_1.Image = Connect4.Properties.Resources.red_;
            if (intArray[0, 2] == 1) picBox0_2.Image = Connect4.Properties.Resources.red_;
            if (intArray[0, 3] == 1) picBox0_3.Image = Connect4.Properties.Resources.red_;
            if (intArray[0, 4] == 1) picBox0_4.Image = Connect4.Properties.Resources.red_;
            if (intArray[0, 5] == 1) picBox0_5.Image = Connect4.Properties.Resources.red_;
            if (intArray[0, 6] == 1) picBox0_6.Image = Connect4.Properties.Resources.red_;
            // Zeile 1
            if (intArray[1, 0] == 1) picBox1_0.Image = Connect4.Properties.Resources.red_;
            if (intArray[1, 1] == 1) picBox1_1.Image = Connect4.Properties.Resources.red_;
            if (intArray[1, 2] == 1) picBox1_2.Image = Connect4.Properties.Resources.red_;
            if (intArray[1, 3] == 1) picBox1_3.Image = Connect4.Properties.Resources.red_;
            if (intArray[1, 4] == 1) picBox1_4.Image = Connect4.Properties.Resources.red_;
            if (intArray[1, 5] == 1) picBox1_5.Image = Connect4.Properties.Resources.red_;
            if (intArray[1, 6] == 1) picBox1_6.Image = Connect4.Properties.Resources.red_;
            // Zeile 2
            if (intArray[2, 0] == 1) picBox2_0.Image = Connect4.Properties.Resources.red_;
            if (intArray[2, 1] == 1) picBox2_1.Image = Connect4.Properties.Resources.red_;
            if (intArray[2, 2] == 1) picBox2_2.Image = Connect4.Properties.Resources.red_;
            if (intArray[2, 3] == 1) picBox2_3.Image = Connect4.Properties.Resources.red_;
            if (intArray[2, 4] == 1) picBox2_4.Image = Connect4.Properties.Resources.red_;
            if (intArray[2, 5] == 1) picBox2_5.Image = Connect4.Properties.Resources.red_;
            if (intArray[2, 6] == 1) picBox2_6.Image = Connect4.Properties.Resources.red_;
            // Zeile 3
            if (intArray[3, 0] == 1) picBox3_0.Image = Connect4.Properties.Resources.red_;
            if (intArray[3, 1] == 1) picBox3_1.Image = Connect4.Properties.Resources.red_;
            if (intArray[3, 2] == 1) picBox3_2.Image = Connect4.Properties.Resources.red_;
            if (intArray[3, 3] == 1) picBox3_3.Image = Connect4.Properties.Resources.red_;
            if (intArray[3, 4] == 1) picBox3_4.Image = Connect4.Properties.Resources.red_;
            if (intArray[3, 5] == 1) picBox3_5.Image = Connect4.Properties.Resources.red_;
            if (intArray[3, 6] == 1) picBox3_6.Image = Connect4.Properties.Resources.red_;
            // Zeile 4
            if (intArray[4, 0] == 1) picBox4_0.Image = Connect4.Properties.Resources.red_;
            if (intArray[4, 1] == 1) picBox4_1.Image = Connect4.Properties.Resources.red_;
            if (intArray[4, 2] == 1) picBox4_2.Image = Connect4.Properties.Resources.red_;
            if (intArray[4, 3] == 1) picBox4_3.Image = Connect4.Properties.Resources.red_;
            if (intArray[4, 4] == 1) picBox4_4.Image = Connect4.Properties.Resources.red_;
            if (intArray[4, 5] == 1) picBox4_5.Image = Connect4.Properties.Resources.red_;
            if (intArray[4, 6] == 1) picBox4_6.Image = Connect4.Properties.Resources.red_;
            // Zeile 5
            if (intArray[5, 0] == 1) picBox5_0.Image = Connect4.Properties.Resources.red_;
            if (intArray[5, 1] == 1) picBox5_1.Image = Connect4.Properties.Resources.red_;
            if (intArray[5, 2] == 1) picBox5_2.Image = Connect4.Properties.Resources.red_;
            if (intArray[5, 3] == 1) picBox5_3.Image = Connect4.Properties.Resources.red_;
            if (intArray[5, 4] == 1) picBox5_4.Image = Connect4.Properties.Resources.red_;
            if (intArray[5, 5] == 1) picBox5_5.Image = Connect4.Properties.Resources.red_;
            if (intArray[5, 6] == 1) picBox5_6.Image = Connect4.Properties.Resources.red_;


            /*  #####################
            *  #   Für Spieler 2   #
            *  #  Rot Steine und   # 
            *  #  und Array wert 2 #
            *  * #####################
            */
            // Zeile 0
            if (intArray[0, 0] == 2) picBox0_0.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[0, 1] == 2) picBox0_1.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[0, 2] == 2) picBox0_2.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[0, 3] == 2) picBox0_3.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[0, 4] == 2) picBox0_4.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[0, 5] == 2) picBox0_5.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[0, 6] == 2) picBox0_6.Image = Connect4.Properties.Resources.yellow_;
            // Zeile 1
            if (intArray[1, 0] == 2) picBox1_0.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[1, 1] == 2) picBox1_1.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[1, 2] == 2) picBox1_2.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[1, 3] == 2) picBox1_3.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[1, 4] == 2) picBox1_4.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[1, 5] == 2) picBox1_5.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[1, 6] == 2) picBox1_6.Image = Connect4.Properties.Resources.yellow_;
            // Zeile 2
            if (intArray[2, 0] == 2) picBox2_0.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[2, 1] == 2) picBox2_1.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[2, 2] == 2) picBox2_2.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[2, 3] == 2) picBox2_3.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[2, 4] == 2) picBox2_4.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[2, 5] == 2) picBox2_5.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[2, 6] == 2) picBox2_6.Image = Connect4.Properties.Resources.yellow_;
            // Zeile 3
            if (intArray[3, 0] == 2) picBox3_0.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[3, 1] == 2) picBox3_1.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[3, 2] == 2) picBox3_2.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[3, 3] == 2) picBox3_3.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[3, 4] == 2) picBox3_4.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[3, 5] == 2) picBox3_5.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[3, 6] == 2) picBox3_6.Image = Connect4.Properties.Resources.yellow_;
            // Zeile 4
            if (intArray[4, 0] == 2) picBox4_0.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[4, 1] == 2) picBox4_1.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[4, 2] == 2) picBox4_2.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[4, 3] == 2) picBox4_3.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[4, 4] == 2) picBox4_4.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[4, 5] == 2) picBox4_5.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[4, 6] == 2) picBox4_6.Image = Connect4.Properties.Resources.yellow_;
            // Zeile 5
            if (intArray[5, 0] == 2) picBox5_0.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[5, 1] == 2) picBox5_1.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[5, 2] == 2) picBox5_2.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[5, 3] == 2) picBox5_3.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[5, 4] == 2) picBox5_4.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[5, 5] == 2) picBox5_5.Image = Connect4.Properties.Resources.yellow_;
            if (intArray[5, 6] == 2) picBox5_6.Image = Connect4.Properties.Resources.yellow_;

        }
        // Das Spiel erneut Starten
        private void cmdReset_Click_1(object sender, EventArgs e)
        {
            allesschliesen = false;
            Close();
            Login formS = new Login();   // Login Deklariren
            formS.Show();    // Start form neu aufrufen
        }
        // Das Totorial Starten
        private void cmdTotorial_Click(object sender, EventArgs e)
        {
            Tutorial formT = new Tutorial();   // Totorial Form Deklariren
            formT.Show();   //  Starten
        }
        // Form1 Schliessen
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Alle formulare Schließen
            if (allesschliesen)
            {
                Tutorial formT = new Tutorial();   // Totorial Form Deklariren
                formT.Close();   // Totorial Form schließen
                Login formS = new Login();   // Login Deklariren
                formS.Close();   // Start Form schließen
                Application.Exit();
            }
            // auser der "Neues Spiel" knopf wurde gedrückt
            else { } // Do nothing 
        }


    }
}
