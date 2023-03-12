using Pattern.src;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = new BuilderExercise("Person");
        builder.AddField(Accessor.Private, "int", "UserName")
        .AddField(Accessor.Protected, "string", "Email");
        Console.WriteLine(builder);
    }
}