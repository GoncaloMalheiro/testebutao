using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    class Contador
    {
        private string _path = Application.StartupPath + "\\Resources.Contador.txt";
            

        public void contar(object sender)
        {
            Button b = (Button)sender;
            int valor = Convert.ToInt32(b.Text) + 1;
            b.Text = valor.ToString();
            File.WriteAllText(_path, valor.ToString()); 
        }

        public string Abrir()
        {
            if (File.Exists(_path)) return File.ReadAllText(_path);
            return "0";
        }

    }
}
