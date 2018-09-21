using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace FuzzyLogic_FIS
{
    [ComVisible(true)]
    public class Rule
    {
        List<RuleItem> _inrules;
        List<RuleItem> _outrules;
        Connector _conn;

        #region Constructor
        public Rule(List<RuleItem> ins, List<RuleItem> outs, Connector con)
        {
            _inrules = ins;
            _outrules = outs;
            _conn = con;
        }

        public Rule() 
        {
            _inrules = new List<RuleItem>();
            _outrules = new List<RuleItem>();
            _conn = Connector.And;
        }
        #endregion

        #region Getters & Setters
        public List<RuleItem> InputRules
        {
            get { return _inrules; }
        }

        public List<RuleItem> OutputRules
        {
            get { return _outrules; }
        }

        public Connector Connection
        {
            get { return _conn; }
            set { _conn = value; }
        }
        #endregion

        #region Methods
        public void addInRuleItem(RuleItem item)
        {
            if (item != null)
            {
                _inrules.Add(item);
            }
        }

        public void addOutRuleItem(RuleItem item)
        {
            if (item != null)
            {
                _inrules.Add(item);
            }
        }

        public override string ToString()
        {
            String rule = "IF ";
            for (int j = 0; j < InputRules.Count; j++)
            {
                rule = rule + InputRules[j].Variable + " is " + InputRules[j].MemberShipValue;
                if (j != InputRules.Count - 1)
                {
                    rule = rule + " And ";
                }
            }
            rule = rule + " Then ";
            for (int j = 0; j < OutputRules.Count; j++)
            {
                rule = rule + OutputRules[j].Variable + " is " + OutputRules[j].MemberShipValue;
                if (j != OutputRules.Count - 1)
                {
                    rule = rule + " And ";
                }
            }
            return rule;
        }

        #endregion

    }

    public enum Connector
    {
        And = 0,
        Or = 1
    };

}
