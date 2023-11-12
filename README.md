[English](README.md) | [Русский](README_RU.md)

<p align="center"><h1>⭐ColorUtility for Unity⭐</h1></p>
 <p align="center">
  <a>
    <img alt="Made With Unity" src="https://img.shields.io/badge/made%20with-Unity-57b9d3.svg?logo=Unity">
  </a>
  <a>
  <img alt="License" src="https://img.shields.io/github/license/RimuruDev/Unity-ColorUtility?logo=github">
  </a>
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/RimuruDev/Unity-ColorUtility?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/RimuruDev/Unity-ColorUtility?logo=VirtualBox">
  </a>
  <a>
    <img alt="Downloads" src="https://img.shields.io/github/downloads/RimuruDev/Unity-ColorUtility/total?color=brightgreen">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/RimuruDev/Unity-ColorUtility?include_prereleases&logo=Dropbox&color=yellow">
  </a>
  <a>
    <img alt="GitHub stars" src="https://img.shields.io/github/stars/RimuruDev/Unity-ColorUtility?branch=main&label=Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="GitHub user stars" src="https://img.shields.io/github/stars/RimuruDev?affiliations=OWNER&branch=main&label=User%20Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="" src="https://img.shields.io/github/watchers/RimuruDev/Unity-ColorUtility?style=flat">
  </a>
</p>


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
