using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.CodeExam.Core.Core.Util
{
    public class Speller
    {
        protected string[] digit =
        {"", "one", "two", "three", "four", "five", "six","seven", "eight", "nine", "ten", "eleven", "twelve","thirteen", "fourteen", "fifteen", "sixteen","seventeen", "eighteen", "nineteen"};

        protected string[] baseten =  
        {"", "", "twenty", "thirty", "fourty", "fifty","sixty", "seventy", "eighty", "ninety"};

        protected string[] expo =
        {"", "thousand", "million", "billion", "trillion","quadrillion", "quintillion"};

        public Speller()
        {

        }

        public string SpellInteger(decimal number)
        {
            var result = string.Empty;

            var n = Decimal.Truncate(number);
            var sb = new StringBuilder();

            var thousands = 0;
            var power = 1;

            if (number < 0)
            {
                sb.Append("minus ");
                n = -n;
            }

            if (n == 0)
            {
                sb.Append("zero");
            }

            //analyze size of  
            for (decimal i = n; i >= 1000; i /= 1000)
            {
                power *= 1000;
                thousands++;
            }

            //seprate digit for every 3 digit
            bool sep = false;
            for (decimal i = n; thousands >= 0; i %= power, thousands--, power /= 1000)
            {
                int j = (int)(i / power);
                int k = j % 100;
                int hundreds = j / 100;
                int tens = j % 100 / 10;
                int ones = j % 10;

                if (j == 0)
                    continue;

                if (hundreds > 0)
                {
                    if (sep)
                        sb.Append(", ");

                    sb.Append(digit[hundreds]);
                    sb.Append(" hundred");
                    sep = true;
                }

                if (k != 0)
                {
                    if (sep)
                    {
                        sb.Append(" and ");
                        sep = false;
                    }

                    if (k < 20)
                        sb.Append(digit[k]);
                    else
                    {
                        sb.Append(baseten[tens]);
                        if (ones > 0)
                        {
                            sb.Append("-");
                            sb.Append(digit[ones]);
                        }
                    }
                }

                if (thousands > 0)
                {
                    sb.Append(" ");
                    sb.Append(expo[thousands]);
                    sep = true;
                }                
            }

            result = sb.ToString();
            return result;
        }

        /// <summary>
        /// Spell decimal part of a number
        /// </summary>
        /// <param name="number"></param>
        /// <param name="digits"></param>
        /// <returns></returns>
        public string SpellDecimal(decimal number, int digits = 1000 )
        {
            var result = string.Empty;
            var sb = new StringBuilder();

            var cents = Math.Abs((number - Math.Truncate(number)));
            cents = Math.Truncate(cents * digits);

            if (digits/10 > cents)
            {
                for (int i = digits / 10 ; i > cents; i /= 10 )
                {
                    sb.Append("zero ");
                }
            }

            var units = 0;
            var power = 1;

            //analyze size of  
            for (decimal i = cents; i >= 10; i /= 10)
            {
                power *= 10;
                units++;
            }

            
            for (decimal i = cents; units >= 0; i %= power, units--, power /= 10)
            {
                int j = (int)(i / power);
                var word = j == 0 ? "zero" : digit[j];
                sb.Append(word);
                sb.Append(" ");
            }

            result = sb.ToString();
            return result;
        }
    }
}
