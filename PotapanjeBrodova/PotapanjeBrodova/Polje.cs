using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class Polje : IEquatable<Polje>
    {
        public Polje(int redak, int stupac)
        {
            Redak = redak;
            Stupac = stupac;
        }

        public readonly int Redak;
        public readonly int Stupac;

        public bool Equals(Polje other)
        {
            return Redak == other.Redak && Stupac == other.Stupac;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Polje)obj);
        }
        public override int GetHashCode()
        {
                int hash = 17;
                hash = hash * 23;
                hash = hash * 17; 
                return hash;
        }
    }
}
