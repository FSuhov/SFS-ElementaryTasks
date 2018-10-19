using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText.Classes
{
    public class ConverterUA : ConverterRU
    {
        protected override void LoadResources()
        {
            this._smallNumbersTextPlurals = ResourcesUA.TEXT_NUMBERS_SOME_PLURALS;
            this._smallNumbersText = ResourcesUA.TEXT_NUMBERS;
            this._largeNumbersText = ResourcesUA.TEXT_LARGE_NUMBERS;
            this._largeNumbersTextLargePlurals = ResourcesUA.TEXT_LARGE_NUMBERS_LARGE_PLURALS;
            this._largeNumbersTextSmallPlurals = ResourcesUA.TEXT_LARGE_NUMBERS_SMALL_PLURALS;
            this._negative = ResourcesUA.MINUS;
            this._hundredsText = ResourcesUA.TEXT_HUNDREDS;
        }
    }
}
