using static System.Console;
using Pattern.src;

namespace Pattern.Tests.src
{
    public class BuilderExcerciseTest
    {
        [Fact]
        public void EmptyClassTest()
        {
            var builder = new BuilderExercise("Foo");
            Assert.True(builder.ToString().Equals("public class Foo\n{\n}\n"));
        }
    }
}