// <copyright file="ResourcesUA.cs" company="Alex Brylov">
// Copyright (c) Alex Brylov. Task 5 - Number to text
// </copyright>

namespace NumberToText
{
    using System.Collections.Generic;

    /// <summary>
    /// Contains localized to Ukrainian text and Dictionary resources required for NumberToWordsConverter and console output
    /// </summary>
    public static class ResourcesUA
    {
        /// <summary> A word to be added if negative number submitted. </summary>
        public static readonly string MINUS = "мінус";

        /// <summary> Keys and values for large numbers. </summary>
        public static readonly Dictionary<long, string> TEXT_LARGE_NUMBERS = new Dictionary<long, string>()
        {
            { 1000000000000000, "квадрiльон" },
            { 1000000000000, "трильйон" },
            { 1000000000, "мiльард" },
            { 1000000, "мiльйон" },
            { 1000, "тисяча" }
        };

        /// <summary> Keys and values for large numbers plurals larger than 4. </summary>
        public static readonly Dictionary<long, string> TEXT_LARGE_NUMBERS_LARGE_PLURALS = new Dictionary<long, string>()
        {
            { 1000000000000000, "квадрiльонiв" },
            { 1000000000000, "трильйонiв" },
            { 1000000000, "мiльардiв" },
            { 1000000, "мiльйонiв" },
            { 1000, "тисяч" }
        };

        /// <summary> Keys and values for large numbers plurals less than 5. </summary>
        public static readonly Dictionary<long, string> TEXT_LARGE_NUMBERS_SMALL_PLURALS = new Dictionary<long, string>()
        {
            { 1000000000000000, "квадрiльона" },
            { 1000000000000, "трильйона" },
            { 1000000000, "мiльарда" },
            { 1000000, "мiльйона" },
            { 1000, "тисячи" }
        };

        /// <summary> Keys and values hundreds. </summary>
        public static readonly Dictionary<long, string> TEXT_HUNDREDS = new Dictionary<long, string>()
        {
            { 9, "дев'ятьсот" },
            { 8, "вiсiмсот" },
            { 7, "сiмсот" },
            { 6, "шiстьсот" },
            { 5, "п'ятьсот" },
            { 4, "чотириста" },
            { 3, "триста" },
            { 2, "двiстi" },
            { 1, "сто" },
        };

        /// <summary> Keys and values for units and tens. </summary>
        public static readonly Dictionary<long, string> TEXT_NUMBERS = new Dictionary<long, string>()
        {
            { 0, "нуль" },
            { 1, "один" },
            { 2, "два" },
            { 3, "три" },
            { 4, "чотири" },
            { 5, "п'ять" },
            { 6, "шiсть" },
            { 7, "сiмь" },
            { 8, "вiсiм" },
            { 9, "дев'ять" },
            { 10, "десять" },
            { 11, "одинадцять" },
            { 12, "дванадцять" },
            { 13, "тринадцять" },
            { 14, "чотирнадцять" },
            { 15, "п'ятнадцять" },
            { 16, "шiстнадцять" },
            { 17, "сiмнадцять" },
            { 18, "вiсiмнадцять" },
            { 19, "дев'ятнадцять" },
            { 20, "двадцять" },
            { 30, "тридцять" },
            { 40, "сорок" },
            { 50, "п'ятьдесят" },
            { 60, "шiстьдесят" },
            { 70, "сiмдесят" },
            { 80, "вiсiмдесят" },
            { 90, "дев'яносто" },
            { 100, "сто" },
        };

        /// <summary> Keys and values for units and tens. </summary>
        public static readonly Dictionary<long, string> TEXT_NUMBERS_SOME_PLURALS = new Dictionary<long, string>()
        {
            { 0, "нуль" },
            { 1, "одна" },
            { 2, "дві" },
            { 3, "три" },
            { 4, "чотири" },
            { 5, "п'ять" },
            { 6, "шість" },
            { 7, "сімь" },
            { 8, "вісім" },
            { 9, "дев'ять" },
            { 10, "десять" },
            { 11, "одинадцять" },
            { 12, "дванадцять" },
            { 13, "тринадцять" },
            { 14, "чотирнадцять" },
            { 15, "п'ятнадцять" },
            { 16, "шістнадцять" },
            { 17, "сімнадцять" },
            { 18, "вісемнадцять" },
            { 19, "дев'ятнадцять" },
            { 20, "двадцять" },
            { 30, "тридцять" },
            { 40, "сорок" },
            { 50, "п'ятьдесят" },
            { 60, "шістьдесят" },
            { 70, "сімьдесят" },
            { 80, "вісімдесят" },
            { 90, "дев'яносто" },
            { 100, "сто" },
        };
    }
}