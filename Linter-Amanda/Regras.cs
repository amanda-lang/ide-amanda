using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Linter_Amanda
{
    public class Regras
    {
        public static Regex Operators()
        {
            string pattern = @"\b(\+)|(-)|(\*)|(\/)|(\/\/)|(%)\b";
            return new Regex(pattern);
        }

        public static Regex Logics()
        {
            string pattern = @"\b(<|>|<=|>=|!=|==|nao|sim|e|ou)\b";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public static Regex Assigments()
        {
            string pattern = @"(=|\+=|\-=|\*=|\/=)";
            return new Regex(pattern);
        }

        public static Regex Keywords()
        {
            string pattern = @"\b(var|se|mostra|verdadeiro|falso|senao|entao|enquanto|para|faca|de|func|retorna|inc|fim|classe|vazio|nulo|eu|super)\b";
            return new Regex(pattern);
        }

        public static Regex Operands()
        {
            string pattern = "([0-9]+)|([0-9]+(.)[0-9]+)|([0-9]|_)([0-9]|[a-z]|[A-Z]|_)*";
            return new Regex(pattern);
        }

        public static Regex String()
        {
            string pattern = "\".+?\"";
            return new Regex(pattern);
        }

        public static Regex Comments()
        {
            string pattern = "#.*";
            return new Regex(pattern);
        }

        public static Regex Types()
        {
            string pattern = @"\b(int|texto|real|bool)\b";
            return new Regex(pattern);
        }
    }
}

