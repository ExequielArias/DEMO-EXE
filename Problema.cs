using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO_EXE
{
    class Problema
    {
        public void saludar()
        {
            MessageBox.Show ("Hola"); 
        }

        public void verFrutas(ListBox lst)
        {
            string[] Frutas = { "UVA", "PERA", "LIMON", "BANANA" };
            lst.Items.Clear(); 
            foreach (string fruta in Frutas)
            {
                lst.Items.Add(fruta);
            }

        }

    }
}
