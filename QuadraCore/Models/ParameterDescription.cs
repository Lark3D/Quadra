using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraCore.Models
{
    public class ParameterDescription
    {
        #region Properties
        public string Name { get; set; }
        public Type Type {get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public object DefaultValue { get; set; }
        public int? MaxLength { get; set; }
        public double? MaxValue { get; set; }
        public double? MinValue { get; set; }
        public List<object> PossibleValues { get; set; }
        #endregion
    }
}
