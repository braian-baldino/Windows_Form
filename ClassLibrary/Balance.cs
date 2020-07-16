using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    [Serializable]
    public class Balance
    {
        #region Atributes
        private List<Income> incomes;
        private double totalIncomes;
        private List<Spending> spendings;
        private double totalSpendings;
        private double result;
        private EMonth month;
        #endregion

        #region Properties
        public List<Income> Incomes
        {
            get { return this.incomes; }
            set { this.incomes = value; }
        }

        public double TotalIncomes
        {
            get { return this.totalIncomes; }
            set { this.totalIncomes = value; }
        }

        public List<Spending> Spendings
        {
            get { return this.spendings; }
            set { this.spendings = value; }
        }

        public double TotalSpendings
        {
            get { return this.totalSpendings; }
            set { this.totalSpendings = value; }
        }

        public double Result
        {
            get { return this.result; }
            set { this.result = value; }
        }

        public EMonth Month
        {
            get { return this.month; }
            set { this.month = value; }
        }
        #endregion

        #region Constr.
        public Balance() 
        {
           this.incomes = new List<Income>();
           this.spendings = new List<Spending>();
        }

        public Balance(EMonth month) : this()
        {
            this.month = month;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Calculates the incomes, spendings and result of the current balance.
        /// </summary>
        public void CalculateBalance()
        {
            this.totalIncomes = CalculateIncomes();
            this.totalSpendings = CalculateSpendings();
            this.result = BalanceResult();
        }

        /// <summary>
        /// Returns the balance result.
        /// </summary>
        /// <returns></returns>
        private double BalanceResult()
        {
            return (this.totalIncomes - this.totalSpendings);
        }

        /// <summary>
        /// Returns the sum of all the incomes in the current balance.
        /// </summary>
        /// <returns></returns>
        private double CalculateIncomes()
        {
            double total = 0;
            foreach (Income _in in incomes)
            {
                total += _in.Amount;
            }
            return total;
        }

        /// <summary>
        /// Returns the sum of all the spendings in the current balance.
        /// </summary>
        /// <returns></returns>
        private double CalculateSpendings()
        {
            double total = 0;
            foreach (Spending _sp in spendings)
            {
                total += _sp.Amount;
            }
            return total;
        }

        /// <summary>
        /// Returns the balance information.
        /// </summary>
        /// <returns></returns>
        public string ShowBalance()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Mes: {this.Month}");
            sb.AppendLine($"Entrada Total: {String.Format("{0:0.00}", TotalIncomes)}");
            sb.AppendLine($"Gasto Total: {String.Format("{0:0.00}", TotalSpendings)}");
            sb.AppendLine($"Resultado: {String.Format("{0:0.00}", Result)}");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the current balance information in detail. List of incomes and spendings are included.
        /// </summary>
        /// <returns></returns>
        public string ShowBalanceDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Balance de {this.Month}");

            sb.AppendLine("");
            foreach (Income _in in this.Incomes)
            {
                sb.AppendLine($"{_in.ShowIncome()}");
            }
            sb.AppendLine($"Entradas Totales: {this.TotalIncomes}");

            sb.AppendLine("----------------------------------");

            sb.AppendLine("");           
            foreach (Spending _sp in this.Spendings)
            {
                sb.AppendLine($"{_sp.ShowSpending()}");
            }
            sb.AppendLine($"Gastos Totales: {this.TotalSpendings}");

            sb.AppendLine("----------------------------------");

            sb.AppendLine("");
            sb.AppendLine($"Balance: {String.Format("{0:0.00}",Result)}");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the current balance month.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Month.ToString();
        }
        #endregion

        #region Operator Overload
        /// <summary>
        /// Adds a spending to the balance and calculate every time a new one is added.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Balance operator +(Balance b,Spending s)
        {
            if(b != null && s != null)
            {
                b.Spendings.Add(s);
                b.CalculateBalance();
            }
            return b;
        }

        /// <summary>
        /// Adds an Income to the balance and calculate every time a new one is added.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Balance operator +(Balance b, Income i)
        {
            if (b != null && i != null)
            {
                b.Incomes.Add(i);
                b.CalculateBalance();
            }
            return b;
        }

        /// <summary>
        /// Compare if the current balance´s month is the same as in the argument.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator ==(Balance b, EMonth m)
        {
            if (b.Month == m)
                return true;
            return false;
        }

        /// <summary>
        /// Compare if the current balance´s month is different as the one in the argument.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator != (Balance b, EMonth m)
        {
            return !(b == m);
        }
        #endregion
    }
}
