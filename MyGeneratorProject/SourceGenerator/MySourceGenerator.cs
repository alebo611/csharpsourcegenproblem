using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace genNamespace
{
    [Generator]
    public class Generator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
        }
        public void Execute(GeneratorExecutionContext context)
        {
            string generatedCode = @"

                public class Car : Vehicle {

                    
                }
			    
			";
			
			context.AddSource("generated", generatedCode);
        }
    }
}
