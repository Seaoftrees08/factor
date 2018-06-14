using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace factor
{
    class PreProcess
    {

        //最後が3になったrootを返す。割り切れた場合は負の数にして返す。
        public BigInteger Process(BigInteger n, BigInteger root)
        {
            int i = LastNumber(root);
            int start = 0;

            if (i != 0)
            {
                switch ((i - 1) / 2)
                {
                    case 0:
                        start = 1;
                        break;
                    case 1:
                        start = 3;
                        break;
                    case 2:
                        start = 3;
                        break;
                    case 3:
                        start = 7;
                        break;
                    case 4:
                        start = 9;
                        break;
                }
            }
            else
            {
                start = 9;
            }

            root = root - i + start;

            while (start != 3)
            {
                if (n % root == 0)
                {
                    return -root;
                }

                root -= 2;
                start -= 2;
                if (start == 5)
                {
                    root -= 2;
                    start -= 2;
                }
            }

            return root;
        }

        private int LastNumber(BigInteger i)
        {
            string s = i.ToString();
            s = s.Substring(s.Length - 1);
            return int.Parse(s);
        }

    }
}
