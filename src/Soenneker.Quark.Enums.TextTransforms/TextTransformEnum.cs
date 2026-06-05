using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the text transform enum.
/// </summary>
[EnumValue<string>]
public sealed partial class TextTransformEnum
{
    /// <summary>
    /// The lowercase.
    /// </summary>
    public static readonly TextTransformEnum Lowercase = new("lowercase");
    /// <summary>
    /// The uppercase.
    /// </summary>
    public static readonly TextTransformEnum Uppercase = new("uppercase");
    /// <summary>
    /// The capitalize.
    /// </summary>
    public static readonly TextTransformEnum Capitalize = new("capitalize");
}