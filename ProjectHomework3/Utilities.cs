using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHomework3
{
    public class Utilities
    {
        
        public int EnergyBill(int OldIndex, int NewIndex)
        {
            if (NewIndex - OldIndex > 0)
                return NewIndex - OldIndex;
            else
                return OldIndex-NewIndex;
            
        }
    }
}
