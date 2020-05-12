
using System;
using System.Text.RegularExpressions;

namespace NJsonSchema.CodeGeneration.CSharp.Naming {

    /// <summary>Invalid Characters</summary>
    public static class InvalidCharacters {

        private static readonly Regex
            removals
                = new Regex( @"[\p{C}\p{Z}]+", RegexOptions.Compiled );

        private static readonly Regex
            replacements
                = new Regex( @"[\p{P}\p{S}]+", RegexOptions.Compiled );


        /// <summary>Removes and replaces invalid characters</summary>
        public static String
            RemoveAndReplace
        (
            String
                value
        ) {
            value = removals.Replace( value, String.Empty );
            value = replacements.Replace( value, "_" );
            return value;
        }

    }

}
