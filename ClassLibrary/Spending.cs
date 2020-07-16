﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class Spending
    {
        #region Atributes
        private double amount;
        private string description;
        private ESpending type;
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

        public ESpending Type
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
        public Spending() { }

        public Spending(double _amount, string _desc, ESpending _type, DateTime _date)
        {
            this.amount = _amount;
            this.description = _desc;
            this.type = _type;
            this.date = _date;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the current spending information.
        /// </summary>
        /// <returns></returns>
        public string ShowSpending()
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
