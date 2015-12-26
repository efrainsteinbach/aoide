using System;
using System.ComponentModel;

namespace Aoide
{
	public enum Accidental
	{
		Natural = 0,
		Flat,
		Sharp,
	}

    public static class AccidentalExtensions
    {
        public static string ToFriendlyString(this Accidental accidental)
        {
            switch (accidental)
            {
                case Accidental.Natural:
                    return "";
                case Accidental.Flat:
                    return "♭";
                case Accidental.Sharp:
                    return "♯";
                default:
                    throw new InvalidOperationException(
                        string.Format("Unknown accidental. Cannot 'toString' value '{0}'.", accidental)
                    ); 
            }
        }
    }
}
