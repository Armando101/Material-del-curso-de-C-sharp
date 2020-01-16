using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Amigo> amigos = new List<Amigo>();
            amigos.Add(new Amigo("Ricardina","523523523",6));
            amigos.Add(new Amigo("Jorge", "588523523", 8));
            amigos.Add(new Amigo("Luis", "523523623", 7));
            Peda.armarPeda(amigos, "Xochimilco");
        }
    }

    static class Peda
    {
        static int chelas;

        static public bool armarPeda(List<Amigo> amigos, String lugar) {
            bool searmo = false;
            if (amigos.Count > 1) {
                foreach (Amigo a in amigos) {
                    if (a.llamar())
                    {
                        chelas += a.seToma;
                        searmo = true;
                    }
                }
                if (searmo)
                    Console.WriteLine("La peda se armó, necesitas comprar "+chelas+" chelas.\nVamos a "+lugar+"!");
                else
                    Console.WriteLine("No se armó la peda");
            }
            return searmo;
        }
    }

    public class Amigo
    {
        public Amigo(String no, String nu,int st) {
            nombre = no;
            numero = nu;
            seToma = st;
        }
        public String nombre;
        public String numero;
        public int seToma;
        public bool llamar() {
            if (numero.Length >= 8)
                return true;
            return false;
        }
    }
}
