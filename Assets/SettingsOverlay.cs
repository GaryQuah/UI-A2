using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsOverlay : MonoBehaviour
{
    Canvas settings;
    // Start is called before the first frame update
    void Start()
    {
        settings = GetComponent<Canvas>();
        settings.renderMode = RenderMode.ScreenSpaceOverlay;
        settings.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
