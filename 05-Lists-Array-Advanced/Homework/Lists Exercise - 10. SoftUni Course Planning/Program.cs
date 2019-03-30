using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exercise___10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessonsSchedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "course start")
                {
                    break;
                }

                string[] tokens = input.Split(':');

                if (tokens[0] == "Add")
                {
                    AddInTheSchedule(lessonsSchedule, tokens);
                }
                if (tokens[0] == "Insert")
                {
                    InsertLesson(lessonsSchedule, tokens);
                }
                if (tokens[0] == "Remove")
                {
                    RemoveFromSchedule(lessonsSchedule, tokens);
                }
                if (tokens[0] == "Swap")
                {
                    SwapTwoLessonsInTheSchedule(lessonsSchedule, tokens);
                }
                if (tokens[0] == "Exercise")
                {
                    AddExercise(lessonsSchedule, tokens);
                }

            }

            for (int i = 0; i < lessonsSchedule.Count; i++)
            {
                Console.WriteLine($"{i+1}.{lessonsSchedule[i]}");
            }
        }

        private static void AddExercise(List<string> lessonsSchedule, string[] tokens)
        {
            string exerciseName = tokens[1];

            bool doesLessonExist = lessonsSchedule.Contains(exerciseName);
            bool doesExerciseExist = lessonsSchedule.Contains($"{exerciseName}-Exercise");


            if (doesLessonExist == true && doesExerciseExist == false)
            {
                int indexOfLesson = lessonsSchedule.IndexOf(exerciseName);

                lessonsSchedule.Insert(indexOfLesson, $"{exerciseName}-Exercise");
            }
            else if (doesLessonExist == false && doesExerciseExist == false)
            {
                lessonsSchedule.Add(exerciseName);

                lessonsSchedule.Add($"{exerciseName}-Exercise");
            }
        }

        private static void SwapTwoLessonsInTheSchedule(List<string> lessonsSchedule, string[] tokens)
        {
            string firstLessonTitle = tokens[1];
            string secondLessonTitle = tokens[2];

            bool doesFirstLessonExist = lessonsSchedule.Contains(firstLessonTitle);
            bool doesSecondLessonExist = lessonsSchedule.Contains(secondLessonTitle);

            bool doesFirstLessonHasExercise = false;
            if (doesFirstLessonExist == true)
            {
                int indexOfFirstLesson = lessonsSchedule.IndexOf(firstLessonTitle);
                if (lessonsSchedule.Contains($"{firstLessonTitle}-Exercise"))
                {
                    doesFirstLessonHasExercise = true;
                }
            }

            bool doesSecondLessonHasExercise = false;
            if (doesSecondLessonExist == true)
            {
                int indexOfSecondLesson = lessonsSchedule.IndexOf(secondLessonTitle);
                if (lessonsSchedule.Contains( $"{secondLessonTitle}-Exercise"))
                {
                    doesFirstLessonHasExercise = true;
                }
            }

            if (doesFirstLessonExist && doesSecondLessonExist)
            {
                int indexOfFirstLesson = lessonsSchedule.IndexOf(firstLessonTitle);
                int indexOfSecondLesson = lessonsSchedule.IndexOf(secondLessonTitle);

                lessonsSchedule.Remove(firstLessonTitle);
                lessonsSchedule.RemoveAt(indexOfFirstLesson + 1);
                lessonsSchedule.Remove(secondLessonTitle);
                lessonsSchedule.RemoveAt(indexOfSecondLesson + 1);

                lessonsSchedule.Insert(indexOfFirstLesson, secondLessonTitle);
                lessonsSchedule.Insert(indexOfFirstLesson + 1, $"{secondLessonTitle}-Exercise");
                lessonsSchedule.Insert(indexOfSecondLesson, firstLessonTitle);
                lessonsSchedule.Insert(indexOfSecondLesson + 1, $"{firstLessonTitle}-Exercise");


            }
        }

        private static void RemoveFromSchedule(List<string> lessonsSchedule, string[] tokens)
        {
            string lessonTitle = tokens[1];

            bool doesLessonIsInSchedule = lessonsSchedule.Contains(lessonTitle);

            if (doesLessonIsInSchedule == true)
            {
                int indexOfLesson = lessonsSchedule.IndexOf(lessonTitle);
                if (lessonsSchedule.Contains( $"{lessonTitle}-Exercise"))
                {
                    lessonsSchedule.RemoveAt(indexOfLesson + 1);
                }
            }

            if (doesLessonIsInSchedule == true)
            {
                lessonsSchedule.Remove(lessonTitle);
            }
        }

        private static void InsertLesson(List<string> lessonsSchedule, string[] tokens)
        {
            string lessonTitle = tokens[1];
            int index = int.Parse(tokens[2]);

            bool doesLessonIsInSchedule = lessonsSchedule.Contains(lessonTitle);

            if (doesLessonIsInSchedule == false)
            {
                lessonsSchedule.Insert(index, lessonTitle);
            }
        }

        private static void AddInTheSchedule(List<string> lessonsSchedule, string[] tokens)
        {
            string lessonToAdd = tokens[1];

            bool doesLessonIsInSchedule = lessonsSchedule.Contains(lessonToAdd);

            if (doesLessonIsInSchedule == false)
            {
                lessonsSchedule.Add(lessonToAdd);
            }
        }
    }
}
