using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslateDoors : MonoBehaviour
{
    private RawImage leftDoor;
    private RawImage rightDoor;

    private RectTransform doorRect;

    private float translateBy = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject tmpGo = GameObject.Find("Left_Door");
        leftDoor = tmpGo.GetComponent<RawImage>();

        tmpGo = GameObject.Find("Right_Door");

        rightDoor = tmpGo.GetComponent<RawImage>();

        doorRect = leftDoor.rectTransform;
    }

    // Update is called once per frame
    void Update()
    {
        if (translateBy < (doorRect.rect.width * doorRect.localScale.x))
        {
            float moveBy = 10.0f;

            translateBy += moveBy;
            leftDoor.transform.Translate(new Vector3(moveBy, 0, 0));
            rightDoor.transform.Translate(new Vector3(-moveBy, 0, 0));
        }
    }
}
