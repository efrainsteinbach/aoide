using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Aoide
{		
	public class Key
	{
		public Tone Tonic { get; set; }

		public Key(Fundamental fundamental = Fundamental.C, Accidental accidental = Accidental.Natural, bool isMajor = true)
		{
			this.Tonic = new Tone() { Fundamental = fundamental, Accidental = accidental };
			this.IsMajor = isMajor;
		}

		public Key(string keyName)
		{
            var parts = Regex.Match(keyName.ToUpperInvariant(), @"(.+)(MIN|MAJ)");

            if (parts.Groups.Count != 3)
                throw new InvalidOperationException(string.Format("Key name '{0}' is invalid. " +
                    "The name should contain a tone name and 'major' or 'minor'. E.g.: A flat minor, C maj", keyName));

            this.Tonic = new Tone(parts.Groups[1].Value);

            this.IsMajor = parts.Groups[2].Value.Contains("MAJ");
		}

		/// <summary>
		/// Gets or sets a value indicating whether this is a major key.
		/// </summary>
		public bool IsMajor { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this is a minor key.
		/// </summary>
		public bool IsMinor 
		{
			get 
			{ 
				return !this.IsMajor; 
			}
			set 
			{
				this.IsMajor = !value;
			}
		}

		public override string ToString()
		{
			var majorness = this.IsMajor ? "major" : "minor";
			return string.Format ("{0} {1}", this.Tonic.ToString(), majorness);
		}
	}
}

