using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TabChanger : MonoBehaviour
{
    [SerializeField] Button StoryBtn;
   
    [SerializeField] Button TimetrialBtn;

    [SerializeField] Button Level1Btn;
    [SerializeField] Button Level2Btn;

    [SerializeField] GameObject Map;
    //Sprite
    [SerializeField] Sprite NotSelectedSprite;
    [SerializeField] Sprite SelectedSprite;

    [SerializeField] Sprite Map1;
    [SerializeField] Sprite Map2;

    [SerializeField] TextMeshProUGUI objectives;
    [SerializeField] TextMeshProUGUI timing;

    public UserInfo user;

    void Start()
    {
        StoryBtn.onClick.AddListener(StoryButtonEvent);
        TimetrialBtn.onClick.AddListener(TimeTrialButtonEvent);

        Level1Btn.onClick.AddListener(Level1ButtonEvent);
        Level2Btn.onClick.AddListener(Level2ButtonEvent);
    
    }

    private void Update()
    {
        
    }

    public void StoryButtonEvent()
    {
        StoryBtn.GetComponent<Image>().sprite = SelectedSprite;
        TimetrialBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        Level2Btn.interactable = true;
    }

    public void TimeTrialButtonEvent()
    {
        TimetrialBtn.GetComponent<Image>().sprite = SelectedSprite;
        StoryBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        Level2Btn.interactable = false;
        Level1ButtonEvent();
    }

    public void Level1ButtonEvent()
    {
        Level1Btn.GetComponent<Image>().sprite = SelectedSprite;
        Level2Btn.GetComponent<Image>().sprite = NotSelectedSprite;

        Map.GetComponent<Image>().sprite = Map1;
        objectives.text = "- Get a time faster than 3 mins \n \n - Get 2nd and above \n \n - Do atleast 3 Drifts";
        timing.text = "2 . 26 . 19";
    }
    public void Level2ButtonEvent()
    {
        Level2Btn.GetComponent<Image>().sprite = SelectedSprite;
        Level1Btn.GetComponent<Image>().sprite = NotSelectedSprite;

        Map.GetComponent<Image>().sprite = Map2;
        objectives.text = "- Get a time faster than 2 mins \n \n - Get 2nd and above \n \n - Do atleast 5 Drifts";
        timing.text = "-";

    }

}
