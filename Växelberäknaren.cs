//Wiktoria Blomgren Strandberg
//wikblo-0@student.ltu.se
//L0002B Uppgift 1 - Windows Forms Application


using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace L0002B_Uppgift_1_Windows_Forms_App_.NET
{
    public partial class Växelberäknaren : Form
    {
        int växel;//Totalt växelbelopp.
        int sedel500, sedel200, sedel100, sedel50, sedel20, mynt10, mynt5, mynt1;//Valörer.

        List<String> antalValörer = new List<String>();//Lista som lagrar växeln som antalet av respektive valör.


        public Växelberäknaren()//Metod som initialiserar.
        {
            InitializeComponent();
        }


        private void knappAvsluta_Klick(object sender, EventArgs e)//Avslutar programmet vid knapp-tryck.
        {
            Environment.Exit(0);
        }


        private void knappBeräknaVäxel_Klick(object sender, EventArgs e)//Beräknar växel vid knapp-tryck.
        {
            string prisTextfält = prisFält.Text;//Inmatning av pris (belopp som ska betalas).
            int pris;

            string betaladSummaTextfält = betalatFält.Text;//Inmatning av belopp som har betalats.
            int betaladSumma;

            //Omvandlar string till int och kontrollerar att inmatningen i textfälten innehåller, och endast innehåller, siffror:
            if ((int.TryParse(prisTextfält, out pris)) && (int.TryParse(betaladSummaTextfält, out betaladSumma)))
            {
                if (betaladSumma > pris)//Om växel krävs.
                {
                    växel = betaladSumma - pris;//Beräknar den totala växeln.

                    beräknaAntalValörer();//Beräknar antalet sedlar/kronor av respektive valör.
                    skrivUtAntalValörer();//Skriver ut antalet sedlar/kronor av respektive valör.
                }
                else if (betaladSumma == pris)//Om växel ej krävs.
                {
                    antalValörer.Clear();//Rensar lista så att inget gammalt ligger kvar.

                    //Lägger till i, och skriver ut, listan i en MessageBox:
                    antalValörer.Add("Betalat belopp överensstämmer med belopp som ska betalas, ingen växel krävs.");
                    MessageBox.Show(string.Join(Environment.NewLine, antalValörer), "Beräkna växel", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else//Om betaladSumma är lägre än pris.
                {
                    antalValörer.Clear();//Rensar lista så att inget gammalt ligger kvar.

                    //Lägger till i, och skriver ut, listan i en MessageBox:
                    antalValörer.Add("Betalat belopp är lägre än beloppet som ska betalas, kontrollera inmatning.");
                    MessageBox.Show(string.Join(Environment.NewLine, antalValörer), "Beräkna växel",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else//Om inmatning inte innehåller, eller innehåller annat än, siffror.
            {
                MessageBox.Show("Inmatning ska, och ska endast, innehålla siffor.", "Beräkna växel",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);//Skriver ut felmeddelande i en MessageBox.
            }
        }


        private void beräknaAntalValörer()//Beräknar antalet sedlar/kronor av respektive valör.
        {
            //500-sedlar:
            sedel500 = (växel / 500);//Beräkning av antalet 500-sedlar.
            int uppdateradSumma = växel % 500;//Kvarstående belopp efter att antalet 500-sedlar har beräknats.

            //200-sedlar:
            sedel200 = (uppdateradSumma / 200);
            uppdateradSumma = (uppdateradSumma % 200);

            //100-sedlar:
            sedel100 = (uppdateradSumma / 100);
            uppdateradSumma = (uppdateradSumma % 100);

            //50-sedlar:
            sedel50 = (uppdateradSumma / 50);
            uppdateradSumma = (uppdateradSumma % 50);

            //20-sedlar:
            sedel20 = (uppdateradSumma / 20);
            uppdateradSumma = (uppdateradSumma % 20);

            //10-kronor:
            mynt10 = (uppdateradSumma / 10);
            uppdateradSumma = (uppdateradSumma % 10);

            //5-kronor:
            mynt5 = (uppdateradSumma / 5);
            uppdateradSumma = (uppdateradSumma % 5);

            //1-kronor:
            mynt1 = uppdateradSumma;

        }


        //Skriver ut antalet sedlar/kronor av respektive valör och ändrar ändelsen beroende på singular/plural:
        private void skrivUtAntalValörer()
        {
            antalValörer.Clear();//Rensar lista så att inget gammalt ligger kvar.


            antalValörer.Add("Beräknad växel är " + växel + " kr:");//Lägger till totala mängden växel i listan.

            //500-sedlar:
            if (sedel500 > 1)//Om växeln består av flera 500-sedlar.
            {
                antalValörer.Add(sedel500 + " st 500-sedlar.");//Lägger till antalet 500-sedlar i listan med en plural-ändelse.
            }
            else if (sedel500 == 1)//Om växeln består av en, och endast en, 500-sedel.
            {
                antalValörer.Add(sedel500 + " 500-sedel.");//Lägger till antalet 500-sedlar i listan med en singular-ändelse.
            }

            //200-sedlar:
            if (sedel200 > 1)
            {
                antalValörer.Add(sedel200 + " st 200-sedlar.");
            }
            else if (sedel200 == 1)
            {
                antalValörer.Add(sedel200 + " 200-sedel.");
            }

            //100-sedlar:
            if (sedel100 > 1)
            {
                antalValörer.Add(sedel100 + " st 100-sedlar.");
            }
            else if (sedel100 == 1)
            {
                antalValörer.Add(sedel100 + " 100-sedel.");
            }

            //50-sedlar:
            if (sedel50 > 1)
            {
                antalValörer.Add(sedel50 + " st 50-sedlar.");
            }
            else if (sedel50 == 1)
            {
                antalValörer.Add(sedel50 + " 50-sedel.");
            }

            //20-sedlar:
            if (sedel20 > 1)
            {
                antalValörer.Add(sedel20 + " st 20-sedlar.");
            }
            else if (sedel20 == 1)
            {
                antalValörer.Add(sedel20 + " 20-sedel.");
            }

            //10-kronor:
            if (mynt10 > 1)
            {
                antalValörer.Add(mynt10 + " st 10-kronor.");
            }
            else if (mynt10 == 1)
            {
                antalValörer.Add(mynt10 + " 10-krona.");
            }

            //5-kronor:
            if (mynt5 > 1)
            {
                antalValörer.Add(mynt5 + " st 5-kronor.");
            }
            else if (mynt5 == 1)
            {
                antalValörer.Add(mynt5 + " 5-krona.");
            }

            //1-kronor:
            if (mynt1 > 1)
            {
                antalValörer.Add(mynt1 + " st 1-kronor.");
            }
            else if (mynt1 == 1)
            {
                antalValörer.Add(mynt1 + " 1-krona.");
            }

            MessageBox.Show(string.Join(Environment.NewLine, antalValörer), "Beräkna växel",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);//Skriver ut listan i en MessageBox.
        }

    }
}
