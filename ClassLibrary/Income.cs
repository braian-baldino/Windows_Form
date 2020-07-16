using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class Income
    {
        #region Atributes
        private double amount;
        private string description;
        private EIncome type;
        private DateTime date;
        #endregion

        #region Properties
        public double Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public EIncome Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        #endregion

        #region Const.
        public Income() { }

        public Income(double _amount, string _desc, EIncome _type, DateTime _date)
        {
            this.amount = _amount;
            this.description = _desc;
            this.type = _type;
            this.date = _date;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the current income information.
        /// </summary>
        /// <returns></returns>
        public string ShowIncome()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Description}");
            sb.AppendLine($"{Type.ToString()}  ${Amount}");
            sb.AppendLine($"Fecha: {Date.ToString("dd/MM/yyyy")}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.description;
        }
        #endregion
    }
}
