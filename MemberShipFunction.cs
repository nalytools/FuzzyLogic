using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;


namespace FuzzyLogic_FIS
{
    [ComVisible(true)]
    public abstract class MemberShipFunction
    {
        private String _label;
        private List<double> _points = new List<double>();
        private double _spread;
        private double _maxY = 1;
        private double _centerofmass;
        protected List<double> range = new List<double>();

        #region Setters & Getters
        public String Name
        {
            get { return _label; }
            set { _label = value; }
        }

        public List<double> Range
        {
            get { return range; }
        }

        public double CenterOfMass
        {
            get { return _centerofmass; }
        }

        public double Spread
        {
            get { return _spread; }
        }

        public List<double> Params
        {
            get { return _points; }
            set { _points = value; }
        }

        public double MaxY
        {
            get { return _maxY; }
            set { _maxY = value; }
        }

        #endregion

        #region abstract Methods
        public abstract double getOutput(double Xvalue);
        #endregion

        #region Helper Methods
        protected void CalculateCenterOfMass()
        {
            double stepN = 20;
            double start = this.Range[0];
            double end = this.Range[1];
            double step = (end - start) / (stepN - 1);
            double uppersum = 0;
            double lowersum = 0;

                for (double j = start; j < end; j = step + j)
                {
                    double value = this.getOutput(j);
                    if (value > 0)
                    {
                            uppersum = value * j + uppersum;
                            lowersum = value + lowersum;
                    }
                }
              _centerofmass = (uppersum / lowersum);
          }

        protected void calculateSpread()
        {
            _spread = range[1] - range[0]-1;
        }

        #endregion
      }
}
