using System;

namespace Ex1
{
    public class Money
    {
        public Money(char symbol, string currency, decimal value)
        {
            Symbol = symbol;
            Currency = currency;
            Value = value;
        }

        public char Symbol
        {
            get;
        }

        public string Currency 
        {
            get;
        }
        public decimal Value
        {
            get;
            set;
        }

        //override default string method
        public override string ToString()
        {
            return $"{Value} {Symbol} {Currency}";
        }
    }
}