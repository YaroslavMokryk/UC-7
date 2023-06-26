using Xunit;

namespace UC_7.Tests
{
    public class PlayerAnalyzerTests
    {
        [Fact]
        public void CalculateScore_NormalPlayer_ReturnsExpectedScore()
        {
            // Arrange
            var playerAnalyzer = new PlayerAnalyzer();
            var players = new List<Player>
            {
                new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } }
            };

            // Act
            var result = playerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(250, result);
        }

        [Fact]
        public void CalculateScore_JuniorPlayer_ReturnsExpectedScore()
        {
            // Arrange
            var playerAnalyzer = new PlayerAnalyzer();
            var players = new List<Player>
            {
                new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } }
            };

            // Act
            var result = playerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(67.5, result);
        }

        [Fact]
        public void CalculateScore_SeniorPlayer_ReturnsExpectedScore()
        {
            // Arrange
            var playerAnalyzer = new PlayerAnalyzer();
            var players = new List<Player>
            {
                new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } }
            };

            // Act
            var result = playerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(2520, result);
        }

        [Fact]
        public void CalculateScore_MultiplePlayers_ReturnsExpectedScore()
        {
            // Arrange
            var playerAnalyzer = new PlayerAnalyzer();
            var players = new List<Player>
            {
                new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } },
                new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } },
                new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } }
            };

            // Act
            var result = playerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(250 + 67.5 + 2520, result);
        }

        [Fact]
        public void CalculateScore_SkillsIsNull_ThrowsException()
        {
            // Arrange
            var playerAnalyzer = new PlayerAnalyzer();
            var players = new List<Player>
            {
                new Player { Age = 25, Experience = 5, Skills = null }
            };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => playerAnalyzer.CalculateScore(players));
        }

        [Fact]
        public void CalculateScore_EmptyArray_ReturnsZero()
        {
            // Arrange
            var playerAnalyzer = new PlayerAnalyzer();
            var players = new List<Player>();

            // Act
            var result = playerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(0, result);
        }
    }
}
