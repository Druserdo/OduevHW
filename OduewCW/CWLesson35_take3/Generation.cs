using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWLesson35_take3
{
    internal class Generation
    {
        private int from;
        private int until;

        public Generation(int from, int until)
        {
            this.from = from;
            this.until = until;
            if (from > until)
            {
                int temp = this.from;
                this.from = this.until;
                this.until = temp;
            }
        }
    public int getNumber()
        {
            Random rand = new Random();
            return rand.Next(from,until+1);
        }
    }
}
