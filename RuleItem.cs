using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace FuzzyLogic_FIS
{
    [ComVisible(true)]
    public class RuleItem
    {
        private String _variable;
        private String _membership;

        #region Constructor
        public RuleItem(String Variable, String Membership)
        {
            this._variable = Variable;
            this._membership = Membership;
        }
        #endregion

        #region Getter & Setters
        public String Variable
        {
            get { return _variable; }
        }

        public String MemberShipValue
        {
            get { return _membership; }
        }
        #endregion
    }
}
