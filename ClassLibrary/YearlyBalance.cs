using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    [Serializable]
    public class YearlyBalance
    {
        #region Atributes
        private List<Balance> balances;
        private Saving savings;
        private double totalSaved;
        private double totalSpent;
        private bool positive;
        private double result;
        private int year;
        #endregion

        #region Const.
        public YearlyBalance()
        {
            this.balances = new List<Balance>();
            savings = new Saving(0, 0);
        }

        public YearlyBalance(int _year) : this()
        {
            this.year = _year;
        }

        #endregion

        #region Properties
        public List<Balance> Balances
        {
            get { return this.balances; }
            set { this.balances = value; }
        }

        public Saving Savings
        {
            get { return savings; }
            set { savings = value; }
        }

        public double TotalSaved
        {
            get { return this.totalSaved; }
            set { this.totalSaved = value; }
        }

        public double TotalSpent
        {
            get { return this.totalSpent; }
            set { this.totalSpent = value; }
        }

        public double Result
        {
            get { return this.result; }
            set { this.result = value; }
        }

        public bool Positive
        {
            get { return this.positive; }
            set { this.positive = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Calculates all the values of the current yearly balance.
        /// </summary>
        public void CalculateYearlyBalance()
        {
            this.totalSaved = CalculateSaved();
            this.totalSpent = CalculateSpent();
            this.result = this.totalSaved - this.totalSpent;
            if (this.result < 0)
                this.positive = false;
            this.positive = true;
        }

        /// <summary>
        /// Calculates the total incomes of all the balances in the current yearly balance.
        /// </summary>
        /// <returns></returns>
        private double CalculateSaved()
        {
            double saved = 0;
            foreach (Balance balance in this.balances)
            {
                saved += balance.TotalIncomes;
            }
            return saved;
        }

        /// <summary>
        /// Calculates the total spendings of all the balances in the current yearly balance.
        /// </summary>
        /// <returns></returns>
        private double CalculateSpent()
        {
            double spent = 0;
            foreach (Balance balance in this.balances)
            {
                spent += balance.TotalSpendings;
            }
            return spent;
        }

        /// <summary>
        /// Recalculates the values of all the balances in the current yearly balance.
        /// </summary>
        public void Update()
        {
            foreach (Balance _bal in this.Balances)
            {
                _bal.CalculateBalance();
            }
            CalculateYearlyBalance();
        }

        /// <summary>
        /// Returns the current yearly balance information.
        /// </summary>
        /// <returns></returns>
        public string ShowYearlyBalance()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Año: {this.Year}");
            sb.AppendLine("");
            foreach (Balance _bal in this.Balances)
            {
                sb.AppendLine($"{_bal.Month}: $ {String.Format("{0:0.00}", _bal.Result)}");
            }
            sb.AppendLine("");
            sb.AppendLine($"Entrada Total: {String.Format("{0:0.00}", TotalSaved)}");
            sb.AppendLine($"Gasto Total: {String.Format("{0:0.00}", TotalSpent)}");
            return sb.ToString();
        }
        #endregion

        #region Operator Overloads
        /// <summary>
        /// Adds a balance to the current yearly balance and recalculates the current values.
        /// </summary>
        /// <param name="yearly"></param>
        /// <param name="balance"></param>
        /// <returns></returns>
        public static YearlyBalance operator + (YearlyBalance yearly, Balance balance)
        {
            foreach (Balance b in yearly.Balances)
            {
                if (b.Month == balance.Month)
                    throw new Exception($"El balance de {b.Month.ToString()} ya existe!");
            }
            yearly.Balances.Add(balance);
            yearly.CalculateYearlyBalance();
            return yearly;
        }

        /// <summary>
        /// Removes a balance of the current yearly balance and recalculates the current values.
        /// </summary>
        /// <param name="yearly"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static YearlyBalance operator - (YearlyBalance yearly, EMonth month)
        {
            foreach (Balance b in yearly.Balances)
            {
                if (b.Month == month)
                    yearly.balances.Remove(b);
                break;
            }
            yearly.CalculateYearlyBalance();
            return yearly;
        }

        #endregion


    }
}
