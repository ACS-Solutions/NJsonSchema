
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NJsonSchema.CodeGeneration.CSharp.Naming {

    class NonCasingTypeNameGenerator
        : ITypeNameGenerator
    {

        public String
            Generate
        (
            JsonSchema
                schema,
            String
                type_name_hint,
            IEnumerable<String>
                reserved_type_names
        ) {
            var name = type_name_hint;
            if (String.IsNullOrWhiteSpace( name ) && schema.HasTypeNameTitle)
                name = schema.Title;
            if (String.IsNullOrWhiteSpace( name ) && !String.IsNullOrWhiteSpace( schema.DocumentPath ))
                name = Path.GetFileNameWithoutExtension( schema.DocumentPath );

            name = InvalidCharacters.RemoveAndReplace( name );

            var start = name;
            var suffix = 1;
            while (reserved_type_names.Contains( name ))
                name = start + suffix++;

            return name;
        }

    }

}
