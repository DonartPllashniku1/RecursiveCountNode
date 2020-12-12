using System;
namespace BinaryTreeRecrusive
{
    class Program
    {
        public class Pema
        {
            public int teDhenat;
            public Pema majtas, djathtas;
        }
        public static Pema krijimiPema(int teDhenat)
        {
            Pema pema = new Pema();
            pema.teDhenat = teDhenat;
            pema.majtas = null;
            pema.djathtas = null;
            return (pema);
        }
        //Recursive
        public static int Numero(Pema rrenja)
        {
            if (rrenja == null)
                return 0;
            int r = 0;
            if (rrenja.majtas != null && rrenja.djathtas != null)
                r++;
            r += (Numero(rrenja.majtas) + Numero(rrenja.djathtas));
            return r;
        }
        // Krijimi i Pemes
        //Preorder(Root, Left, Right) : 1 2 4 5 3
        public static void Main()
        {
            Pema nyje = krijimiPema(10);
            //M
            nyje.majtas = krijimiPema(4);
            //D
            nyje.djathtas = krijimiPema(15);
            //MD
            nyje.majtas.djathtas = krijimiPema(7);
            nyje.majtas.djathtas.majtas = krijimiPema(5);
            nyje.majtas.djathtas.djathtas = krijimiPema(8);
            nyje.majtas.djathtas.djathtas.djathtas = krijimiPema(9);
            nyje.majtas.djathtas.majtas.djathtas = krijimiPema(6);
            //DD
            nyje.djathtas.djathtas = krijimiPema(18);
            nyje.djathtas.djathtas.majtas = krijimiPema(17);
            nyje.djathtas.djathtas.djathtas = krijimiPema(19);
            nyje.djathtas.djathtas.djathtas.djathtas = krijimiPema(21);
            nyje.djathtas.djathtas.majtas.majtas = krijimiPema(16);
            Console.WriteLine(Numero(nyje) + 2);
        }
    }
}