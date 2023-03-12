/* 
Builder Coding Exercise
Implement the Builder design pattern for rendering simple chunks of code.

Sample use of the builder:

var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
Console.WriteLine(cb);
The expected output of the above code is:

public class Person
{
  public string Name;
  public int Age;
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.src
{
    public enum Accessor
    {
        Public,
        Private,
        Protected
    }

    public class Property
    {
        private readonly string _name;
        private readonly string _type;
        private readonly Accessor _accessor;
        public Property(Accessor accessor, string type, string name)
        {
            _name = name;
            _accessor = accessor;
            _type = type; 
        }
        public override string ToString()
        {
            return $"{_accessor.ToString().ToLower()} {_type} {_name};";
        }
    
    }

    public class BuilderExercise
    {
        private List<Property> _properties = new();
        private readonly string _name;
        public BuilderExercise(string name)
        {
            _name = name;  
        }
        public BuilderExercise AddField(Accessor accessor, string type, string name)
        {
            _properties.Add(new Property(accessor, type, name));
            return this;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {_name}")
            .AppendLine("{");
            foreach (var item in _properties)
            {
                sb.AppendLine($"  {item}");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}