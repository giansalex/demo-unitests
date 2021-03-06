﻿using System;
using Application.Lib.Validator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Tests.Validator
{
    [TestClass]
    public class AmountValidatorTests
    {
        [DataTestMethod]
        [DataRow(20)]
        [DataRow(40.0)]
        public void ValidAmount(object argument)
        {
            // Arrange
            var validator = new AmountValidator();
            var amount = Convert.ToDecimal(argument);

            // Act
            var result = validator.Valid(amount);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidAmount()
        {
            // Arrange
            var validator = new AmountValidator();
            var amount = 1M;

            // Act
            var result = validator.Valid(amount);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
