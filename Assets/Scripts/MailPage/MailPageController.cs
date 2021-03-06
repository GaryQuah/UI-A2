﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MailPageController : MonoBehaviour
{
    [SerializeField] Button eventsButton;
    [SerializeField] Button rewardsButton;
    [SerializeField] Button invitationsButton;
    [SerializeField] Button backButton;
    [SerializeField] Button openMailButton;
    [SerializeField] Button claimButton;
    [SerializeField] Button deleteButton;
    [SerializeField] Button acceptButton;

    [SerializeField] Sprite NotSelectedSprite;
    [SerializeField] Sprite SelectedSprite;

    [SerializeField] Sprite mailSprite;
    [SerializeField] Sprite mailContentSprite;

    [SerializeField] Image mailScreen;

   

    // Start is called before the first frame update
    void Start()
    {
        eventsButton.onClick.AddListener(eventsButtonEvent);
        rewardsButton.onClick.AddListener(rewardsButtonEvent);
        invitationsButton.onClick.AddListener(invitationsButtonEvent);
        backButton.onClick.AddListener(backButtonEvent);
        openMailButton.onClick.AddListener(openMailButtonEvent);

        deleteButton.onClick.AddListener(backToMail);

        claimButton.gameObject.SetActive(false);
        deleteButton.gameObject.SetActive(false);
        acceptButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        bool tempBool = false;

        if (rewardsButton.GetComponent<Image>().sprite == SelectedSprite && 
            mailScreen.GetComponent<Image>().sprite == mailContentSprite)
        {
            claimButton.gameObject.SetActive(true);
            deleteButton.gameObject.SetActive(true);
            tempBool = true;
        }
        else if (tempBool == false)
        {
            claimButton.gameObject.SetActive(false);
            deleteButton.gameObject.SetActive(false);
        }
        //
        if (eventsButton.GetComponent<Image>().sprite == SelectedSprite &&
           mailScreen.GetComponent<Image>().sprite == mailContentSprite)
        {
            deleteButton.gameObject.SetActive(true);
            tempBool = true;
        }
        else if (tempBool == false)
        {
            deleteButton.gameObject.SetActive(false);
        }

        if (invitationsButton.GetComponent<Image>().sprite == SelectedSprite)
        {
            acceptButton.gameObject.SetActive(true);
            tempBool = true;
        }
        else if (tempBool == false)
        {
            acceptButton.gameObject.SetActive(false);
        }
    }

    public void backToMail()
    {
        mailScreen.GetComponent<Image>().sprite = mailSprite;
    }

    public void openMailButtonEvent()
    {
        if (invitationsButton.GetComponent<Image>().sprite != SelectedSprite)
            mailScreen.GetComponent<Image>().sprite = mailContentSprite;
    }

    public void eventsButtonEvent()
    {
        //personalImage.gameObject.SetActive(true);
        //statisticsImage.gameObject.SetActive(false);
        eventsButton.GetComponent<Image>().sprite = SelectedSprite;
        rewardsButton.GetComponent<Image>().sprite = NotSelectedSprite;
        invitationsButton.GetComponent<Image>().sprite = NotSelectedSprite;
        mailScreen.GetComponent<Image>().sprite = mailSprite;
    }

    public void rewardsButtonEvent()
    {
        rewardsButton.GetComponent<Image>().sprite = SelectedSprite;
        eventsButton.GetComponent<Image>().sprite = NotSelectedSprite;
        invitationsButton.GetComponent<Image>().sprite = NotSelectedSprite;
        mailScreen.GetComponent<Image>().sprite = mailSprite;
    }

    public void invitationsButtonEvent()
    {
        invitationsButton.GetComponent<Image>().sprite = SelectedSprite;
        eventsButton.GetComponent<Image>().sprite = NotSelectedSprite;
        rewardsButton.GetComponent<Image>().sprite = NotSelectedSprite;
        mailScreen.GetComponent<Image>().sprite = mailSprite;
    }

    public void backButtonEvent()
    {
        if (mailScreen.GetComponent<Image>().sprite == mailContentSprite)
         mailScreen.GetComponent<Image>().sprite = mailSprite;
        else
         SceneManager.LoadScene("MainmenuScene", LoadSceneMode.Single);
    }
}
