using Lab03;


namespace Lab03_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Challenge1Test()
        {
            string input = "4 8 15";
            Assert.Equal(480, Program.Challenge1(input));
        }


        [Fact]
        public void Challenge2_GetAverage_Test()
        {
            int[] inputRange = new int[] {2, 4, 6, 8 }; // Test input
            double expectedAverage = (2 + 4 + 6 + 8) / 4; // Expected average for the test input

            double result = Program.Challenge2_GetAverage(inputRange);
            Assert.Equal(expectedAverage, result);
        }


        [Fact]
        public void Challenge4Test() 
        {
            int[] input = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            Assert.Equal(1, Program.Challenge4(input));
        }

        [Fact]
        public void Challenge5Test() 
        {
            int[] input = { 5, 25, 99, 123, 78, 96, 555, 108, 4 };
            Assert.Equal(555, Program.Challenge5(input));
        }
 
        [Fact]
        public void Challenge9Test() 
        {
        
        }
    }
}