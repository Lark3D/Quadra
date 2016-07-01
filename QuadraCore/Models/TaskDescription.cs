using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraCore.Models
{
    public class TaskDescription
    {
        public TaskDescription()
        {
            Name = String.Empty;
            Description = String.Empty;
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
            LastFile = string.Empty;
        }

        #region Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string LastFile { get; set; }
        #endregion
    }
}
