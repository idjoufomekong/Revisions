using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_d_un_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab = { "vert", "bleu", "rouge", "jaune" }; // { "seize", "un", "trois", "douze" };//{ "vert","bleu", "rouge", "jaune"}; //;
            AffichTab(tab);

            string[] tableauTrie;
            tableauTrie = TrieTableau(tab);
            AffichTab(tab);

            Console.ReadKey();


        }

        static void AffichTab(string[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
                Console.Write(tab[i] + "; ");
        }

        static string[] TrieTableau(string[] tab)
        {
            string perm;
            bool auMoinsUnePermut = true;
            string[] result = new string[tab.Length];
            result = tab;

            //while (auMoinsUnePermut)
            //{
            //    auMoinsUnePermut = false;
            //    for (int i = 0; i < tab.Length - 1; i++)
            //    {

            //        if (tab[i].CompareTo(tab[i + 1]) > 0)
            //        {
            //            perm = tab[i];
            //            tab[i] = tab[i + 1];
            //            tab[i + 1] = perm;
            //            auMoinsUnePermut = true;
            //        }


            //    }

            //}

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i].CompareTo(result[j]) > 0)
                    {
                        perm = result[i];
                        result[i] = result[j];
                        result[j] = perm;
                        //auMoinsUnePermut = true;
                    }
                }

            }

            return result;
        }
    }
}




