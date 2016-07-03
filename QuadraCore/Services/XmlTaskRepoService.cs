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
            _file = file;

            //TODO Создать файл, если нет
        }

        public Task LoadTask()
        {
            //TODO
            throw new NotImplementedException();
        }

        public void SaveTask(Task task)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
