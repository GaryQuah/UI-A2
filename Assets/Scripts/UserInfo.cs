using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInfo
{
    public string Username;
    public int Level = 1;
    public int DiamondCount = 199;

    //Car
    public int CarType = 0;
    public int WheelType = 0;
    public int EngineType = 0;

    public List<int> OwnedCar = new List<int>();
    public List<int> OwnedWheel = new List<int>();
    public List<int> OwnedEngine = new List<int>();

    //Setters
    public void SetUsername(string name)
    {
        Username = name;
    }
  
   
}
