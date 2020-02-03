using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInfo : MonoBehaviour
{
    public string Username;
    public int Level = 1;
    public int DiamondCount = 199;

    //Car
    public int CarType = 1;
    public int WheelType = 1;

    //Setters
    public void SetUsername(string name)
    {
        Username = name;
    }
  
   
}
