using System;
using System.IO;
using System.Windows.Forms;

namespace Gestor
{
    public class Fichario
    {
        public string diretorio;
        public bool status;

        public Fichario(string Diretorio)
        {
            diretorio = Diretorio;

            if (!Directory.Exists(Diretorio))
            {
                Directory.CreateDirectory(Diretorio);
            }
        }

        public void Incluir(string id, string jsonunit)
        {
            try
            {
                if (!File.Exists(diretorio + "\\" + id + ".json"))
                {
                    File.WriteAllText(diretorio + "\\" + id + ".json", jsonunit);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
