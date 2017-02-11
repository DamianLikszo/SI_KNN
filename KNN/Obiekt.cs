using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNN
{
    public class Obiekt
    {
        public int numer;
        public int koncept;
        public int decyzja;
        public int stan;                    // 1 - poprawnie sklafikowany, 2 - blednie sklafikowany
                                            // 3 - nie jest chwytany

        public Obiekt(int numer, int koncept, int stan, int decyzja)
        {
            this.numer = numer;
            this.decyzja = decyzja;
            this.koncept = koncept;
            this.stan = stan;
        }

    }
}
