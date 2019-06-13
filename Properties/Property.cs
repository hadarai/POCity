﻿using System;

namespace POCity.Properties
{
    public abstract class Property
    {
        public int x;
        public int y;
        protected string nazwa;
        protected int PromienPradu = 7;

        protected Property(int nx, int ny)
        {
            x = nx;
            y = ny;
        }

        public override string ToString()
        {
            return this.nazwa; //+ " " + x.ToString() + " " + y.ToString();
        }

        public static int GetRadius()
        {
            return 0;
        }

        public void GetToKnow(Type NewNeighbour)
        { }
    }

}

