using Quadra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quadra.Interfaces
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
