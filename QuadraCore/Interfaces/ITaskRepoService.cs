using QuadraCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraCore.Interfaces
{
    public interface ITaskRepoService
    {
        TaskDescription LoadTaskDescription();

        void SaveTaskDescription(TaskDescription taskDescription);

        void GetElement(ElementId elementId);

        void SaveElement(Element element);

        void DeleteElement(ElementId elementId);

        IObservable<Element> GetAllElements();

        IObservable<ElementId> GetAllElementIds();

    }
}
