using HamburgerProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerProject.Concrete
{
    public class Menu : Urun
    {
        public override string ToString()
        {
            return this.Ad + " Menü ";
        }
    }
}
