using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Images
{
    public class Card
    {
        private int _pointvalue;
        private Image _img;

        public Card(int pointvalue, Image img) 
        {
            _pointvalue = pointvalue;
            _img = img;
        }

        public int pointvalue 
        {
            get { return _pointvalue; }
            set { _pointvalue = value; }
        }

        public Image img 
        {
            get { return _img; }
            set { _img = value; }
        }
    }
}
