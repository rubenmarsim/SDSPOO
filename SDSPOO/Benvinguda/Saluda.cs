using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benvinguda
{
    public class Saluda : ToolStripMenuItem
    {
        private string _oCatalan;

        public string oCatalan
        {
            get { return _oCatalan; }
            set { _oCatalan = value; }
        }

        private string _oCastellano;

        public string oCastellano
        {
            get { return _oCastellano; }
            set { _oCastellano = value; }
        }

        private string _oIngles;

        public string oIngles
        {
            get { return _oIngles; }
            set { _oIngles = value; }
        }

    }
}
