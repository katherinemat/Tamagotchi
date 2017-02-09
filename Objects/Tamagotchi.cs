using System.Collections.Generic;

namespace Tamagotchi.Objects
{
  public class Tamagotchi
  {
    private string _description;
    private int _food;
    private int _attention;
    private int _rest;

    public Tamagotchi(string description)
    {
      _description = description;
      _food = 100;
      _attention = 100;
      _rest = 100;
    }

    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public string GetFood()
    {
      return _food;
    }
    public void SetFood(string newFood)
    {
      _food = newFood
    }

    public string GetAttention()
    {
      return _attention;
    }
    public void SetAttention(string newAttention)
    {
      _attention = newAttention
    }

    public string GetRest()
    {
      return _rest;
    }
    public void SetRest(string newRest)
    {
      _rest = newRest
    }

    // public static List<Task> GetAll()
    // {
    //   return _instances;
    // }
    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
  }
}
