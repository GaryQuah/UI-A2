using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customisation : MonoBehaviour
{

    [SerializeField] Button CarBtn;
    [SerializeField] Button WheelBtn;
    [SerializeField] Button EngineBtn;

    [SerializeField] Sprite NotSelectedSprite;
    [SerializeField] Sprite SelectedSprite;

    void Start()
    {
        CarBtn.onClick.AddListener(CarButtonEvent);
        WheelBtn.onClick.AddListener(WheelButtonEvent);
        EngineBtn.onClick.AddListener(EngineButtonEvent);
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

}
