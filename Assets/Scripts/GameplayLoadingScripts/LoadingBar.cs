using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    private Slider loadingBar;
    private float progress = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        loadingBar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (progress < 1.0f)
            progress += 0.01f;

        loadingBar.value = progress;
    }
}
