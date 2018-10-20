// <copyright file="ResourcesRU.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. Task 5 - Number to text
// </copyright>

namespace NumberToText
{
    using System.Collections.Generic;

    /// <summary>
    /// Contains localized text and Dictionary resources required for NumberToWordsConverter and console output
    /// </summary>
    public static class ResourcesRU
    {
        /// <summary> A word to be added if negative number submitted. </summary>
        public static readonly string MINUS = "минус";

        /// <summary> Keys and values for large numbers. </summary>
        public static readonly Dictionary<long, string> TEXT_LARGE_NUMBERS = new Dictionary<long, string>()
        {
            { 1000000000000000, "квадриллион" },
            { 1000000000000, "триллион" },
            { 1000000000, "миллиард" },
            { 1000000, "миллион" },
            { 1000, "тысяча" },
        };

        /// <summary> Keys and values for large numbers plurals larger than 4. </summary>
        public static readonly Dictionary<long, string> TEXT_LARGE_NUMBERS_LARGE_PLURALS = new Dictionary<long, string>()
        {
            { 1000000000000000, "квадриллионов" },
            { 1000000000000, "триллионов" },
            { 1000000000, "миллиардов" },
            { 1000000, "миллионов" },
            { 1000, "тысяч" },
        };

        /// <summary> Keys and values for large numbers plurals less than 5. </summary>
        public static readonly Dictionary<long, string> TEXT_LARGE_NUMBERS_SMALL_PLURALS = new Dictionary<long, string>()
        {
            { 1000000000000000, "квадриллиона" },
            { 1000000000000, "триллиона" },
            { 1000000000, "миллиарда" },
            { 1000000, "миллиона" },
            { 1000, "тысячи" },
        };

        /// <summary> Keys and values hundreds. </summary>
        public static readonly Dictionary<long, string> TEXT_HUNDREDS = new Dictionary<long, string>()
        {
            { 9, "девятьсот" },
            { 8, "восемьсот" },
            { 7, "семьсот" },
            { 6, "шестьсот" },
            { 5, "пятьсот" },
            { 4, "четыреста" },
            { 3, "триста" },
            { 2, "двести" },
            { 1, "сто" },
        };

        /// <summary> Keys and values for units and tens. </summary>
        public static readonly Dictionary<long, string> TEXT_NUMBERS = new Dictionary<long, string>()
        {
            { 0, "ноль" },
            { 1, "один" },
            { 2, "два" },
            { 3, "три" },
            { 4, "четыре" },
            { 5, "пять" },
            { 6, "шесть" },
            { 7, "семь" },
            { 8, "восемь" },
            { 9, "девять" },
            { 10, "десять" },
            { 11, "одиннадцать" },
            { 12, "двенадцать" },
            { 13, "тринадцать" },
            { 14, "четырадцать" },
            { 15, "пятнадцать" },
            { 16, "шестнадцать" },
            { 17, "семнадцать" },
            { 18, "восемнадцать" },
            { 19, "девятнадцать" },
            { 20, "двадцать" },
            { 30, "тридцать" },
            { 40, "сорок" },
            { 50, "пятьдесят" },
            { 60, "шестьдесят" },
            { 70, "семьдесят" },
            { 80, "восемьдесят" },
            { 90, "девяносто" },
            { 100, "сто" },
        };

        /// <summary> Keys and values for units and tens. </summary>
        public static readonly Dictionary<long, string> TEXT_NUMBERS_SOME_PLURALS = new Dictionary<long, string>()
        {
            { 0, "ноль" },
            { 1, "одна" },
            { 2, "две" },
            { 3, "три" },
            { 4, "четыре" },
            { 5, "пять" },
            { 6, "шесть" },
            { 7, "семь" },
            { 8, "восемь" },
            { 9, "девять" },
            { 10, "десять" },
            { 11, "одиннадцать" },
            { 12, "двенадцать" },
            { 13, "тринадцать" },
            { 14, "четырадцать" },
            { 15, "пятнадцать" },
            { 16, "шестнадцать" },
            { 17, "семнадцать" },
            { 18, "восемнадцать" },
            { 19, "девятнадцать" },
            { 20, "двадцать" },
            { 30, "тридцать" },
            { 40, "сорок" },
            { 50, "пятьдесят" },
            { 60, "шестьдесят" },
            { 70, "семьдесят" },
            { 80, "восемьдесят" },
            { 90, "девяносто" },
            { 100, "сто" },
        };
    }
}
