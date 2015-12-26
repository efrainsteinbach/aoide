using System;
using System.ComponentModel;

namespace Aoide
{
	public class Octave
	{
        int Ordinal { get; set; }

        public Octave(int ordinal = 4)
        {
            this.Ordinal = ordinal;
        }

        public override string ToString()
        {
            return string.Format("{0}", this.Ordinal);
        }
	}
}

