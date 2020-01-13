using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIClampToWorld : MonoBehaviour
{
    private TextMeshProUGUI textmeshPro;

    private Canvas theCanavs;

    // Start is called before the first frame update
    void Start()
    {
        GameObject tempGo = GameObject.Find("PositioningBackground");
        textmeshPro = tempGo.GetComponent<TextMeshProUGUI>();

        tempGo = GameObject.Find("PositioningTrackerCanvas");

        theCanavs = tempGo.GetComponent<Canvas>();

        theCanavs.renderMode = RenderMode.ScreenSpaceOverlay;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 namePose = Camera.main.WorldToScreenPoint(this.transform.position);
        textmeshPro.transform.position = namePose;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "RaceCar")
            theCanavs.gameObject.SetActive(false);
    }
}
