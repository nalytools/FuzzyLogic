using RGiesecke.DllExport;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace FuzzyLogic_FIS
{
    [ComVisible(true)]
    
    public class Config
    {
        private ImpMethod _implication;
        private ConnMethod _andlogic;
        private DefuzzifcationType _defuzType;

        #region Constructor
        public Config(ImpMethod Imp, ConnMethod And)
        {
            _implication = Imp;
            _andlogic = And;
        }
        #endregion

        #region Getter & setter

     
        public ImpMethod Implication
        {
            get { return _implication; }
            set { _implication = value; }
        }

        public ConnMethod Logic
        {
            get { return _andlogic; }
            set { _andlogic = value; }
        }

        public DefuzzifcationType DefuzzificationType
        {
            get { return _defuzType; }
            set { _defuzType = value; }
        }

        #endregion

    }

    public enum DefuzzifcationType
    {
        Centroid = 0,
        ModifiedHeight =1
    }

   public enum ImpMethod
    {
        Min = 0,
        Prod = 1
    };

    public enum ConnMethod
    {
        Min = 0,
        Prod = 1
    };

}
