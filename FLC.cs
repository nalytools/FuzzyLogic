using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;


namespace FuzzyLogic_FIS
{
    [ComVisible(true)]
    public class FLC
    {

        Config _configuration;

        public FLC(Config conf)
        {
            _configuration = conf;
        }

        private double Centroid(List<FuzzyNumber> nums, LingVariable variable)
        {
            double stepN = 17;
            double start = variable.Range[0];
            double end = variable.Range[1];
            double step = (end - start) / (stepN - 1);
            double uppersum = 0;
            double lowersum = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                MemberShipFunction mf = variable.getMFbyName(nums[i].MemberShipName);
                for (double j = start; j < end; j = step + j)
                {
                    double value = mf.getOutput(j);
                    if (value > 0)
                    {
                        if (value < nums[i].FuzzyValue)
                        {
                            uppersum = value * j + uppersum;
                            lowersum = value + lowersum;
                        }
                        else
                        {
                            uppersum = nums[i].FuzzyValue * j + uppersum;
                            lowersum = nums[i].FuzzyValue + lowersum;
                        }
                    }
                }
            }
            return (uppersum / lowersum);
        }

        private double getImplication(double value1, double value2)
        {
            if (_configuration.Implication == ImpMethod.Min)
            {
                if (value1 < value2) { return value1; }
                else { return value2; }
            }
            else if (_configuration.Implication == ImpMethod.Prod)
            {
                return value1 * value2;
            }
            return 0;
        }

        private double MaxHeightDeFuzzifcation(List<FuzzyNumber> nums, LingVariable variable)
        {
            double lowvalue = 0;
            double highvalue = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                MemberShipFunction mf = variable.getMFbyName(nums[i].MemberShipName);
                highvalue = ((mf.CenterOfMass * getImplication(nums[i].FuzzyValue,mf.getOutput(mf.CenterOfMass))) / (mf.Spread*mf.Spread)) + highvalue;
                lowvalue = (getImplication(nums[i].FuzzyValue, mf.getOutput(mf.CenterOfMass)) / (mf.Spread * mf.Spread)) + lowvalue;
            }
            return (highvalue / lowvalue);
        }

        public List<FuzzyNumber> Fuzzification(double value, LingVariable variable)
        {
            List<FuzzyNumber> set = new List<FuzzyNumber>();
            List<MemberShipFunction> MFs = variable.MFs;
            for (int i = 0; i < variable.MFs.Count; i++)
            {
                double v = MFs[i].getOutput(value);
                if (v > 0)
                {
                    set.Add(new FuzzyNumber(MFs[i].Name, v));
                }
            }
            return set;
        }

        public double DeFuzzification(List<FuzzySet> Sets, LingVariable variable)
        {
            double value = 0;
            for (int i = 0; i < Sets.Count; i++)
            {
                //if (Sets[i].Variable == variable.Name)
                //{
                    if (_configuration.DefuzzificationType == DefuzzifcationType.ModifiedHeight)
                    {
                        value = MaxHeightDeFuzzifcation(Sets[i].Set, variable);
                    }
                    else if (_configuration.DefuzzificationType == DefuzzifcationType.Centroid)
                    {
                        value = Centroid(Sets[i].Set, variable);
                    }
                //}
            }
            return value;
        }

    }
}
