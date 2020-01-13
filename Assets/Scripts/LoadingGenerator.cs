using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingGenerator : MonoBehaviour
{
    public List<Sprite> Sprites = new List<Sprite>(); //List of Sprites added from the Editor to be created as GameObjects at runtime
    public GameObject ParentPanel; //Parent Panel you want the new Images to be children of

    private float loadingTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //loadingTimer += 1 * Time.deltaTime;

        //if ((int)loadingTimer % 5 == 0)
        //{
        //    GameObject newObject = new GameObject("LoadingBar_");

        //    RectTransform rectTransform = newObject.AddComponent<RectTransform>();

        //    rectTransform.sizeDelta = new Vector2(1, 1);
        //    Image image = newObject.AddComponent<Image>();
        //    image.sprite = sprite;
        //    newObject.transform.SetParent(canvas.transform, false);

        //    Debug.Log("Added an image component");
        //}
    }
}
