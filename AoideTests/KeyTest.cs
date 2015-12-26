using NUnit.Framework;
using System;
using Aoide;

namespace AoideTests
{
	[TestFixture()]
	public class KeyTest
	{
		[Test()]
		public void DefaultCtor_ToString_CMajor()
		{
			Assert.AreEqual("C major", new Key().ToString ());
		}		

		[Test()]
		public void EnumCtor_ToString_GSharpMinor()
		{
			Assert.AreEqual("G♯ minor", new Key(Fundamental.G, Accidental.Sharp, false).ToString ());
		}

        [Test()]
        public void StringCtor_ToString_GSharpMinor()
        {
            var keyString = "G♯ minor";
            Assert.AreEqual(keyString, new Key(keyString).ToString());
        }

        [Test()]
        public void StringCtor_ToString_AFlatMajor()
        {
            Assert.AreEqual("A♭ major", new Key("a flat major").ToString());
        }
        
        [Test()]
        public void StringCtor_ToString_FSharpMinor()
        {
            Assert.AreEqual("F♯ minor", new Key("fsharp min").ToString());
        }

		[Test()]
		public void StringCtor_ToString_CMajor()
		{
            Assert.AreEqual("C major", new Key("cmaj").ToString());
		}
	}
}

