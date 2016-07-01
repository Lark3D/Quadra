using QuadraCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuadraCore.Models;
using System.IO;
using QuadraCore.Helpers;
using QuadraResources;

namespace QuadraCore.Services
{
    class XmlTaskRepoService : ITaskRepoService
    {
        private string _file = String.Empty;

        public XmlTaskRepoService(string file)
        {
            if (!File.Exists(file))
            {
                string msg = string.Format(Messages.FileNotFound, file);
                Log.Error(msg);
                throw new FileNotFoundException(msg, file);
            }
            _file = file;
        }

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
