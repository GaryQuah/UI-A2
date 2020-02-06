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
    private void Start()
    {

    }
    public void SetText()
    {
        // text = username.GetComponents<TextMeshProUGUI>().
        text = usernameset.text.ToString();
        Debug.Log(text);
    }

    public string getname()
    {
        return text;
    }
    public void LoginButtonEvent()
    {
        SceneManager.LoadScene("MainmenuScene");
    }
}