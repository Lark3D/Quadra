using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraCore.Models
{
    public class Element
    {
        public Element()
        {
            ID = new ElementId(String.Empty, 0, 0);
            Parameters = new Dictionary<string, object>();
        }

        #region Properties
        public string Name { get; set; }
        public ElementId ID { get; set; }
        public int Orientation { get; set; }
        public Dictionary<string, object> Parameters { get; set; }

        public string Code { get { return ID.code; } }
        public int X { get { return ID.x; } }
        public int Y { get { return ID.y; } }
        public int X2 { get { return ID.x2; } }
        public int Y2 { get { return ID.y2; } }
        #endregion

    }
}
