
using System;

namespace NJsonSchema.CodeGeneration.CSharp.Naming {

    class NonCasingPropertyNameGenerator
        : IPropertyNameGenerator
    {

        public String
            Generate
        (
            JsonSchemaProperty
                property
        )
            => InvalidCharacters.RemoveAndReplace( property.Name );

    }

}
