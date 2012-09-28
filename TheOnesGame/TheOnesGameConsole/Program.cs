using System;
using TheOnesGame;

namespace TheOnesGameConsole
{
    public class Program
    {
        public static void Main()
        {
            var edge = new Edge();
            edge.SetPosition(1, new UserStory(2));

            DrawEdge(edge);
            AskPlayerToMove();
            DrawEdge(edge);

            Console.ReadKey();
        }

        private static void AskPlayerToMove()
        {
            Console.ReadLine();
        }

        private static void DrawEdge(Edge edge)
        {
            const int numberOfPositions = 5;

            for(var positionCount = 1; positionCount <= numberOfPositions; positionCount++)
            {
                var story = edge.GetStoryOnPosition(positionCount);
                Console.Write("{0}:{1}|", positionCount, GetStoryText(story));
            }

            Console.WriteLine("Complete:" + GetStoryText(edge.CompleteStory));
        }

        private static string GetStoryText(UserStory story)
        {
            return story == null ? "X" : "O";
        }
    }
}
