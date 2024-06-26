using System.Numerics;

namespace Roll_the_Die
{
    public class RollTheDieTests
    {
        [Fact]
        public void RollDie()
        {
            var player = new Player();
            for (var i = 0; i < 100; i++)
            {
                Assert.InRange(player.RollDie(), 1, 18);
            }
        }

        [Fact]
        public void GenerateSpellStrength()
        {
            var player = new Player();
            var strength = player.GenerateSpellStrength();
            Assert.InRange(strength, 0.0, 100.0);
        }
    }
}