﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using ObjectsComparer.Tests.TestClasses;

namespace ObjectsComparer.Tests
{
    [TestFixture]
    public class EnumerablesComparerGenericTests
    {
        [Test]
        public void FirstParameterNotEnumerable()
        {
            var comparer = new EnumerablesComparer<string>(new ComparisonSettings());
            var obj1 = new List<int>();
            var obj2 = new List<string>();


            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Assert.Throws<ArgumentException>(() => comparer.Compare(obj1, obj2).ToList());
        }

        [Test]
        public void SecondParameterNotEnumerable()
        {
            var comparer = new EnumerablesComparer<string>(new ComparisonSettings());
            var obj1 = new List<string>();
            var obj2 = new A();


            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Assert.Throws<ArgumentException>(() => comparer.Compare(obj1, obj2).ToList());
        }
    }
}