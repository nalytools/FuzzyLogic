using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace FuzzyLogic_FIS
{
    [ComVisible(true)]
    public class FuzzyNumber
    {
        String _membername;
        double _fuzzyout;

        public FuzzyNumber(String MemName, double value)
        {
            _membername = MemName;
            _fuzzyout = value;
        }

        public String MemberShipName
        {
            get { return _membername; }
        }

        public double FuzzyValue
        {
            get { return _fuzzyout; }
            set { _fuzzyout = value; }
        }

        public override string ToString()
        {
            return MemberShipName + " ---> " + FuzzyValue.ToString();
        }
      

    }
}
