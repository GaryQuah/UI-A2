using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabChanger : MonoBehaviour
{
    [SerializeField] Button StoryBtn;
   
    [SerializeField] Button TimetrialBtn;

    [SerializeField] Button Level1Btn;
    [SerializeField] Button Level2Btn;
    [SerializeField] Button Level3Btn;
    [SerializeField] Button Level4Btn;

    [SerializeField] GameObject Map;
    //Sprite
    [SerializeField] Sprite NotSelectedSprite;
    [SerializeField] Sprite SelectedSprite;

    [SerializeField] Sprite Map1;
    [SerializeField] Sprite Map2;
    [SerializeField] Sprite Map3;
    [SerializeField] Sprite Map4;

    void Start()
    {
        StoryBtn.onClick.AddListener(StoryButtonEvent);
        TimetrialBtn.onClick.AddListener(TimeTrialButtonEvent);

        Level1Btn.onClick.AddListener(Level1ButtonEvent);
        Level2Btn.onClick.AddListener(Level2ButtonEvent);
        Level3Btn.onClick.AddListener(Level3ButtonEvent);
        Level4Btn.onClick.AddListener(Level4ButtonEvent);
    }

    private void Update()
    {
        
    }

    public void StoryButtonEvent()
    {
        StoryBtn.GetComponent<Image>().sprite = SelectedSprite;
        TimetrialBtn.GetComponent<Image>().sprite = NotSelectedSprite;
    }

    public void TimeTrialButtonEvent()
    {
        TimetrialBtn.GetComponent<Image>().sprite = SelectedSprite;
        StoryBtn.GetComponent<Image>().sprite = NotSelectedSprite;
    }

    public void Level1ButtonEvent()
    {
        Level1Btn.GetComponent<Image>().sprite = SelectedSprite;
        Level2Btn.GetComponent<Image>().sprite = NotSelectedSprite;
        Level3Btn.GetComponent<Image>().sprite = NotSelectedSprite;
        Level4Btn.GetComponent<Image>().sprite = NotSelectedSprite;

        Map.GetComponent<Image>().sprite = Map1;
    }
    public void Level2ButtonEvent()
    {
        Level2Btn.GetComponent<Image>().sprite = SelectedSprite;
        Level1Btn.GetComponent<Image>().sprite = NotSelectedSprite;
        Level3Btn.GetComponent<Image>().sprite = NotSelectedSprite;
        Level4Btn.GetComponent<Image>().sprite = NotSelectedSprite;

        Map.GetComponent<Image>().sprite = Map2;
    }
    public void Level3ButtonEvent()
    {
        Level3Btn.GetComponent<Image>().sprite = SelectedSprite;
        Level1Btn.GetComponent<Image>().sprite = NotSelectedSprite;
        Level2Btn.GetComponent<Image>().sprite = NotSelectedSprite;
        Level4Btn.GetComponent<Image>().sprite = NotSelectedSprite;

        Map.GetComponent<Image>().sprite = Map3;
    }
    public void Level4ButtonEvent()
    {
        Level4Btn.GetComponent<Image>().sprite = SelectedSprite;
        Level1Btn.GetComponent<Image>().sprite = NotSelectedSprite;
        Level2Btn.GetComponent<Image>().sprite = NotSelectedSprite;
        Level3Btn.GetComponent<Image>().sprite = NotSelectedSprite;

        Map.GetComponent<Image>().sprite = Map4;
    }
}
