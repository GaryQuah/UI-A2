using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProfilePageController : MonoBehaviour
{
    [SerializeField] Button personalButton;
    [SerializeField] Button statisticsButton;
    [SerializeField] Button backButton;

    private string currentButton = "personalButton";
    [SerializeField] Image personalImage;
    [SerializeField] Image statisticsImage;

    [SerializeField] Sprite NotSelectedSprite;
    [SerializeField] Sprite SelectedSprite;

    // Start is called before the first frame update
    void Start()
    {
        personalButton.onClick.AddListener(personalButtonEvent);
        statisticsButton.onClick.AddListener(statisticsButtonEvent);
        backButton.onClick.AddListener(backButtonEvent);
        statisticsImage.gameObject.SetActive(false);
    }

    public void backButtonEvent()
    {
        SceneManager.LoadScene("MainmenuScene", LoadSceneMode.Single);
    }

    public void personalButtonEvent()
    {
        currentButton = "personalButton";
        personalImage.gameObject.SetActive(true);
        statisticsImage.gameObject.SetActive(false);
        Debug.Log("personal clicked");

        personalButton.GetComponent<Image>().sprite = SelectedSprite;
        statisticsButton.GetComponent<Image>().sprite = NotSelectedSprite;
    }

    public void statisticsButtonEvent()
    {
        currentButton = "statisticsButton";
        statisticsImage.gameObject.SetActive(true);
        personalImage.gameObject.SetActive(false);
        Debug.Log("statistics clicked");

        personalButton.GetComponent<Image>().sprite = NotSelectedSprite;
        statisticsButton.GetComponent<Image>().sprite = SelectedSprite;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
