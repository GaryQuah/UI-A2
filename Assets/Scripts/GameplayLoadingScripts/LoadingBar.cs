using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    private TextMeshProUGUI textmeshPro;

    private Slider loadingBar;
    private float progress = 0.0f;

    private 
    // Start is called before the first frame update
    void Start()
    {
        loadingBar = GetComponent<Slider>();

        GameObject tempGo = GameObject.Find("LoadingPercentage");

        textmeshPro = tempGo.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (progress < 1.0f)
            progress += 0.01f;

        textmeshPro.text = "Loading... " + (int)(progress * 100) + " / 100";

        loadingBar.value = progress;

        if (progress >= 1.0f)
        {
            SceneManager.LoadScene("GameplayScene", LoadSceneMode.Single);
        }
    }
}
