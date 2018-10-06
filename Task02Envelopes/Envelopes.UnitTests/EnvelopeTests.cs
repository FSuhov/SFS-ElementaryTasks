﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Envelopes.UnitTests
{
    [TestClass]
    public class EnvelopeTests
    {
        [TestMethod]
        [DataRow(8, 6, 10, 6, 0, DisplayName = ConfigEnvelopes.nonCanBePlaced)]
        [DataRow(8, 6, 7, 5, 1, DisplayName = ConfigEnvelopes.secondCanBePlaced)]
        [DataRow(8, 6, 10, 7, -1, DisplayName = ConfigEnvelopes.firstCanBePlaced)]
        [DataRow(8, 6, 7, 10, -1, DisplayName = ConfigEnvelopes.firstCanBePlaced)]
        [DataRow(8, 6, 8, 6, 0, DisplayName = ConfigEnvelopes.nonCanBePlaced)]
        [DataRow(8, 6, 6, 8, 0, DisplayName = ConfigEnvelopes.nonCanBePlaced)]
        public void CompareTo_WhenCalled_ReturnCompareResult(float widthThis, float heightThis, float widthOther, float heightOther, int expectedResult)
        {
            Envelope envelopeThis = new Envelope(widthThis, heightThis);
            Envelope envelopeOther = new Envelope(widthOther, heightOther);
            
            var result = envelopeThis.CompareTo(envelopeOther);

            Assert.AreEqual(result, expectedResult);
        }
    }
}