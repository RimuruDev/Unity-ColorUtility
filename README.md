[English](README.md) | [Русский](README_RU.md)

# ColorUtility for Unity

## Description
ColorUtility is a compact and efficient class designed for working with colors in Unity. It facilitates easy conversion of hexadecimal color codes (in RRGGBB format) to Unity `Color` objects. This tool is particularly useful when working with color values obtained from external sources, such as web APIs, user interfaces, or text files.

## Features
- Simple conversion of hexadecimal color codes to Unity `Color` objects.
- Verification of input format correctness to enhance error resilience.
- Easily integrates into any Unity project.

## Installation
To use `ColorUtility`, copy the `ColorUtility.cs` file into the `Scripts` or `Codebase` folder of your Unity project. Alternatively, you can download the ready-made `.package` in the Releases section.

## Usage Examples

### Converting a Hexadecimal String to a Color
```csharp
Color color = ColorUtility.HexToColor("FF5733");
```

This code converts the string "FF5733" into a Unity Color object, which can now be used for setting colors in your game or application.

## Handling Incorrect Input Data
If the passed string is incorrectly formatted, ColorUtility will return a white color and issue a warning in the Unity console.
```csharp
Color color = ColorUtility.HexToColor("IncorrectFormat"); // Returns Color.white
```
## Contributing to the Project
Suggestions for improvement or feedback are welcome! If you have ideas to enhance ColorUtility, feel free to create a pull request or issue in the GitHub repository.

- Telegram channel - https://t.me/DevLogUnity
- Chat in Telegram - https://t.me/DevLogUnity3d

License This project is distributed under the MIT License. See the LICENSE file for more details.

Author: RimuruDev