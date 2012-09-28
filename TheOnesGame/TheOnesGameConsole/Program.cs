using System;
using TheOnesGame;

namespace TheOnesGameConsole
{
    public class Program
    {
        public static void Main()
        {
            var edge = GetStartingEdge();
            DrawEdge(edge);

            var input = AskPlayerToMove();
            var positionToMovefrom = OnesLib.ParsePositionToMoveFrom(input);

            edge.MoveStoryOn(positionToMovefrom);
            DrawEdge(edge);

            Console.ReadKey();
        }

        private static Edge GetStartingEdge()
        {
            var edge = new Edge();
            edge.SetPosition(1, new UserStory(2));
            edge.SetPosition(3, new UserStory(5));
            return edge;
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

                Console.Write(" {0} ", OnesLib.GetStoryText(story));
            }
            Console.Write(" {0} ", OnesLib.GetStoryText(edge.CompleteStory));
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
    }
}
