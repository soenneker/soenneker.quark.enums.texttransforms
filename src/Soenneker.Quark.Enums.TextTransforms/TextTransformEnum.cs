using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents a text-transform token used by Quark styles.
/// </summary>
[EnumValue<string>]
public sealed partial class TextTransformEnum
{
    /// <summary>
    /// Displays letters in lowercase.
    /// </summary>
    public static readonly TextTransformEnum Lowercase = new("lowercase");
    /// <summary>
    /// Displays letters in uppercase.
    /// </summary>
    public static readonly TextTransformEnum Uppercase = new("uppercase");
    /// <summary>
    /// Capitalizes the first letter of each word.
    /// </summary>
    public static readonly TextTransformEnum Capitalize = new("capitalize");
}
