using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInfo : MonoBehaviour
{
    public string Username;
    public string Password;
    public int Level;
    public int DiamondCount;

    //Car
    public int CarType;
    public int WheelType;

    //Setters
    public void SetUsername(string name)
    {
        Username = name;
    }
    public void SetPassword(string password)
    {
        Password = password;
    }
    public void SetCarType(int cartype)
    {
        CarType = cartype;
    }
    public void SetWheelType(int wheeltype)
    {
        WheelType = wheeltype;
    }
    public void SetDiamondCount(int DC)
    {
        DiamondCount = DC;
    }
    public void SetLevel(int level)
    {
        Level = level;
    }
    //Getters
    public string GetUserName()
    {
        return Username;
    
    }
    public string GetPassword()
    {
        return Password;
    }
    public int GetCarType()
    {
        return CarType;
    }
    public int GetWheelType()
    {
        return WheelType;
    }
    public int GetLevel()
    {
        return Level;
    }
    public int GetDiamondCount()
    {
        return DiamondCount;
    }
}
