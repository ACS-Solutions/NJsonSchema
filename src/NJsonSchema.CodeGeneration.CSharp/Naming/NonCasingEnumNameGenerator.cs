
using System;

namespace NJsonSchema.CodeGeneration.CSharp.Naming {

    class NonCasingEnumNameGenerator
        : IEnumNameGenerator
    {

        public String
            Generate
        (
            Int32
                index,
            String
                name,
            Object
                value,
            JsonSchema
                schema
        )
            => InvalidCharacters.RemoveAndReplace( name );

    }

}
