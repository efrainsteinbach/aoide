using System;
using System.ComponentModel;

namespace Aoide
{
	public class Tone
	{
		public Fundamental Fundamental { get; set; }

		public Accidental Accidental { get; set; }

        public Tone()
        {
            this.Fundamental = Fundamental.C;
            this.Accidental = Accidental.Natural;
        }

        public Tone(string toneName)
        {
            var toneNameSmall = toneName.Trim().ToLowerInvariant();
            this.Fundamental = ToneParser.ParseFundamental(toneNameSmall[0]);
            this.Accidental = ToneParser.ParseAccidental(toneNameSmall.Substring(1));
        }

		public override string ToString()
		{
			return string.Format("{0}{1}", this.Fundamental, this.Accidental.ToFriendlyString());
		}
	}

    public static class ToneParser
    {
        public static Accidental ParseAccidental(string accidental)
        {
            switch (accidental
                .Replace(" ", string.Empty)
                .Replace("-", string.Empty))
            {
                case "":
                    return Accidental.Natural;
                case "♭":
                case "b":
                case "flat":
                    return Accidental.Flat;
                case "♯":
                case "#":
                case "sharp":
                    return Accidental.Sharp;
                default:
                    throw new InvalidOperationException(
                        string.Format(
                            "Accidental '{0}' is invalid. Please use 'b' or '#'.", 
                            accidental)
                    );
            }
        }

        public static Fundamental ParseFundamental(char fundamental)
        {
            switch (fundamental)
            {
                case 'a':
                    return Fundamental.A;
                case 'b':
                case 'h':
                    return Fundamental.B;
                case 'c':
                    return Fundamental.C;
                case 'd':
                    return Fundamental.D;
                case 'e':
                    return Fundamental.E;
                case 'f':
                    return Fundamental.F;
                case 'g':
                    return Fundamental.G;
                default:
                    throw new InvalidOperationException(
                        string.Format(
                            "Tone name '{0}' is invalid. The note name should look like this: A, Ab, C#3, D8", 
                            fundamental)
                    );
            }
        }
    }
}
