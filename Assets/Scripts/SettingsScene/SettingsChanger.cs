using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsChanger : MonoBehaviour
{
    [SerializeField] Button GameBtn;
    [SerializeField] GameObject GameTab;

    //GraphicsQuality Button
    [SerializeField] Button GQLowBtn;
    [SerializeField] Button GQMediumBtn;
    [SerializeField] Button GQHighBtn;

    //ScreenRefreshRate Buttons
    [SerializeField] Button SRRLowBtn;
    [SerializeField] Button SRRMediumBtn;
    [SerializeField] Button SRRHighBtn;


    [SerializeField] Button DeviceBtn;
    [SerializeField] GameObject DeviceTab;

    //Music & SFX AudioMixer
    public AudioMixer MusicAudio;
    public AudioMixer SFXAudio;

    //Vibration
    [SerializeField] Button OffBtn;
    [SerializeField] Button OnBtn;

    //Sprite
    [SerializeField] Sprite NotSelectedSprite;
    [SerializeField] Sprite SelectedSprite;

    // Start is called before the first frame update
    void Start()
    {
        GameBtn.onClick.AddListener(GameButtonEvent);
        DeviceBtn.onClick.AddListener(DeviceButtonEvent);
        DeviceTab.SetActive(false);

        //Graphics
        GQLowBtn.onClick.AddListener(GQLowButtonEvent);
        GQMediumBtn.onClick.AddListener(GQMediumButtonEvent);
        GQHighBtn.onClick.AddListener(GQHighButtonEvent);

        //Screen Refresh Rate
        SRRLowBtn.onClick.AddListener(SRRLowButtonEvent);
        SRRMediumBtn.onClick.AddListener(SRRMediumButtonEvent);
        SRRHighBtn.onClick.AddListener(SRRHighButtonEvent);

        //Vibration
        OffBtn.onClick.AddListener(OffBtnEvent);
        OnBtn.onClick.AddListener(OnBtnEvent);
    }

    //Tab Changing
    public void DeviceButtonEvent()
    {
        DeviceTab.SetActive(true);
        GameTab.SetActive(false);

        DeviceBtn.GetComponent<Image>().sprite = SelectedSprite;
        GameBtn.GetComponent<Image>().sprite = NotSelectedSprite;
    }
    public void GameButtonEvent()
    {
        GameTab.SetActive(true);
        DeviceTab.SetActive(false);

        GameBtn.GetComponent<Image>().sprite = SelectedSprite;
        DeviceBtn.GetComponent<Image>().sprite = NotSelectedSprite;
    }

    //Set Music & SFX vol
    public void SetMusicVolume(float volume)
    {
        MusicAudio.SetFloat("MusicVol", volume);
    }
    public void SetSFXVolume(float volume)
    {
        SFXAudio.SetFloat("SFXVol", volume);
    }
    //Set graphics
    public void SetGraphics(int GraphicsIndex)
    {
        QualitySettings.SetQualityLevel(GraphicsIndex);
    }
    //Graphics Quality
    public void GQLowButtonEvent()
    {
        GQLowBtn.GetComponent<Image>().sprite = SelectedSprite;
        GQMediumBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        GQHighBtn.GetComponent<Image>().sprite = NotSelectedSprite;
    } 
    public void GQMediumButtonEvent()
    {
        GQMediumBtn.GetComponent<Image>().sprite = SelectedSprite;
        GQLowBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        GQHighBtn.GetComponent<Image>().sprite = NotSelectedSprite;
    }
    public void GQHighButtonEvent()
    {
        GQHighBtn.GetComponent<Image>().sprite = SelectedSprite;
        GQLowBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        GQMediumBtn.GetComponent<Image>().sprite = NotSelectedSprite;
    }
    //Screen refresh rate
    public void SRRLowButtonEvent()
    {
        SRRLowBtn.GetComponent<Image>().sprite = SelectedSprite;
        SRRMediumBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        SRRHighBtn.GetComponent<Image>().sprite = NotSelectedSprite;
    } 
    public void SRRMediumButtonEvent()
    {
        SRRMediumBtn.GetComponent<Image>().sprite = SelectedSprite;
        SRRLowBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        SRRHighBtn.GetComponent<Image>().sprite = NotSelectedSprite;
    }
    public void SRRHighButtonEvent()
    {
        SRRHighBtn.GetComponent<Image>().sprite = SelectedSprite;
        SRRLowBtn.GetComponent<Image>().sprite = NotSelectedSprite;
        SRRMediumBtn.GetComponent<Image>().sprite = NotSelectedSprite;
    }
    
   //Vibration
    public void OffBtnEvent()
    {
        OffBtn.GetComponent<Image>().sprite = SelectedSprite;
        OnBtn.GetComponent<Image>().sprite = NotSelectedSprite;
    }
    public void OnBtnEvent()
    {
        OnBtn.GetComponent<Image>().sprite = SelectedSprite;
        OffBtn.GetComponent<Image>().sprite = NotSelectedSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
