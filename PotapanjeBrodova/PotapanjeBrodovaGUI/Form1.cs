using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PotapanjeBrodova;


namespace PotapanjeBrodovaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void NacrtajMrezu()
        {
            mreza = new Mreža(retci, stupci);
            if (poljaPrikaz != null)
            {
                foreach (PictureBox i in poljaPrikaz)
                {
                    Controls.Remove(i);
                }
            }
            poljaPrikaz = new PictureBox[retci, stupci];
            xPozicijaPolja = defaultX;
            yPozicijaPolja = defaultY;
            foreach (Polje i in mreza.polja)
            {
                poljaPrikaz[i.Redak, i.Stupac] = new PictureBox();
                poljaPrikaz[i.Redak, i.Stupac].Size = velicinaPolja;
                poljaPrikaz[i.Redak, i.Stupac].Location = new Point(xPozicijaPolja, yPozicijaPolja);
                poljaPrikaz[i.Redak, i.Stupac].BackColor = Color.Black;
                poljaPrikaz[i.Redak, i.Stupac].BringToFront();
                poljaPrikaz[i.Redak, i.Stupac].Visible = true;
                Controls.Add(poljaPrikaz[i.Redak, i.Stupac]);

                if (i.Stupac < stupci - 1)
                {
                    xPozicijaPolja += offsetPolja;
                }
                else
                {
                    xPozicijaPolja = defaultX;
                    yPozicijaPolja += offsetPolja;
                }
            }

        }

        private void Start_Click(object sender, EventArgs e)
        {
            stupci = (int)brojStupacaOdabir.Value;
            retci = (int)brojRedakaOdabir.Value;
            NacrtajMrezu();
        }


        Mreža mreza;
        Size velicinaPolja = new Size(40, 40);
        int retci;
        int stupci;
        int offsetPolja = 41;
        int xPozicijaPolja;
        int yPozicijaPolja;
        int defaultX = 120;
        int defaultY = 75;
        private PictureBox[,] poljaPrikaz;


    }
}
