using System.Collections.Generic;

namespace Todo.Objects
{
  public class Category
  {
    private static List<Category> _instances = new List<Category> {};
    private string _name;
    private int _id;
    private List<Task> _tasks= new List<Task> {};

    public Category(string categoryName)
    {
    _name = categoryName;
    _instances.Add(this);
    _id = _instances.Count;
    _tasks = new List<Task>{};
    }
    public string GetName()
    {
      return _name;
    }
    public int GetId()
    {
      return _id;
    }
    public List<Task> GetTasks()
    {
      return _tasks;
    }
    public void AddTask(Task task)
    {
      _tasks.Add(task);
    }
    public static List<Category> GetAll()
    {
      return _instances;
    }
    public void Clear()
    {
      _tasks.Clear();
    }
    public static Category Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
