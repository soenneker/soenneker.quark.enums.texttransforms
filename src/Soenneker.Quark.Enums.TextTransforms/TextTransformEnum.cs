using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class TextTransformEnum
{
    public static readonly TextTransformEnum Lowercase = new("lowercase");
    public static readonly TextTransformEnum Uppercase = new("uppercase");
    public static readonly TextTransformEnum Capitalize = new("capitalize");
}