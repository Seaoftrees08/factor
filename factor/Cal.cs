using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace factor
{
    class Cal
    {
        public BigInteger Factor(BigInteger n)
        {

            var pp = new PreProcess();
            var rt = new Sqrt();
           // BigInteger root = pp.Process(n, rt.SqrtInt(n));

            return rt.SqrtInt(n);

            //return root;
        }

    }
}
