using System.Collections.Generic;

namespace InterviewAlgorithms
{
  internal class Sorter
  {
    public List<object> ListOfObjects { get; set; }
    //AddValue & GetValues

    public Sorter()
    {
      ListOfObjects = new List<object>();
    }
    
    public void AddValue<T>(T item)
    {
      ListOfObjects.Add(item);
    }

    public object GetValues<T>(int indexOfObject)
    {
      return ListOfObjects[indexOfObject];
    }
  }
}