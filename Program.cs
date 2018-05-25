using System;

namespace Cocina
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            string prender;
            string mante;
            string huevon;

            bool num1 = false;
            bool num2 = false;
            bool num3 = false;
            bool num4 = false;
            bool num5 = false;


            Combustible comb = new Combustible();
            Electrodomestico elec = new Electrodomestico();
            Utensilios ute = new Utensilios();
            Condimento con = new Condimento();
            Huevo hue = new Huevo();


            Console.WriteLine("Hola, hoy cocinaremos un huevo frito");
            while (num1 == false)
            {
                Console.WriteLine("Con cuanto combustible cuenta para la parrilla?");
                Console.WriteLine("Capacidad: ");
                comb.cap_combustible = int.Parse(Console.ReadLine());
                Console.WriteLine("Durabilidad: ");
                comb.dur_combustible = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Los datos son correctos?");
                Console.WriteLine("Capacidad: " + comb.cap_combustible);
                Console.WriteLine("Durabilidad: " + comb.dur_combustible);
                Console.WriteLine("s/n");
                respuesta = Console.ReadLine();
                while (respuesta != "s" && respuesta != "n")
                {
                    Console.WriteLine("Intente denuevo: s/n");
                    respuesta = Console.ReadLine();
                }
                while (respuesta == "n")
                {
                    Console.WriteLine("Capacidad: ");
                    comb.cap_combustible = int.Parse(Console.ReadLine());
                    Console.WriteLine("Durabilidad: ");
                    comb.dur_combustible = int.Parse(Console.ReadLine());
                    Console.WriteLine("s/n");
                    respuesta = Console.ReadLine();
                    /*Console.WriteLine("Hasta luego");
                    Console.ReadKey();
                    Environment.Exit(0);*/
                }
                if (respuesta == "s")
                    num1 = true;
            }
            Console.Clear();



            Console.WriteLine("Los datos de su parrilla son: ");
            Console.WriteLine("Marca: ");
            elec.mar_electrodomestico = Console.ReadLine();
            Console.WriteLine("Estado (1 / 10): ");
            elec.des_electrodomestico = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Los datos son: ");
            Console.WriteLine("Marca: " + elec.mar_electrodomestico);
            Console.WriteLine("Estado: " + elec.des_electrodomestico);
            Console.WriteLine("Desea prender la cocina?");
            Console.WriteLine("s/n");
            prender = Console.ReadLine();
            while (prender != "s" && prender != "n")
            {
                Console.WriteLine("Intente denuevo: s/n");
                prender = Console.ReadLine();
            }
            if (prender == "n")
            {
                Console.WriteLine("Usted decidio no prenderla");
                Console.WriteLine("Hasta luego");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Parrilla prendida!");
                Console.WriteLine("");
                num2 = true;
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Cuan desgastada esta la sarten?");
            ute.dur_utensilio_sarten = int.Parse(Console.ReadLine());
            if (ute.dur_utensilio_sarten >= 61 && ute.dur_utensilio_sarten <= 100)
            {
                Console.WriteLine("Su sarten esta en perfectas condiciones.");
            }
            if (ute.dur_utensilio_sarten >= 31 && ute.dur_utensilio_sarten <=60)
            {
                Console.WriteLine("Su sarten esta en condicione media. Se le puede pegar un poco el huevo.");
            }
            if (ute.dur_utensilio_sarten <=30)
            {
                Console.WriteLine("Su sarten no sirve. Compre una nueva.");
                Console.WriteLine("Hasta luego");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
                num3 = true;
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Cuanta mantequilla utilizara?");
            con.cant_condimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Desea utilizar esa cantidad?");
            Console.WriteLine("s/n");
            mante = Console.ReadLine();
            while (mante != "s" && mante != "n")
            {
                Console.WriteLine("Intente denuevo: s/n");
                respuesta = Console.ReadLine();
            }
            while (mante == "n")
            {
                Console.WriteLine("Cuanta mantequilla utilizara?");
                con.cant_condimento = int.Parse(Console.ReadLine());
                Console.WriteLine("Desea utilizar esa cantidad?");
                Console.WriteLine("s/n");
                mante = Console.ReadLine();
            }
            if (mante == "s")
                num4 = true;
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Cuantos huevos utilizara?");
            hue.can_huevo = int.Parse(Console.ReadLine());
            int gramos;
            gramos = hue.can_huevo * hue.peso_comida;
            Console.WriteLine("Usted consumira: " + gramos +" gramos");
            Console.WriteLine("Consumira esa cantidad?");
            Console.WriteLine("s/n");
            huevon = Console.ReadLine();
            while (huevon != "s" && huevon != "n")
            {
                Console.WriteLine("Intente denuevo: s/n");
                respuesta = Console.ReadLine();
            }
            while (huevon == "n")
            {
                Console.WriteLine("Cuantos huevos utilizara?");
                hue.can_huevo = int.Parse(Console.ReadLine());
                gramos = hue.can_huevo * hue.peso_comida;
                Console.WriteLine("Usted consumira: " + gramos + " gramos");
                Console.WriteLine("Consumira esa cantidad?");
                Console.WriteLine("s/n");
                huevon = Console.ReadLine();
            }
            if (huevon == "s")
                num5 = true;
            Console.ReadKey();
            Console.Clear();

            if (num1 == true && num2 == true && num3 == true && num4 == true && num5 == true)
            {
                Console.WriteLine("Su huevo frito esta listo.");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}


