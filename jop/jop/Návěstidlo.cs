﻿using System;

namespace jop
{
    public abstract class Návěstidlo<TNávěst> where TNávěst : struct
	{
        public Návěstidlo()  // U abstraktního návěstidla není známý postup konstrukce
        {
        }

        public string Označení  // Označení návěstidla, musí být ošetřeno v konstruktoru každého potomka
        {
            get;
        }

        public TNávěst Návěst  // Návěst návěstěná návěstidlem :D
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Označení;
        }

        public override int GetHashCode()
        {
            return Označení.GetHashCode();
        }
	}
}

