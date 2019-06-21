﻿using System;
namespace POCity.Properties
{
    [Serializable]
    public class Avenue : Road
    {
        public Avenue(int x, int y)
            : base(x, y)
        {
            my_name = "\u21CB\u21CB";
        }
        public new static int GetRadius()
        {
            return 0;
        }
    }
}
