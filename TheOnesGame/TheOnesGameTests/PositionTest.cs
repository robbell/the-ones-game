using NUnit.Framework;

namespace TheOnesGameTests
{
 
    [TestFixture]
    public class PositionTest
    {
        [Test]
        public void position_Initially_has_no_user_stories()
        {
            var position1 = new Position("1");

            Assert.AreEqual(0, position1.UserStories.Count);

        }
    }
}