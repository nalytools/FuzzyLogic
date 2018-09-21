using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;


namespace FuzzyLogic_FIS
{
    [ComVisible(true)]
    public class LingVariable
    {
        private String _label;
        private List<double> _range;
        private List<MemberShipFunction> _funcs;
        private VarType _type;

        #region Constructor
        public LingVariable(String Name, VarType type)
        {
            _label = Name;
            _range = new List<double>(2);
            _funcs = new List<MemberShipFunction>();
            _type = type;
        }
        #endregion

        #region Setters & Getters
        public String Name
        {
            get { return _label; }
            set { _label = value; }
        }

        public List<double> Range
        {
            get { return _range; }
            set { _range = value; }
        }

        public VarType Type
        {
            get { return _type; }
        }

        public List<MemberShipFunction> MFs
        {
            get { return _funcs; }
        }
        #endregion

        #region Methods
        public void setRange(double start, double end)
        {
            Range.Add(start);
            Range.Add(end);
        }

        public MemberShipFunction getMFbyName(String name)
        {
            return _funcs.Find(delegate(MemberShipFunction mf) { return mf.Name == name; });
        }

        public void addMF(MemberShipFunction mf)
        {
            if (mf != null)
            {
                _funcs.Add(mf);
            }
        }

        public bool removeMF(MemberShipFunction mf)
        {
            if (mf != null)
            {
                return _funcs.Remove(mf);
            }
            return false;
        }
        #endregion
    }

    public enum VarType
    {
        Input = 0,
        Output = 1
    };

}
