// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - GitHub:   https://github.com/RimuruDev
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//          - GitHub Organizations: https://github.com/Rimuru-Dev
//
// **************************************************************** //

using System;
using UnityEngine;

namespace External.RimuruDevUtils.Helpers.Colors
{
    /// <summary>
    /// Provides utility methods for working with colors in Unity.
    /// This class handles conversion from hexadecimal color strings to Unity's Color objects.
    /// </summary>
    public static class ColorUtility
    {
        private const byte AlphaFull = 255;
        private const int HexadecimalMaxLength = 6;
        private const int DecimalNumberBase = 16;

        /// <summary>
        /// Converts a hexadecimal color string to a Color object.
        /// </summary>
        /// <param name="hex">Hexadecimal string representing the color in RRGGBB format.</param>
        /// <returns>A Color object corresponding to the hexadecimal input. Returns white color if format is incorrect.</returns>
        /// <example>
        /// <code>
        /// Color myColor = ColorUtility.HexToColor("FF5733");
        /// </code>
        /// </example>
        public static Color HexToColor(string hex)
        {
            if (string.IsNullOrWhiteSpace(hex) || IsIncorrectFormat(hex))
            {
                Debug.LogWarning("Invalid or empty hexadecimal string. Returning white color.");
                return Color.white;
            }

            try
            {
                var red = Convert.ToInt32(hex.Substring(0, 2), DecimalNumberBase);
                var green = Convert.ToInt32(hex.Substring(2, 2), DecimalNumberBase);
                var blue = Convert.ToInt32(hex.Substring(4, 2), DecimalNumberBase);

                return new Color32((byte)red, (byte)green, (byte)blue, AlphaFull);
            }
            catch (Exception ex)
            {
                Debug.LogError($"Error converting hex to color: {ex.Message}");
                return Color.white;
            }
        }

        /// <summary>
        /// Checks if the provided hexadecimal string has an incorrect format.
        /// </summary>
        /// <param name="hex">Hexadecimal string to check.</param>
        /// <returns>True if the format is incorrect, otherwise false.</returns>
        private static bool IsIncorrectFormat(string hex)
        {
            return hex.Length != HexadecimalMaxLength;
        }
    }
}