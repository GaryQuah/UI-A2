using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Login : MonoBehaviour
{
    public GameObject canvas;
    private InputField username;
    Text input;

    UserInfo user;
    private void Start()
    {
        input = canvas.transform.Find("Username Input/Text").GetComponent<Text>();
    }
    public void LoginButton()
    {
        if (username != null)
        {
            user.SetUsername(input.text);
        }
       
        SceneManager.LoadScene("Mainmenuscene");

    }

}
