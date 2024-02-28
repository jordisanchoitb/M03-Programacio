/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 5/2/2024
 * 
 * Exercici x. 
 */
using System;

namespace OOPEx
{
    public class Program
    {
        public static void Main()
        {
            PaymentCard card = new PaymentCard(50);
            Console.WriteLine(card);
        }
    }

    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            Balance = openingBalance;
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public override string ToString()
        {
            return "The card has a balance of " + this.Balance + " euros";
        }
    }

}