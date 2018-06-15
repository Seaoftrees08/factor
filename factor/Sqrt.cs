using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace factor
{
    class Sqrt
    {

        public BigInteger SqrtInt(BigInteger n)
        {

            string s = n.ToString();
            BigInteger l = s.Length;
            BigInteger root = RoughEstimate(n, s, l)+1;
            int resolutionPower = (int)(l >> 5);
            BigInteger resolution = BigInteger.Pow(32,resolutionPower);
            
            while (root * root < n)
            {
                root += resolution;
                if(root*root > n)
                {
                    if (resolutionPower != 0)
                    {
                        resolutionPower--;
                        resolution = BigInteger.Pow(32, resolutionPower);
                    }
                    else
                    {

                    }
                }
            }
            if (root * root > n) root--;
            return root;
        }

        private BigInteger RoughEstimate(BigInteger n,string s, BigInteger l)
        {
            BigInteger result = 0;
            int caldig = 1;

            if (l % 2 == 0) caldig = 2;

            l = l >> 1;
            s = s.Substring(0, caldig);
            double root = Math.Sqrt(int.Parse(s));

            //sqrt計算を小数点以下10桁まで信用
            int digit = 10;
            if (l < 11) digit = (int)l;
 
            root = Math.Truncate(root * Math.Pow(10,digit))/Math.Pow(10,digit);
            result = (BigInteger)root * (BigInteger)Math.Pow(10, (double)(l - (caldig - 1)));
            return result;
        }
    }
}
