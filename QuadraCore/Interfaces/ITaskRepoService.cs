using QuadraCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraCore.Interfaces
{
    public interface ITaskRepoService
    {
        void SaveTask(Task task);
        Task LoadTask();
    }
}
