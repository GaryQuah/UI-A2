﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using UnityEditor;

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

    [SerializeField] GameObject Image;
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
    [SerializeField] GameObject CarStatsImage;
    [SerializeField] Sprite CarStats1;
    [SerializeField] Sprite CarStats2;
    [SerializeField] Sprite CarStats3;
    [SerializeField] Sprite CarStats4;


    [SerializeField] Sprite Car1Stats1;
    [SerializeField] Sprite Car1Stats2;
    [SerializeField] Sprite Car1Stats3;
    [SerializeField] Sprite Car1Stats4;

    [SerializeField] Sprite Car2Stats1;
    [SerializeField] Sprite Car2Stats2;
    [SerializeField] Sprite Car2Stats3;
    [SerializeField] Sprite Car2Stats4;

    public UserInfo user;

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
        EquipBtn.onClick.AddListener(EquipButtonEvent);
    }

    void Update()
    {

    }

    public void CarButtonEvent()
    {
        CarBtn.GetComponent<Image>().sprite = SelectedSprite;
        WheelBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        EngineBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        Image.GetComponent<Image>().sprite = Car1;
        i = 0;


        Owned.gameObject.SetActive(false);
        Equiped.gameObject.SetActive(false);
        EquipBtn.gameObject.SetActive(false);
        BuyBtn.gameObject.SetActive(false);

        bool b_Owned = false;

        b_Owned = user.OwnedCar.Contains(i);

        if (b_Owned)
        {
            Owned.gameObject.SetActive(true);
            if (user.CarType == i)
            {
                Equiped.gameObject.SetActive(true);
            }
            else if (user.CarType != i)
            {
                EquipBtn.gameObject.SetActive(true);
            }
        }
        else if (!b_Owned)
        {
            BuyBtn.gameObject.SetActive(true);
        }
        CarStatsImage.GetComponent<Image>().sprite = CarStats1;
    }

    public void WheelButtonEvent()
    {
        WheelBtn.GetComponent<Image>().sprite = SelectedSprite;
        CarBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        EngineBtn.GetComponent<Image>().sprite = NotSelectedSprite;

        Image.GetComponent<Image>().sprite = Wheel1;
        i = 0;
       
        Owned.gameObject.SetActive(false);
        Equiped.gameObject.SetActive(false);
        EquipBtn.gameObject.SetActive(false);
        BuyBtn.gameObject.SetActive(false);

        bool b_Owned = false;

        b_Owned = user.OwnedWheel.Contains(i);

        if (b_Owned)
        {
            Owned.gameObject.SetActive(true);
            if (user.WheelType == i)
            {
                Equiped.gameObject.SetActive(true);
            }
            else if (user.WheelType != i)
            {
                EquipBtn.gameObject.SetActive(true);
            }
        }
        else if (!b_Owned)
        {
            BuyBtn.gameObject.SetActive(true);
        }
        CarStatsImage.GetComponent<Image>().sprite = Car1Stats1;
    }

    public void EngineButtonEvent()
    {
        EngineBtn.GetComponent<Image>().sprite = SelectedSprite;
        WheelBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        CarBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        Image.GetComponent<Image>().sprite = Engine1;

        i = 0;

        Owned.gameObject.SetActive(false);
        Equiped.gameObject.SetActive(false);
        EquipBtn.gameObject.SetActive(false);
        BuyBtn.gameObject.SetActive(false);

        bool b_Owned = false;

        b_Owned = user.OwnedEngine.Contains(i);

        if (b_Owned)
        {
            Owned.gameObject.SetActive(true);
            if (user.EngineType == i)
            {
                Equiped.gameObject.SetActive(true);
            }
            else if (user.EngineType != i)
            {
                EquipBtn.gameObject.SetActive(true);
            }
        }
        else if (!b_Owned)
        {
            BuyBtn.gameObject.SetActive(true);
        }
        CarStatsImage.GetComponent<Image>().sprite = Car1Stats1;
    }
    public void EquipButtonEvent()
    {
        if (CarBtn.GetComponent<Image>().sprite == SelectedSprite)
        {
            user.CarType = i;
        }
        else if (WheelBtn.GetComponent<Image>().sprite == SelectedSprite)
        {
            user.WheelType = i;
        }
        else if (EngineBtn.GetComponent<Image>().sprite == SelectedSprite)
        {
            user.EngineType = i;
        }

        EquipBtn.gameObject.SetActive(false);
        Equiped.gameObject.SetActive(true);
    }
    public void BuyButtonEvent()
    {

        if (user.DiamondCount >= Diamondcost)
        {
            user.DiamondCount = user.DiamondCount - Diamondcost;
            
            if (CarBtn.GetComponent<Image>().sprite == SelectedSprite)
            {
                user.OwnedCar.Add(i);
            }
            else if (WheelBtn.GetComponent<Image>().sprite == SelectedSprite)
            {
                user.OwnedWheel.Add(i);
            }
            else if (EngineBtn.GetComponent<Image>().sprite == SelectedSprite)
            {
                user.OwnedEngine.Add(i);
            }

            BuyBtn.gameObject.SetActive(false);
            EquipBtn.gameObject.SetActive(true);
            Owned.gameObject.SetActive(true);
        }
        else
        {
            Handheld.Vibrate();
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

        if (CarBtn.GetComponent<Image>().sprite == SelectedSprite)
        {
            b_Owned = user.OwnedCar.Contains(i);

            if (b_Owned)
            {
                Owned.gameObject.SetActive(true);
                if (user.CarType == i)
                {
                    Equiped.gameObject.SetActive(true);
                }
                else if (user.CarType != i)
                {
                    EquipBtn.gameObject.SetActive(true);
                }
            }
            else if (!b_Owned)
            {
                BuyBtn.gameObject.SetActive(true);
            }


            switch (i)
            {
                case 0:
                    Image.GetComponent<Image>().sprite = Car1;
                    CarStatsImage.GetComponent<Image>().sprite = CarStats1;
                    Diamondcost = 35;
                    break;
                case 1:
                    Image.GetComponent<Image>().sprite = Car2;
                    CarStatsImage.GetComponent<Image>().sprite = CarStats2;
                    Diamondcost = 45;
                    break;
                case 2:
                    Image.GetComponent<Image>().sprite = Car3;
                    CarStatsImage.GetComponent<Image>().sprite = CarStats3;
                    Diamondcost = 155;
                    break;
                case 3:
                    Image.GetComponent<Image>().sprite = Car4;
                    CarStatsImage.GetComponent<Image>().sprite = CarStats4;
                    Diamondcost = 205;
                    break;
            }
        }
        else if (WheelBtn.GetComponent<Image>().sprite == SelectedSprite)
        {
            b_Owned = user.OwnedWheel.Contains(i);

            if (b_Owned)
            {
                Owned.gameObject.SetActive(true);
                if (user.WheelType == i)
                {
                    Equiped.gameObject.SetActive(true);
                }
                else if (user.WheelType != i)
                {
                    EquipBtn.gameObject.SetActive(true);
                }
            }
            else if (!b_Owned)
            {
                BuyBtn.gameObject.SetActive(true);
            }

            switch (i)
            {
                case 0:
                    Image.GetComponent<Image>().sprite = Wheel1;
                    Diamondcost = 35;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats1;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats1;
                            break;
                    }

                    break;
                case 1:
                    Image.GetComponent<Image>().sprite = Wheel2;
                    Diamondcost = 45;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats2;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats2;
                            break;
                    }

                    break;
                case 2:
                    Image.GetComponent<Image>().sprite = Wheel3;
                    Diamondcost = 55;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats3;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats3;
                            break;
                    }

                    break;
                case 3:
                    Image.GetComponent<Image>().sprite = Wheel4;
                    Diamondcost = 155;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats4;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats4;
                            break;
                    }

                    break;
            }
        }
        else if (EngineBtn.GetComponent<Image>().sprite == SelectedSprite)
        {
            b_Owned = user.OwnedEngine.Contains(i);

            if (b_Owned)
            {
                Owned.gameObject.SetActive(true);
                if (user.EngineType == i)
                {
                    Equiped.gameObject.SetActive(true);
                }
                else if (user.EngineType != i)
                {
                    EquipBtn.gameObject.SetActive(true);
                }
            }
            else if (!b_Owned)
            {
                BuyBtn.gameObject.SetActive(true);
            }

            switch (i)
            {
                case 0:
                    Image.GetComponent<Image>().sprite = Engine1;
                    Diamondcost = 35;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats1;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats1;
                            break;
                    }

                    break;
                case 1:
                    Image.GetComponent<Image>().sprite = Engine2;
                    Diamondcost = 45;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats2;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats2;
                            break;
                    }

                    break;
                case 2:
                    Image.GetComponent<Image>().sprite = Engine3;
                    Diamondcost = 55;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats3;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats3;
                            break;
                    }

                    break;
                case 3:
                    Image.GetComponent<Image>().sprite = Engine4;
                    Diamondcost = 155;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats4;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats4;
                            break;
                    }

                    break;
            }
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

        if (CarBtn.GetComponent<Image>().sprite == SelectedSprite)
        {
            b_Owned = user.OwnedCar.Contains(i);

            if (b_Owned)
            {
                Owned.gameObject.SetActive(true);
                if (user.CarType == i)
                {
                    Equiped.gameObject.SetActive(true);
                }
                else if (user.CarType != i)
                {
                    EquipBtn.gameObject.SetActive(true);
                }
            }
            else if (!b_Owned)
            {
                BuyBtn.gameObject.SetActive(true);
            }


            switch (i)
            {
                case 0:
                    Image.GetComponent<Image>().sprite = Car1;
                    CarStatsImage.GetComponent<Image>().sprite = CarStats1;
                    Diamondcost = 35;
                    break;
                case 1:
                    Image.GetComponent<Image>().sprite = Car2;
                    CarStatsImage.GetComponent<Image>().sprite = CarStats2;
                    Diamondcost = 45;
                    break;
                case 2:
                    Image.GetComponent<Image>().sprite = Car3;
                    CarStatsImage.GetComponent<Image>().sprite = CarStats3;
                    Diamondcost = 155;
                    break;
                case 3:
                    Image.GetComponent<Image>().sprite = Car4;
                    CarStatsImage.GetComponent<Image>().sprite = CarStats4;
                    Diamondcost = 205;
                    break;
            }
        }
        else if (WheelBtn.GetComponent<Image>().sprite == SelectedSprite)
        {
            b_Owned = user.OwnedWheel.Contains(i);

            if (b_Owned)
            {
                Owned.gameObject.SetActive(true);
                if (user.WheelType == i)
                {
                    Equiped.gameObject.SetActive(true);
                }
                else if (user.WheelType != i)
                {
                    EquipBtn.gameObject.SetActive(true);
                }
            }
            else if (!b_Owned)
            {
                BuyBtn.gameObject.SetActive(true);
            }

            switch (i)
            {
                case 0:
                    Image.GetComponent<Image>().sprite = Wheel1;
                    Diamondcost = 35;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats1;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats1;
                            break;
                    }

                    break;
                case 1:
                    Image.GetComponent<Image>().sprite = Wheel2;
                    Diamondcost = 45;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats2;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats2;
                            break;
                    }

                    break;
                case 2:
                    Image.GetComponent<Image>().sprite = Wheel3;
                    Diamondcost = 55;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats3;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats3;
                            break;
                    }

                    break;
                case 3:
                    Image.GetComponent<Image>().sprite = Wheel4;
                    Diamondcost = 155;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats4;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats4;
                            break;
                    }

                    break;
            }
        }
        else if (EngineBtn.GetComponent<Image>().sprite == SelectedSprite)
        {
            b_Owned = user.OwnedEngine.Contains(i);

            if (b_Owned)
            {
                Owned.gameObject.SetActive(true);
                if (user.EngineType == i)
                {
                    Equiped.gameObject.SetActive(true);
                }
                else if (user.EngineType != i)
                {
                    EquipBtn.gameObject.SetActive(true);
                }
            }
            else if (!b_Owned)
            {
                BuyBtn.gameObject.SetActive(true);
            }

            switch (i)
            {
                case 0:
                    Image.GetComponent<Image>().sprite = Engine1;
                    Diamondcost = 35;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats1;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats1;
                            break;
                    }

                    break;
                case 1:
                    Image.GetComponent<Image>().sprite = Engine2;
                    Diamondcost = 45;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats2;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats2;
                            break;
                    }

                    break;
                case 2:
                    Image.GetComponent<Image>().sprite = Engine3;
                    Diamondcost = 55;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats3;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats3;
                            break;
                    }

                    break;
                case 3:
                    Image.GetComponent<Image>().sprite = Engine4;
                    Diamondcost = 200;
                    switch (user.CarType)
                    {
                        case 0:
                            CarStatsImage.GetComponent<Image>().sprite = Car1Stats4;
                            break;
                        case 1:
                            CarStatsImage.GetComponent<Image>().sprite = Car2Stats4;
                            break;
                    }

                    break;
            }
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
