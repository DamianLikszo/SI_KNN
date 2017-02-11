using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KNN
{
    public partial class Form1 : Form
    {
        public int[,] aSystemTRN;
        public int[,] aSystemTST;
        public int nMetryka;
        public int k;

        public Form1()
        {
            aSystemTRN = null;
            aSystemTST = null;
            nMetryka = -1;
            k = 0;

            InitializeComponent();
        }

        private int[,] WczytajSystem(string sPath)
        {
            int[,] aSystem = null;
            int nCols, nRows;
            string[] aLinie;

            if (File.Exists(sPath))
            {
                aLinie = File.ReadAllLines(sPath);
                nCols = aLinie[0].Split(' ').Length;
                nRows = aLinie.Length;

                aSystem = new int[nRows, nCols];

                string[] aLiczby;
                for (int i = 0; i < aLinie.Length; i++)
                {
                    aLiczby = aLinie[i].Split(' ');
                    for (int j = 0; j < aLiczby.Length; j++)
                    {
                        aSystem[i, j] = int.Parse(aLiczby[j]);
                    }
                }
            }

            return aSystem;
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            string sPathTRN = "SystemTreningowy.txt";
            string sPathTST = "SystemTestowy.txt";

            this.aSystemTRN = this.WczytajSystem(sPathTRN);
            this.aSystemTST = this.WczytajSystem(sPathTST);

            if (this.aSystemTRN == null || this.aSystemTST == null)
            {
                MessageBox.Show("Błąd. System nie został wczytany.");
            }
            else if(this.aSystemTRN.GetLength(1) != this.aSystemTST.GetLength(1))
            {
                MessageBox.Show("Błąd. Systemy nie mają tyle samo argumentów.");
            }
            else
            {
                btnPokazTRN.Enabled = true;
                btnPokazTST.Enabled = true;
                btnWynik.Enabled = true;
            }
        }

        private void btnPokazTRN_Click(object sender, EventArgs e)
        {
            string sKomunikat = "System Treningowy:\n\n";

            for (int i = 0; i < this.aSystemTRN.GetLength(0); i++)
            {
                sKomunikat += "          ";
                for (int j = 0; j < this.aSystemTRN.GetLength(1); j++)
                {
                    sKomunikat += aSystemTRN[i, j];
                    sKomunikat += " ";
                }
                sKomunikat += "\n";
            }

            MessageBox.Show(sKomunikat);
        }

        private void btnPokazTST_Click(object sender, EventArgs e)
        {
            string sKomunikat = "System Testowy:\n\n";

            for (int i = 0; i < this.aSystemTST.GetLength(0); i++)
            {
                sKomunikat += "       ";
                for (int j = 0; j < this.aSystemTST.GetLength(1); j++)
                {
                    sKomunikat += aSystemTST[i, j];
                    sKomunikat += " ";
                }
                sKomunikat += "\n";
            }

            MessageBox.Show(sKomunikat);
        }

        private void comboMetryka_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nMetryka = comboMetryka.SelectedIndex;
        }

        private void updownK_ValueChanged(object sender, EventArgs e)
        {
            this.k = (int)updownK.Value;
        }

        private List<int> listaKonceptow(int[,] aSystem)
        {
            List<int> aKoncepty = new List<int>();
            int tmp;

            for (int row = 0; row < aSystem.GetLength(0); row++)
            {
                tmp = aSystem[row, aSystem.GetLength(1) - 1];

                if (!aKoncepty.Contains(tmp))
                {
                    aKoncepty.Add(tmp);
                }
            }

            aKoncepty.Sort();

            return aKoncepty;
        }

        private double WyliczMetryke(int nObiektX, int nObiektY)
        {
            double metrykad = 0;

            switch (this.nMetryka)
            {
                case 0:                         // Euklidesa
                    for (int a = 0; a < this.aSystemTRN.GetLength(1)- 1; a++)
                    {
                        metrykad += Math.Pow(this.aSystemTST[nObiektX, a] - this.aSystemTRN[nObiektY, a], 2);
                    }

                    metrykad = Math.Sqrt(metrykad);
                    break;
                case 1:                         // Manhattana
                    for (int a = 0; a < this.aSystemTRN.GetLength(1) - 1; a++)
                    {
                        metrykad += Math.Abs(this.aSystemTST[nObiektX, a] - this.aSystemTRN[nObiektY, a]);
                    }
                    break;
                case 2:                         // Canberra
                    for (int a = 0; a < this.aSystemTRN.GetLength(1) - 1; a++)
                    {
                        metrykad += Math.Abs( (this.aSystemTST[nObiektX, a] - this.aSystemTRN[nObiektY, a]) / (double)(this.aSystemTST[nObiektX, a] + this.aSystemTRN[nObiektY, a]) );
                    }
                    break;
                case 3:                         // Czebyszewa
                    List<double> aTMP = new List<double>();
                    for (int a = 0; a < this.aSystemTRN.GetLength(1) - 1; a++)
                    {
                        aTMP.Add(Math.Abs(this.aSystemTST[nObiektX, a] - this.aSystemTRN[nObiektY, a]));
                    }

                    metrykad = aTMP.Max();

                    break;
                case 4:                         // Bezwzględny współczynnik korelacji Pearsona
                    double tx = 0;
                    double ty = 0;
                    int countA = this.aSystemTST.GetLength(1) - 1;

                    for (int a = 0; a < countA; a++)
                    {
                        tx += this.aSystemTST[nObiektX, a];
                        ty += this.aSystemTRN[nObiektY, a];
                    }

                    tx /= (double)countA;
                    ty /= (double)countA;

                    double sumx = 0;
                    double sumy = 0;

                    for (int a = 0; a < countA; a++)
                    {
                        sumx += Math.Pow(this.aSystemTST[nObiektX, a] - tx, 2);
                        sumy += Math.Pow(this.aSystemTRN[nObiektY, a] - ty, 2);
                    }

                    sumx /= (double)countA;
                    sumy /= (double)countA;

                    sumx = Math.Sqrt(sumx);
                    sumy = Math.Sqrt(sumy);

                    double rxy = 0;

                    for (int a = 0; a < countA; a++)
                    {
                        rxy += ((this.aSystemTST[nObiektX, a] - tx) / sumx) * ((this.aSystemTRN[nObiektY, a] - ty) / sumy);
                    }

                    rxy /= (double)countA;

                    metrykad = 1 - Math.Abs(rxy);

                    break;
            }

            return Math.Round(metrykad, 4);
        }

        private void KNN()
        {
            Dictionary<int, double> aMetryki;
            List<Obiekt> aObiekty = new List<Obiekt>();
            string sLog = "";
            double tmpMetryka;

            for (int nObiektX = 0; nObiektX < this.aSystemTST.GetLength(0); nObiektX++)
            {
                sLog += "\r\nDla x" + nObiektX + ":\r\n";
                aMetryki = new Dictionary<int, double>();

                for (int nObiektY = 0; nObiektY < this.aSystemTRN.GetLength(0); nObiektY++)
                {
                    tmpMetryka = WyliczMetryke(nObiektX, nObiektY);
                    sLog += "d(" + nObiektX + ", " + nObiektY + ") = " + tmpMetryka + "\r\n";
                    aMetryki.Add(nObiektY, tmpMetryka);
                }
                sLog += "\r\n";

                int count;
                double moc;
                List<double> aMoce = new List<double>();
                List<int> aKonceptyTST = listaKonceptow(this.aSystemTST);
                List<int> najblizsiSasiedzi = new List<int>();
                
                foreach (int koncept in aKonceptyTST)
                {
                    count = 0;
                    moc = 0;
                    
                    sLog += "Dwóch najbliższych sąsiadów obiektu testowego x" + nObiektX + " w klasie decyzyjnej " + koncept + " to ";
                    foreach (KeyValuePair<int, double> item in aMetryki.OrderBy(key => key.Value))
                    {
                        if (count == this.k)
                            break;

                        if(this.aSystemTRN[item.Key, aSystemTRN.GetLength(1) - 1] == koncept)
                        {
                            count++;
                            najblizsiSasiedzi.Add(item.Key);
                            moc += item.Value;

                            sLog += "y" + item.Key;
                            if (count != this.k)
                                sLog += ", ";
                            else
                                sLog += ".\r\n";
                        }
                    }
                    sLog += "Klasa " + koncept + " głosuje z mocą " + moc +".\r\n";
                    aMoce.Add(moc);
                }

                int decyzja = -1;
                int stan;
                if (aMoce[0] > aMoce[1])
                {
                    decyzja = aKonceptyTST[1];
                    sLog += aMoce[0] + " > " + aMoce[1] + "\r\n";
                    sLog += "Obiekt x" + nObiektX + " otrzymuje decyzję " + decyzja + ", ";

                    if (decyzja == this.aSystemTST[nObiektX, this.aSystemTST.GetLength(1) - 1])
                    {
                        stan = 1;
                        sLog += "jest poprawnie sklasyﬁkowany.\r\n";
                    }
                    else
                    {
                        stan = 2;
                        sLog += "jest błędnie sklasyﬁkowany.\r\n";
                    }
                }
                else if(aMoce[0] < aMoce [1])
                {
                    decyzja = aKonceptyTST[0];
                    sLog += aMoce[0] + " < " + aMoce[1] + "\r\n";
                    sLog += "Obiekt x" + nObiektX + " otrzymuje decyzję " + decyzja + ", ";

                    if (decyzja == this.aSystemTST[nObiektX, this.aSystemTST.GetLength(1) - 1])
                    {
                        stan = 1;
                        sLog += "jest poprawnie sklasyﬁkowany.\r\n";
                    }
                    else
                    {
                        stan = 2;
                        sLog += "jest błędnie sklasyﬁkowany.\r\n";
                    }
                }
                else
                {
                    stan = 3;
                    sLog += aMoce[0] + " = " + aMoce[1] + "\r\n";
                    sLog += "Stąd obiekt x" + nObiektX + " nie jest chwytany, nie jesteśmy w stanie powiedzieć, która klasa jest bliżej w sensie dwóch najbliższych sąsiadów.\r\n";
                }

                aObiekty.Add( new Obiekt(nObiektX, (int)this.aSystemTST[nObiektX, this.aSystemTST.GetLength(1) - 1], stan, decyzja));
            }

            sLog += "\r\nPodsumowując klasyﬁkację: \r\n";
            foreach (Obiekt item in aObiekty)
            {
                sLog += "- Obiekt x"+ item.numer;
                switch (item.stan)
                {
                    case 1:
                        sLog += " otrzymuje decyzję "+ item.decyzja + ", jest poprawnie sklasyﬁkowany.";
                        break;
                    case 2:
                        sLog += " otrzymuje decyzję "+ item.decyzja + ", jest błędnie sklasyﬁkowany.";
                        break;
                    case 3:
                        sLog += " nie jest chwytany.";
                        break;
                }
                sLog += "\r\n";
            }

            //Macierz Predykacji
            List<int> aKoncepty = listaKonceptow(this.aSystemTST);
            string sMacierz = "";
            int[,] aMacierz = new int[aKoncepty.Count, aKoncepty.Count];

            for (int i = 0; i < aMacierz.GetLength(0); i++)
            {
                for (int j = 0; j < aMacierz.GetLength(1); j++)
                {
                    int count = 0;

                    foreach (Obiekt item in aObiekty)
                    {
                        // nie chwycone nie wpadna (-1)
                        if (item.koncept == aKoncepty[i] && item.decyzja == aKoncepty[j])
                        {
                            count++;
                        }
                    }
                    
                    aMacierz[i, j] = count;
                }
            }

            // Naglowek
            sMacierz += "    |";
            foreach (int kol in aKoncepty)
            {
                sMacierz += Convert.ToString(kol).PadLeft(4) + "|";
            }
            sMacierz += "NO OBJ|ACC|COV";
            sMacierz += "\r\n";

            sMacierz = String.Concat(sMacierz, new String('=', 34));
            sMacierz += "\r\n";

            //Wiersze
            int num = 0;
            foreach (int row in aKoncepty)
            {
                sMacierz += Convert.ToString(row).PadLeft(4) + "|";

                for (int i = 0; i < aMacierz.GetLength(1); i++)
                {
                    sMacierz += Convert.ToString(aMacierz[num, i]).PadLeft(4) + "|";
                }

                //statystyki
                int countAll = 0;
                int countOk = 0;        // poprawnie sklasyfikowane
                int countChwyc = 0;     // chwycone

                foreach (Obiekt item in aObiekty)
                {
                    if(item.koncept == row)
                    {
                        countAll++;

                        if(item.stan == 1)
                        {
                            countOk++;
                        }

                        if (item.stan != 3)
                        {
                            countChwyc++;
                        }
                    }    
                }

                sMacierz += Convert.ToString(countAll).PadLeft(6) + "|";                        // No Obj
                sMacierz += Convert.ToString(Math.Round(countOk / (double)countChwyc, 1)).PadLeft(3) + "|";   // ACC
                sMacierz += Convert.ToString(Math.Round(countChwyc / (double)countAll, 1)).PadLeft(3);                // COV

                sMacierz += "\r\n";

                num++;
            }

            sMacierz = String.Concat(sMacierz, new String('=', 34));
            sMacierz += "\r\n";

            //TRN
            sMacierz += " TRN|";
            for (int kol = 0; kol < aMacierz.GetLength(1); kol++)
            {
                double nSum = 0;

                for (int row = 0; row < aMacierz.GetLength(0); row++)
                {
                    nSum += aMacierz[row, kol];
                }

                sMacierz += Convert.ToString(Math.Round(aMacierz[kol, kol]/nSum,2)).PadLeft(4) + "|";
            }

            //Wyswietlenie Wyniku
            Form2 oknoWyniku = new Form2(this, sMacierz, sLog);
            oknoWyniku.Show();
            this.Hide();

            return;
        }

        private void btnWynik_Click(object sender, EventArgs e)
        {
            if (this.nMetryka == -1)
            {
                MessageBox.Show("Wybierz Metrykę!");
                return;
            }

            if (this.k == 0)
            {
                MessageBox.Show("Wybierz ilość sąsiadów [k]!");
                return;
            }

            KNN();

            return;
        }

    }
}
