using NUnit.Framework;
using System;
using Aoide;

namespace AoideTests
{
    [TestFixture()]
    public class NoteTest
    {
        [Test()]
        public void DefaultCtor_ToStringReturnsC4()
        {
            Assert.AreEqual("C4", new Note().ToString());
        }

        [Test()]
        public void StringCtor_Csharp_ToStringReturnsCsharp4()
        {
            Assert.AreEqual("C♯4", new Note("C#").ToString());
        }

        [Test()]
        public void StringCtor_B2_ToStringReturnsB2()
        {
            Assert.AreEqual("B2", new Note("B 2").ToString());
            Assert.AreEqual("B2", new Note("B2").ToString());
        }
    }

}

