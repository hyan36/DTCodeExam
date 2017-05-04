using DT.CodeExam.Core.Core.Exceptions;
using DT.CodeExam.Core.Core.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.CodeExam.Core.Core
{
    public class Number
    {
        public decimal Source { get; set; }

        public Speller Speller { get; set; }

        public Boolean HasDecimal { get { return (Source - Math.Truncate(Source)) != 0;  } }

        public Number(decimal source)
        {
            if ((double) Math.Abs(source) > Math.Pow(10, 21))
            {
                throw new NumberTooHugeException(source);
            }
            Source = source;
            Speller = new Speller();
        }

        public String _stringValue;
        public string Spell(int places = 2)
        {
            var digit = (int) Math.Pow(10, places);
            if (string.IsNullOrEmpty(_stringValue))
            {
                var sb = new StringBuilder();
                sb.Append(Speller.SpellInteger(Source));
                if (HasDecimal)
                {
                    sb.Append(" point ");
                    sb.Append(Speller.SpellDecimal(Source, digit));
                }
                _stringValue = sb.ToString();
            }
            return _stringValue;
            
        }
    }
}
