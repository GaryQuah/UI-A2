using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Customisation : MonoBehaviour
{
    //Tab
    [SerializeField] Button CarBtn;
    [SerializeField] Button WheelBtn;
    [SerializeField] Button EngineBtn;

    [SerializeField] Sprite NotSelectedSprite;
    [SerializeField] Sprite SelectedSprite;

    //
    [SerializeField] Button RightArrowBtn;
    [SerializeField] Button LeftArrowBtn;

    [SerializeField] Button EquipBtn;
    [SerializeField] Button BuyBtn;
    [SerializeField] TextMeshProUGUI BuyText;

    [SerializeField] GameObject Equiped;
    [SerializeField] GameObject Owned;

    [SerializeField] GameObject CarImage;
    //Sprites
    [SerializeField] Sprite Car1;
    [SerializeField] Sprite Car2;
    [SerializeField] Sprite Car3;
    [SerializeField] Sprite Car4;

    [SerializeField] Sprite Wheel1;
    [SerializeField] Sprite Wheel2;
    [SerializeField] Sprite Wheel3;
    [SerializeField] Sprite Wheel4;
    
    [SerializeField] Sprite Engine1;
    [SerializeField] Sprite Engine2;
    [SerializeField] Sprite Engine3;
    [SerializeField] Sprite Engine4;

    // CarStats


    UserInfo user = new UserInfo();
    int Diamondcost;
    int i = 0;
    void Start()
    {
        CarBtn.onClick.AddListener(CarButtonEvent);
        WheelBtn.onClick.AddListener(WheelButtonEvent);
        EngineBtn.onClick.AddListener(EngineButtonEvent);

        RightArrowBtn.onClick.AddListener(RightArrowButtonEvent);
        LeftArrowBtn.onClick.AddListener(LeftArrowButtonEvent);
        BuyBtn.onClick.AddListener(BuyButtonEvent);
    }

    void Update()
    {
        
    }

    public void CarButtonEvent()
    {
        CarBtn.GetComponent<Image>().sprite = SelectedSprite;
        WheelBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        EngineBtn.GetComponent<Image>().sprite = NotSelectedSprite;
    }
    
    public void WheelButtonEvent()
    {
        WheelBtn.GetComponent<Image>().sprite = SelectedSprite;
        CarBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        EngineBtn.GetComponent<Image>().sprite = NotSelectedSprite;
    }
    
    public void EngineButtonEvent()
    {
        EngineBtn.GetComponent<Image>().sprite = SelectedSprite;
        WheelBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        CarBtn.GetComponent<Image>().sprite = NotSelectedSprite;
    }
    public void BuyButtonEvent()
    {
        if (user.DiamondCount >= Diamondcost)
        {
            user.DiamondCount = user.DiamondCount - Diamondcost;
        }
    }
    public void RightArrowButtonEvent()
    {
        Owned.gameObject.SetActive(false);
        Equiped.gameObject.SetActive(false);
        EquipBtn.gameObject.SetActive(false);
        BuyBtn.gameObject.SetActive(false);
        i++;
        if (i > 3)
            i = 0;

        bool b_Owned = false;

        for(int j = 0; j < user.OwnedCar.Length; ++j)
        {
            if(user.OwnedCar[j] == i)
            {
                Owned.gameObject.SetActive(true);
                b_Owned = true;
                if (user.CarType != i)
                {
                    EquipBtn.gameObject.SetActive(true);
                }
                break;
            }
        }
        if (!b_Owned)
        {
            BuyBtn.gameObject.SetActive(true);
        }
        if (user.CarType == i)
        {
            Equiped.gameObject.SetActive(true);
        }
        
        switch (i)
        {
            case 0:
                CarImage.GetComponent<Image>().sprite = Car1;
                Diamondcost = 35;
                break;
            case 1:
                CarImage.GetComponent<Image>().sprite = Car2;
                Diamondcost = 45;
                break;
            case 2:
                CarImage.GetComponent<Image>().sprite = Car3;
                Diamondcost = 55;
                break;
            case 3:
                CarImage.GetComponent<Image>().sprite = Car4;
                Diamondcost = 205;
                break;
        }
        if (BuyBtn.enabled)
            SetTextColor();
    }
    public void LeftArrowButtonEvent()
    {
        Owned.gameObject.SetActive(false);
        Equiped.gameObject.SetActive(false);
        EquipBtn.gameObject.SetActive(false);
        BuyBtn.gameObject.SetActive(false);
        i--;
        if (i < 0)
            i = 3;

        bool b_Owned = false;

        for (int j = 0; j < user.OwnedCar.Length; ++j)
        {
            if (user.OwnedCar[j] == i)
            {
                Owned.gameObject.SetActive(true);
                b_Owned = true;
                if (user.CarType != i)
                {
                    EquipBtn.gameObject.SetActive(true);
                }
                break;
            }
        }
        if (!b_Owned)
        {
            BuyBtn.gameObject.SetActive(true);
        }
        if (user.CarType == i)
        {
            Equiped.gameObject.SetActive(true);
        }

        switch (i)
        {
            case 0:
                CarImage.GetComponent<Image>().sprite = Car1;
                Diamondcost = 35;
                break;
            case 1:
                CarImage.GetComponent<Image>().sprite = Car2;
                Diamondcost = 45;
                break;
            case 2:
                CarImage.GetComponent<Image>().sprite = Car3;
                Diamondcost = 55;
                break;
            case 3:
                CarImage.GetComponent<Image>().sprite = Car4;
                Diamondcost = 205;
                break;
        }
        if (BuyBtn.enabled)
            SetTextColor();
    }
    public void SetTextColor()
    {
        if (user.DiamondCount >= Diamondcost)
            BuyText.color = Color.blue;
        else if (user.DiamondCount < Diamondcost)
            BuyText.color = Color.red;
    }



    }
