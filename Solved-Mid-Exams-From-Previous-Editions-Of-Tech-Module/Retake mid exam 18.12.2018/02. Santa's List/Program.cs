using System;
using System.Collections.Generic;
using System.Linq;

namespace Mid_Exam___02._Santa_s_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kidsNamesList = Console.ReadLine()
                .Split("&")
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Finished!")
                {
                    break;
                }

                string[] tokens = input.Split(' ');

                if (tokens[0] == "Bad")
                {
                    BadKidAdder(kidsNamesList, tokens);
                }

                if (tokens[0] == "Good")
                {
                    GoodKidRemover(kidsNamesList, tokens);
                }

                if (tokens[0] == "Rename")
                {
                    KidRenamer(kidsNamesList, tokens);
                }

                if (tokens[0] == "Rearrange")
                {
                    KidRearranger(kidsNamesList, tokens);
                }
                
            }

            Console.WriteLine(string.Join(", ", kidsNamesList));

        }

        private static void KidRearranger(List<string> kidsNamesList, string[] tokens)
        {
            string kidName = tokens[1];

            bool doesKidExist = false;

            for (int i = 0; i < kidsNamesList.Count; i++)
            {
                string currentKid = kidsNamesList[i];

                if (currentKid == kidName)
                {
                    doesKidExist = true;
                }
            }

            if (doesKidExist == true)
            {
                kidsNamesList.Remove(kidName);
                kidsNamesList.Add(kidName);
            }
        }

        private static void KidRenamer(List<string> kidsNamesList, string[] tokens)
        {
            string kidOldName = tokens[1];
            string kidNewName = tokens[2];

            bool doesKidExist = false;
            int currentKidIndex = 0;

            for (int i = 0; i < kidsNamesList.Count; i++)
            {
                string currentKid = kidsNamesList[i];

                if (currentKid == kidOldName)
                {
                    doesKidExist = true;
                    currentKidIndex = i;
                }
            }

            if (doesKidExist == true)
            {
                kidsNamesList.RemoveAt(currentKidIndex);
                kidsNamesList.Insert(currentKidIndex, kidNewName);
            }
        }

        static void GoodKidRemover(List<string> kidsNamesList, string[] tokens)
        {
            string kidName = tokens[1];

            bool doesKidExist = false;

            for (int i = 0; i < kidsNamesList.Count; i++)
            {
                string currentKid = kidsNamesList[i];

                if (currentKid == kidName)
                {
                    doesKidExist = true;
                }
            }

            if (doesKidExist == true)
            {
                kidsNamesList.Remove(kidName);
            }
        }

        private static void BadKidAdder(List<string> kidsNamesList, string[] tokens)
        {
            string kidName = tokens[1];

            bool doesExist = false;

            for (int i = 0; i < kidsNamesList.Count; i++)
            {
                string currentKid = kidsNamesList[i];

                if (currentKid == kidName)
                {
                    doesExist = true;
                }
            }

            if (doesExist == false)
            {
                kidsNamesList.Insert(0, kidName);
            }
        }
    }
}
