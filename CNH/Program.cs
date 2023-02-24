using System;
using System.Text.RegularExpressions;

namespace CNH
{
    public class CNHValida
    {
        static void Main() { }
        static public bool Execute(string cnh)
        {
            string validador = "^[0-9]{11}$";
            Regex re = new Regex(validador);

            if (re.IsMatch(cnh))
                return true;
            else
                return false;
        }
    }
}