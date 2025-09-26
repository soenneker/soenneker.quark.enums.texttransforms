using Intellenum;

namespace Soenneker.Quark;

/// <summary>
/// An HTML CSS keyword set in .NET enumeration form
/// </summary>
[Intellenum<string>]
public sealed partial class TextTransform
{
    /// <summary>
    /// Converts all text to lowercase.
    /// </summary>
    public static readonly TextTransform Lowercase = new("lowercase");

    /// <summary>
    /// Converts all text to uppercase.
    /// </summary>
    public static readonly TextTransform Uppercase = new("uppercase");

    /// <summary>
    /// Capitalizes the first letter of each word.
    /// </summary>
    public static readonly TextTransform Capitalize = new("capitalize");

    public static implicit operator TextTransform(GlobalKeyword style) => new(style.Value);
}
