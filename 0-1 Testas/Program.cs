using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_1_Testas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Programos tikslas:
            - Sukurti ir užpildyti duomenimis masyvą arba sąrašą. Atlikti reikiamus skaičiavimus. Bei išvesti gautus rezultatus.

            Reikalavimai:
            - Nenaudoti "greitųjų" radimo funkcijų. Tokių kaip .Min(), .Max()., Sum(), .Average() ar pan.

            Įgyvendinkite šį funkcionalumą:
            - Sukurkite masyvą arba sąrašą, kuriame saugotumėte dienų temperatūrų duomenis.
            - Liepkite vartotojui suvesti norimą kiekį duomenų į sukurtą masyvą arba sąrašą. Programos pradžioje paklauskite kiek dienų temperatūrų jis nori suvesti, 
            tuomet įvedinėjant išveskite kelintą reikšmę jis įvedinėja ir leiskite įvesti.
            - Išveskite temperatūrų duomenis, kiekvieną skaičių atskiriant kableliu, toje pačioje eilutėje.
            - Raskite ir išveskite ekrane šiuos atsakymus:
            -- Koks yra suvestų temperatūrų vidurkis?
            -- Kokia temperatūra yra žemiausia?
            -- Kurią dieną buvo aukščiausia temperatūra? Pavyzdžiui: "5-a dieną buvo aukščiausia temperatūra, kuri siekė 32 laipsnius".
            -- Kiek dienų temperatūra buvo žemesnė nei bendras visų dienų temperatūrų vidurkis?
            -- Pirmą ar paskutinę dieną temperatūra buvo aukštesnė ir koks skirtumas tarp jų?
            - Atrinkite į naują masyvą ar sąrašą tas temperatūras, kurios yra nutolusios nuo vidurkio tik per vieną padalą (tarkim vidurkis buvo 20, tai atrinkti temperatūras, 
            kurios pateko tarp [19-21]). Šį masyvą ar sąrašą išvesti ekrane.*/

            Console.Write("Iveskite norima skaiciu dienu, kuriu temperatura norite ivesti: ");
            var ats1 = Convert.ToInt32(Console.ReadLine());
            int[] temp1 = new int[ats1];
            for (int i = 0; i < temp1.Length; i++)
            {
                Console.Write("Iveskite {0}-osios dienos temperatura: ", i + 1);
                temp1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Jusu suvesti temperaturu duomenys: ");

            foreach (var t1 in temp1)
            {
                Console.Write(t1 + ",");
            }
            Console.WriteLine();
            int t1sum = 0;
            foreach (var t1 in temp1)
            {
                t1sum += t1;
            }
            Console.WriteLine("Jusu suvestu temperaturu vidurkis: " + (double)t1sum / ats1);
            int t1min = temp1[0];
            for (int i = 0; i < temp1.Length; i++)
            {
                if (t1min > temp1[i])
                {
                    t1min = temp1[i];
                }
            }
            Console.WriteLine("Zemiausia uzregistruota temperatura buvo: " + t1min);
            int t1max = temp1[0];
            int t1maxd = 1;
            for (int i = 0; i < temp1.Length; i++)
            {
                if (t1max < temp1[i])
                {
                    t1max = temp1[i];
                    t1maxd = i + 1;
                }
                if (i == temp1.Length - 1)
                {
                    Console.WriteLine("Uzfiksuota didziausia temperatura buvo {0} diena ir sieke {1} laipsnius.", t1maxd, t1max);
                }
            }
            int t1dmin = 0;
            double t1avg = t1sum / ats1;
            for (int i = 0; i < temp1.Length; i++)
            {
                if (temp1[i] < t1avg)
                {
                    t1dmin++;
                }
            }
            Console.WriteLine("{0} dienas temperatura buvo zemesne nei vidutine ({1} laipsniu) temperatura", t1dmin, (double)t1avg);
            if (temp1[0]>temp1[ats1-1])
            {
                Console.WriteLine("Pirmaja diena temperatura buvo aukstesne nei paskutine. Galbut ziema ne uz kalnu? :)");
            }
            else if (temp1[0] < temp1[ats1-1])
            {
                Console.WriteLine("Paskutine diena temperatura buvo aukstesne nei pirmaja. Galbut vasara ne uz kalnu? :)");
            }
            else
            {
                Console.WriteLine("Pirmaja ir paskutine diena temperaturos buvo vienodos.");
            }
            int t1skirt = temp1[0] - temp1[ats1-1];
            if (t1skirt<0)
            {
                t1skirt *= -1;
            }
            Console.WriteLine("Temperaturu skirtumas tarp pirmosios ir paskutines dienos yra {0} laipsniai", t1skirt);
            int masdyd1 = 0;
            for (int i = 0; i < temp1.Length; i++)
            {
                if (temp1[i]>=t1avg-1 && temp1[i]<=t1avg+1)
                {
                    masdyd1++;
                }
            }
            int[] temp2 = new int[masdyd1];
            int t2ind = 0;
            for (int i = 0; i < temp1.Length; i++)
            {
                if (temp1[i] >= t1avg - 1 && temp1[i] <= t1avg + 1)
                {
                    temp2[t2ind] = temp1[i];
                    t2ind++;
                }
            }
            Console.WriteLine("Nuo vidutines ({0} laipsniu) temperaturos per 1 laipsni temperatura skyresi {1} dienas. Zemiau pateikiami siu dienu temperaturu duomenys (is eiles):",t1avg,masdyd1);
            foreach (var t2 in temp2)
            {
                Console.Write(t2 + " ");
            }
            Console.WriteLine();
        }
    }
}
