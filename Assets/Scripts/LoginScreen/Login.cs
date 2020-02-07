using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Login : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI usernameset;
    string text = "";
    //  UserInfo user;
    public UserInfo user;
    private void Start()
    {

    }
    public void SetText()
    {
        text = usernameset.text.ToString();
        user.Username = text;
        Debug.Log(text);
    }

    public void LoginButtonEvent()
    {
        SceneManager.LoadScene("MainmenuScene");
    }
}