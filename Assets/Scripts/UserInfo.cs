using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UserInfo : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI UserName;
    [SerializeField] TextMeshProUGUI level;
    [SerializeField] TextMeshProUGUI DiamondAmt;

    public string Username = "MyUsername1234";
    public int Level = 10;
    public int DiamondCount = 199;

    //Car
    public int CarType = 0;
    public int WheelType = 0;
    public int EngineType = 0;

    public List<bool> UnlockedLevel = new List<bool>();
    public List<bool> ClearedLevel = new List<bool>();

    public List<int> OwnedCar = new List<int>();
    public List<int> OwnedWheel = new List<int>();
    public List<int> OwnedEngine = new List<int>();

    void Start()
    {
        
    }
    void Update()
    {
        if(UserName != null)
            UserName.text = Username;
        if(level != null)
            level.text = "Level  " + Level.ToString() + " / 40";
        if(DiamondAmt != null)
            DiamondAmt.text = DiamondCount.ToString();
    }

}
