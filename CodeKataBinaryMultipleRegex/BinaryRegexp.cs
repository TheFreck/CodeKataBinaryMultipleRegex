using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeKataBinaryMultipleRegex
{
    public class BinaryRegexp
    {
        public string DecToBin(int d)
        {
            var binary = String.Empty;
            int v = d;
            for(int i = 1;i<=d; i *= 2)
            {
                if ((v * 1 / i) % 2 == 1)
                {
                    binary = "1" + binary;
                    v -= i;
                }
                else
                {
                    binary = "0" + binary;
                }
            }
            var trimmed = binary.TrimStart('0');
            return trimmed.Length > 0 ? trimmed : "0";
        }

        public string Divide(string numerator, string denominator)
        {
            numerator = numerator.TrimStart('0');
            denominator = denominator.TrimStart('0');
            var v1Len = numerator.Length;
            var v2Len = denominator.Length;
            var comparitor = string.Empty;
            var answer = string.Empty;
            for(var i = 0; i < numerator.Length; i++)
            {
                comparitor += denominator[i];
                if (comparitor == GetLarger(numerator, comparitor))
                {
                    answer += "1";
                    //comparitor = comparitor
                }
                else
                {
                    answer += "0";
                }
            }
            return "";
        }

        public string[] FindSevens(int input)
        {
            var output = new List<string>();
            for(var i=0; i < input; i++)
            {

            }
            return output.ToArray();
        }

        public string GetLarger(string v1, string v2)
        {
            if (v1.Length > v2.Length) return v1;
            if(v1.Length < v2.Length) return v2;
            for(var i=0; i < v1.Length; i++)
            {
                if (v1[i] == v2[i])
                {
                    continue;
                }
                if (v1[i] =='1' && v2[i] == '0')
                {
                    return v1;
                }
                if (v1[i]=='0' && v2[i] == '1')
                {
                    return v2;
                }
            }
            return v2;
        }

        public bool IsDivisible(string? binary)
        {
            var pattern = "(^((0|1((1(01*00)*01*01|(0|1(01*00)*01*011)((0|1(1|0(01*00)*01*01))1)*(0|1(1|0(01*00)*01*01)))0)*(1|(0|1(01*00)*01*011)((0|1(1|0(01*00)*01*01))1)*10)(01*00)*1)+)$)";
            return Regex.IsMatch(binary, pattern);
        }

        public int LargestBinaryMultiple(int v)
        {
            var i = 0;
            for (i = 1; i <= v; i *= 2) { }
            return i/2;
        }

        public int Parse(string binary)
        {
            int dec = 0;
            for(var i=0; i < binary.Length; i++)
            {
                if (binary[binary.Length-(i+1)] == '1') 
                {
                    var decAdd = Enumerable.Repeat(2,i).Aggregate(1, (a, b) => a * b);
                    dec += Enumerable.Repeat(2,i).Aggregate(1, (a, b) => a * b);
                }
            }
            return dec;
        }

        public string Subtract(char[] v1, char[] v2)
        {
            var difference = string.Empty;
            var borrow = false;
            var lenDiff = v1.Length - v2.Length;
            if(lenDiff > 0)
            {
                var v3 = new List<char>();
                for(var i=0; i<lenDiff;i++)
                {
                    v3.Add('0');
                }
                v3.AddRange(v2);
                v2 = v3.ToArray();
            }
            for(var i=v1.Length-1; i>= 0 ; i--)
            {
                if (borrow)
                {
                    if(v1[i] == '1')
                    {
                        v1[i] = '0';
                        borrow = false;
                    }
                    else
                    {
                        v1[i] = '1';
                    }
                }
                else if (v1[i] == v2[i])
                {
                    difference = "0" + difference;
                }
                else if (v2[i] == '1')
                {
                    difference = "1" + difference;
                    borrow = true;
                }
                else
                {
                    difference = "1" + difference;
                }
            }
            return difference;
        }
    }
}
