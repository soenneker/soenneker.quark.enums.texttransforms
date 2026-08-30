[![](https://img.shields.io/nuget/v/soenneker.quark.enums.texttransforms.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.texttransforms/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.texttransforms/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.texttransforms/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.texttransforms/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.texttransforms/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.texttransforms.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.texttransforms/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.texttransforms/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.texttransforms/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.TextTransforms

Strongly typed text-transform tokens for Quark components and styles.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.TextTransforms
```

## Usage

```csharp
TextTransformEnum transform = TextTransformEnum.Uppercase;
string value = transform.Value; // "uppercase"
```

Each emitted string works as both a CSS `text-transform` value and the corresponding Tailwind utility class name.

## Values

| Member | Value | Effect |
| --- | --- | --- |
| `Lowercase` | `lowercase` | Displays letters in lowercase. |
| `Uppercase` | `uppercase` | Displays letters in uppercase. |
| `Capitalize` | `capitalize` | Capitalizes the first letter of each word. |

Text transformation changes presentation, not the underlying string. Apply it only where that distinction is appropriate for copying, searching, and accessibility.
