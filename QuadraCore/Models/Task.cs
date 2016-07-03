using QuadraResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraCore.Models
{
    public class Task
    {
        public Task()
        {
            var td = new TaskDescription();
            td.Name = TaskMessages.NewTask;
            td.LastFile = null;

            Description = td;
            Elements = new Dictionary<ElementId, Element>();
        }

        public TaskDescription Description { get; set; }
        public Dictionary<ElementId, Element> Elements { get; set; }
    }
}
