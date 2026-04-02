using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// An HTML CSS keyword set in .NET enumeration form
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public sealed partial class TextTransformKeyword
{
    /// <summary>
    /// Converts all text to lowercase.
    /// </summary>
    public static readonly TextTransformKeyword Lowercase = new("lowercase");

    /// <summary>
    /// Converts all text to uppercase.
    /// </summary>
    public static readonly TextTransformKeyword Uppercase = new("uppercase");

    /// <summary>
    /// Capitalizes the first letter of each word.
    /// </summary>
    public static readonly TextTransformKeyword Capitalize = new("capitalize");
}
