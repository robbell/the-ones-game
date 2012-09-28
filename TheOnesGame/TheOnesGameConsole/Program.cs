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
            string input = AskPlayerToMove();
            edge.MoveStoryOn(1);
            DrawEdge(edge);

            Console.ReadKey();
        }

        private static string AskPlayerToMove()
        {
            Console.WriteLine("Please choose user story to move:");
            return Console.ReadLine();

        }

        private static void DrawEdge(Edge edge)
        {
            const int numberOfPositions = 5;
            for(var positionCount = 1; positionCount <= numberOfPositions -1 ; positionCount++)
            {
                Console.Write("| {0} |", positionCount);    
            }
                Console.WriteLine();
            for(var positionCount = 1; positionCount <= numberOfPositions -1 ; positionCount++)
            {
                var story = edge.GetStoryOnPosition(positionCount);
              
                Console.Write("| {0} |", GetStoryText(story));    
            }
            Console.WriteLine();

        }

        private static string GetStoryText(UserStory story)
        {
            return story == null ? "-" : "O";
        }
    }
}
