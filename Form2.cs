using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace DEMO_EXE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("D:/Mosquito/Langosta"); 
            //Nunca usar (\) ya que en c# tiene otro significado
            //O usar doble barra (\\)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool valor = Directory.Exists("D:/Mosquito");
            if (valor == true)
            {
                Directory.Delete("D:/Mosquito");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Create("D:/Mosquito/HOLA.txt"); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.Delete("D:/Mosquito/HOLA.txt");
            //Error
        }
        //En otro boton para copiar es : File.Copy
        //Para mover es : File.Move

    }
}
