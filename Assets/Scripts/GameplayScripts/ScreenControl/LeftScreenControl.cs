using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LeftScreenControl : MonoBehaviour
{
    private Button button;
    private bool mousedown = false;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(onPointerDown);
    }

    void onPointerDown()
    {
        Debug.Log("Button Down ! ");
        mousedown = true;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
