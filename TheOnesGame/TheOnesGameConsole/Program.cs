using System;
using TheOnesGame;
using System.Linq;

namespace TheOnesGameConsole
{
    public class Program
    {
        public static void Main()
        {
            var edge = new Edge();
            edge.SetPosition(1, new UserStory(2));
            edge.SetPosition(3, new UserStory(5));

            DrawEdge(edge);
            string input = AskPlayerToMove();
            var positionToMovefrom = Convert.ToInt32(input.Last() - '0');
            edge.MoveStoryOn(positionToMovefrom);
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
            DrawEdgeLabelRow(numberOfPositions);
            DrawEdgeData(edge, numberOfPositions);
        }

        private static void DrawEdgeData(Edge edge, int numberOfPositions)
        {
            for (var positionCount = 1; positionCount <= numberOfPositions; positionCount++)
            {
                var story = edge.GetStoryOnPosition(positionCount);

                Console.Write(" {0} ", GetStoryText(story));
            }
            Console.Write(" {0} ", GetStoryText(edge.CompleteStory));
            Console.WriteLine();
        }

        private static void DrawEdgeLabelRow(int numberOfPositions)
        {
           
            for (var positionCount = 1; positionCount <= numberOfPositions; positionCount++)
            {
                Console.Write(" {0} ", positionCount);
            }
            Console.Write(" Done ");
            Console.WriteLine();
        }

        private static string GetStoryText(UserStory story)
        {
            return story == null ? "-" : story.StoryPoint.ToString();
        }
    }
}
