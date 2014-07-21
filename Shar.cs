using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1a
{
    class Shar
    {
        protected double _rad;
        protected double _pl, _v, _vcube,_a,_h,_vsegm;

        public Shar(double r, double h)
        {
            _rad = r; _h = h;
            _pl = 4 * Math.PI * _rad * _rad;
            _v = (4 * Math.PI * _rad * _rad * _rad) / 3;
            _a = (_rad * 2);
            _vcube = _a * _a * _a;
            Segm(h);
        }
            private void Segm(double h)
        {
            _vsegm = Math.PI * _h * _h * (_rad - (_h / 3));
        }
        public double RAD
           {
               get { return _rad; }
           }
        public double H
        {
            get { return _h; }
        }
        public double PLOSHAD
        {
            get { return _pl; }
        }
        public double OBJEM
        {
            get { return _v; }
        }
        public double VCUBE
        {
            get { return _vcube; }
        }
        public double VSegm
        {
            get { return _vsegm; }
        }

    }
}
