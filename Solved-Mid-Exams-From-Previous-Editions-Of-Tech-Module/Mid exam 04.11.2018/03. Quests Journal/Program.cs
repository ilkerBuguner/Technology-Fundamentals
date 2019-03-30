using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Exam___03._Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> quests = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Retire!")
                {
                    break;
                }

                string[] tokens = input.Split(" - ");

                if (tokens[0] == "Start")
                {
                    QuestAdder(quests, tokens);
                }

                if (tokens[0] == "Complete")
                {
                    QuestRemover(quests, tokens);
                }

                if (tokens[0] == "Side Quest")
                {
                    SideQuestAdder(quests, tokens);

                }

                if (tokens[0] == "Renew")
                {
                    string questToRenew = tokens[1];

                    if (quests.Contains(questToRenew))
                    {
                        quests.Remove(questToRenew);

                        quests.Add(questToRenew);
                    }
                }
                
            }

            Console.WriteLine(string.Join(", ", quests));

        }

        private static void SideQuestAdder(List<string> quests, string[] tokens)
        {
            string[] questAndSideQuestTaker = tokens[1].Split(':', StringSplitOptions.RemoveEmptyEntries);
            string quest = questAndSideQuestTaker[0];
            string SideQuest = questAndSideQuestTaker[1];


            //if (quests.Contains(quest))
            //{
            //    int indexOfTheQuest = quests.IndexOf(quest);

            //    if (!quest.Contains(SideQuest))
            //    {
            //        quests.Insert(indexOfTheQuest + 1, SideQuest);
            //    }
            //}

            if (quests.Contains(questAndSideQuestTaker[0]) && !quests.Contains(questAndSideQuestTaker[1]))
            {
                int index = quests.FindIndex(x => x == questAndSideQuestTaker[0]);
                quests.Insert(index + 1, questAndSideQuestTaker[1]);
            }
        }

        private static void QuestRemover(List<string> quests, string[] tokens)
        {
            string questToRemove = tokens[1];

            if (quests.Contains(questToRemove))
            {
                quests.Remove(questToRemove);
            }
        }

        private static void QuestAdder(List<string> quests, string[] tokens)
        {
            string questToAdd = tokens[1];

            if (!quests.Contains(questToAdd))
            {
                quests.Add(questToAdd);
            }
        }
    }
}
