using Quadra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quadra.Models;

namespace Quadra.Services
{
    class XmlTaskRepoService : ITaskRepoService
    {
        public void DeleteElement(ElementId elementId)
        {
            //TODO
            throw new NotImplementedException();
        }

        public IObservable<ElementId> GetAllElementIds()
        {
            //TODO
            throw new NotImplementedException();
        }

        public IObservable<Element> GetAllElements()
        {
            //TODO
            throw new NotImplementedException();
        }

        public void GetElement(ElementId elementId)
        {
            //TODO
            throw new NotImplementedException();
        }

        public TaskDescription LoadTaskDescription()
        {
            //TODO
            throw new NotImplementedException();
        }

        public void SaveElement(Element element)
        {
            //TODO
            throw new NotImplementedException();
        }

        public void SaveTaskDescription(TaskDescription taskDescription)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
