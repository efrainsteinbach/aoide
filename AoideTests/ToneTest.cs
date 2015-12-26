using NUnit.Framework;
using System;
using Aoide;

namespace AoideTests
{
    [TestFixture()]
    public class ToneTest
    {
        [Test()]
        public void DefaultCtor_ToStringReturnsC()
        {
            Assert.AreEqual("C", new Tone().ToString());
        }

        [Test()]
        public void StringCtor_F_ToStringReturnsF()
        {
            Assert.AreEqual("F", new Tone("f").ToString());
            Assert.AreEqual("F", new Tone("F ").ToString());
            Assert.AreEqual("F", new Tone("   F ").ToString());
        }

        [Test()]
        public void StringCtor_Csharp_ToStringReturnsCsharp()
        {
            Assert.AreEqual("C♯", new Tone("Csharp").ToString());
            Assert.AreEqual("C♯", new Tone("C-sharp").ToString());
            Assert.AreEqual("C♯", new Tone("C♯").ToString());
            Assert.AreEqual("C♯", new Tone("C#").ToString());
        }
            
        [Test()]
        public void StringCtor_Eflat_ToStringReturnsCsharp()
        {
            Assert.AreEqual("E♭", new Tone("E flat").ToString());
            Assert.AreEqual("E♭", new Tone("E Flat").ToString());
            Assert.AreEqual("E♭", new Tone("E-Flat").ToString());
            Assert.AreEqual("E♭", new Tone("E♭").ToString());
            Assert.AreEqual("E♭", new Tone("Eb").ToString());
        }
    }
}
