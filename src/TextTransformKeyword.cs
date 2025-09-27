using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An HTML CSS keyword set in .NET enumeration form
/// </summary>
[Intellenum<string>]
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

    public static implicit operator TextTransformKeyword(GlobalKeyword style) => new(style.Value);
}
