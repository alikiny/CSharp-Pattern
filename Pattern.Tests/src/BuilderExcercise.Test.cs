using Pattern.src;

namespace Pattern.Tests.src
{
    [Collection("MyTestCollection")]
    public class BuilderExcerciseTest
    {
        [Fact]
        public void EmptyClassTest()
        {
            var builder = new BuilderExercise("Foo");
            Assert.True(builder.ToString().Equals("public class Foo\n{\n}\n"));
        }

        [Fact]
        public void FullClassTest()
        {
            var builder = new BuilderExercise("Foo");
            var output =  "public class Foo\n{\n" + 
                "  public int Age;\n" +
                "  private string Name;\n" +
                "}\n";
            builder
                .AddField(Accessor.Public, "int", "Age")
                .AddField(Accessor.Private, "string", "Name");
            Assert.True(builder.ToString().Equals(output));
        }
    }
}
