using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraCore.Models
{
    public struct ElementId
    {
        public readonly string code;
        public readonly int x;
        public readonly int y;
        public readonly int x2;
        public readonly int y2;

        public ElementId(string code, int x, int y) : this(code, x, y, x, y)
        {
        }

        public ElementId(string code, int x, int y, int x2, int y2)
        {
            this.code = code;
            this.x = x;
            this.y = y;
            this.x2 = x2;
            this.y2 = y2;
        }
    }
}
