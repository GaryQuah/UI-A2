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
    [SerializeField] Button Level3Btn;
    [SerializeField] Button Level4Btn;

    [SerializeField] GameObject Map;
    //Sprite
    [SerializeField] Sprite NotSelectedSprite;
    [SerializeField] Sprite SelectedSprite;

    [SerializeField] Sprite Map1;
    [SerializeField] Sprite Map2;

    [SerializeField] TextMeshProUGUI objectivesCat;
    [SerializeField] TextMeshProUGUI objectives;
    [SerializeField] TextMeshProUGUI timingCat;
    [SerializeField] TextMeshProUGUI timing;

    public UserInfo user;

    void Start()
    {
        StoryBtn.onClick.AddListener(StoryButtonEvent);
        TimetrialBtn.onClick.AddListener(TimeTrialButtonEvent);

        Level1Btn.onClick.AddListener(Level1ButtonEvent);
        Level2Btn.onClick.AddListener(Level2ButtonEvent);
        Level3Btn.onClick.AddListener(UnInteracterbleButtonEvent);
        Level4Btn.onClick.AddListener(UnInteracterbleButtonEvent);
    }

    private void Update()
    {
        
    }

    public void StoryButtonEvent()
    {
        StoryBtn.GetComponent<Image>().sprite = SelectedSprite;
        TimetrialBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        Level1ButtonEvent();

        ColorBlock Level2BtnColors = Level2Btn.colors;
        Level2BtnColors.normalColor = new Color32(255, 255, 255, 255);
        Level2BtnColors.selectedColor = new Color32(245, 245, 245, 245);
        Level2Btn.colors = Level2BtnColors;
    }

    public void TimeTrialButtonEvent()
    {
        TimetrialBtn.GetComponent<Image>().sprite = SelectedSprite;
        StoryBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        Level1ButtonEvent();

        ColorBlock Level2BtnColors = Level2Btn.colors;
        Level2BtnColors.normalColor = new Color32(200,200,200,200);
        Level2BtnColors.selectedColor = new Color32(200,200,200,200);
        Level2Btn.colors = Level2BtnColors;
    }

    public void Level1ButtonEvent()
    {
        Level1Btn.GetComponent<Image>().sprite = SelectedSprite;
        Level2Btn.GetComponent<Image>().sprite = NotSelectedSprite;

        Map.GetComponent<Image>().sprite = Map1;
        if (StoryBtn.GetComponent<Image>().sprite == SelectedSprite)
        {
            objectives.text = "- Get a time faster than 3 mins \n \n- Get 2nd and above \n \n- Do atleast 3 Drifts";
            timing.text = "2 . 26 . 19";
            timing.gameObject.SetActive(true);
            objectivesCat.gameObject.SetActive(true);
            timingCat.gameObject.SetActive(true);
        }
        else
        {
            objectives.text = "Timing:  - ";
            timing.gameObject.SetActive(false);
            timingCat.gameObject.SetActive(false);
            objectivesCat.gameObject.SetActive(false);
        }
    }
    public void Level2ButtonEvent()
    {
        if (StoryBtn.GetComponent<Image>().sprite == SelectedSprite)
        {
            Level2Btn.GetComponent<Image>().sprite = SelectedSprite;
            Level1Btn.GetComponent<Image>().sprite = NotSelectedSprite;

            Map.GetComponent<Image>().sprite = Map2;
            objectives.text = "- Get a time faster than 2 mins \n \n- Get 2nd and above \n \n- Do atleast 5 Drifts";
            timing.text = "-";
        }
        else
        {
            Handheld.Vibrate();
        }
    }
    public void UnInteracterbleButtonEvent()
    {
            Handheld.Vibrate();
    }

}
