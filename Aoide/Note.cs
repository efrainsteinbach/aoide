using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Linq;

namespace Aoide
{
	public class Note
	{
		public Tone Tone { get; set; }

		public Octave Octave { get; set; }

        public Note()
        {
            this.Tone = new Tone();
            this.Octave = new Octave();
        }

        public Note(string noteName)
        {
            var letterGroups = Regex.Match(noteName, @"([^0-9]+)").Captures;
            var numbers = Regex.Match(noteName, @"([0-9])").Captures;

            if (letterGroups.Count != 1 || numbers.Count > 1)
                throw new InvalidOperationException(string.Format("Note name '{0}' is invalid. " +
                    "The name should contain a tone name and a single digit. E.g.: A, C4, F#3, Db 8", noteName));
            
            this.Tone = new Tone(letterGroups[0].Value);

            if (numbers.Count == 0)
                this.Octave = new Octave(4);
            else
                this.Octave = new Octave(int.Parse(numbers[0].Value));
        }

        static void ThrowInvalidFormatException(string noteName)
        {
            throw new InvalidOperationException(string.Format("Note name '{0}' is invalid. The note name contains at least one and at most 3 characters. E.g.: A, Ab, C#3, D8", noteName));
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", Tone, Octave);
        }
	}
}
