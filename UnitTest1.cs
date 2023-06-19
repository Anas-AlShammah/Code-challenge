
namespace Class03.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1 2 3", 6)]
        [InlineData("5 2 9", 90)]
        [InlineData("5 9", 0)]
        [InlineData("-1 2 3", -6)]
        public void TestProductOfThreeNumbers(string input, int expectedOutput)
        {
            // Arrange
            var consoleOutput = new System.IO.StringWriter();
            System.Console.SetOut(consoleOutput);
            System.Console.SetIn(new System.IO.StringReader(input));

            // Act
            var res = Program.product3Number();

            // Assert

            Assert.Equal(expectedOutput, res);
        }
        [Theory]
        [InlineData("4\n1\n2\n3\n4\n", 2)]
        [InlineData("5\n2\n4\n6\n8\n10\n", 6)]
        [InlineData("3\n0\n0\n0\n", 0)]
        [InlineData("6\n0\n0\n0\n0\n0\n0\n", 0)]
        // Add more test cases as needed

        public void TestAvg(string input, int expectedOutput)
        {
            // Arrange
            var consoleOutput = new System.IO.StringWriter();
            System.Console.SetOut(consoleOutput);
            System.Console.SetIn(new System.IO.StringReader(input));

            // Act & Assert

            Assert.Equal(expectedOutput, Program.AvgNumber());
        }
        [Theory]
        [InlineData(new[] { 1, 2, 3, 5,5 },5)]
        [InlineData(new[] { 1, 1, 1, 1 }, 1)]
        [InlineData(new[] { 2, 2, 2, 2, 2 }, 2)]
        [InlineData(new[] { 3, 3, 3, 3, 3, 3 }, 3)]
        [InlineData(new[] { 4, 4, 4, 4, 4, 4, 4 }, 4)]
        [InlineData(new[] { 5 }, 5)]
        [InlineData(new[] { 6, 6 }, 6)]
        [InlineData(new[] { 7, 7, 7 }, 7)]
        [InlineData(new[] { 8, 8, 8, 8 }, 8)]
        [InlineData(new[] { 9, 9, 9, 9, 9, 9, 9, 9 }, 9)]
        [InlineData(new[] { 10, 10, 20, 20, 30, 30, 40, 40, 50, 50 }, 10)]
        public void TestArrayNum(int[] arr, int expections)
        {
            Assert.Equal(expections, Program.ArrayNum(arr));
        }
        [Theory]
        [InlineData(new[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 }, 555)]
        [InlineData(new[] { -5, -1, -300 }, -1)]
        [InlineData(new[] { 7, 7, 7 }, 7)]
        public void TestArrayMax(int[] arr, int expections)
        {
            Assert.Equal(expections, Program.ArrayMax(arr));
        }
        [Theory]
        [InlineData("This is a sentance about important things", new[] { "this: 4", "is: 2", "a: 1", "sentance: 8", "about: 5", "important: 9", "things: 6" })]
        public void TestSentenceLength(string sentence, string[] expected)
        {
            // Act
            var consoleOutput = new System.IO.StringWriter();
            System.Console.SetOut(consoleOutput);
            System.Console.SetIn(new System.IO.StringReader(sentence));
            string[] result = Program.SentenceLength();

            // Assert
            Assert.Equal(expected, result);
        }
        

        [Theory]
        [InlineData("Hello, world!", new[] { "hello,: 6", "world!: 6" })]
        [InlineData("I love coding.", new[] { "i: 1", "love: 4", "coding.: 7" })]
        [InlineData("Testing; 1, 2, 3.", new[] { "testing;: 8", "1,: 2", "2,: 2", "3.: 2" })]
        public void TestSentenceLength_WithDifferentSentences(string sentence, string[] expected)
        {
            // Arrange
            var consoleOutput = new System.IO.StringWriter();
            System.Console.SetOut(consoleOutput);
            System.Console.SetIn(new System.IO.StringReader(sentence));

            // Act
            string[] result = Program.SentenceLength();

            // Assert
            Assert.Equal(expected, result);
        }
    }

}