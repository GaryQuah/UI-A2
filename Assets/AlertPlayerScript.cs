using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AlertPlayerScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textOne;
    [SerializeField] TextMeshProUGUI textTwo;
    [SerializeField] GameObject alertImage;

    [SerializeField] GameObject player;
    [SerializeField] GameObject enemyAI;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        alertImage.SetActive(false);
        textOne.gameObject.SetActive(false);
        textTwo.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int distanceBetweenPlayers = (int)Vector3.Distance(enemyAI.transform.position, player.transform.position) * 10;

        if (distanceBetweenPlayers <= 500)
        {
            alertImage.SetActive(true);
            textOne.gameObject.SetActive(true);
            textTwo.gameObject.SetActive(true);

            textOne.text = distanceBetweenPlayers.ToString() + " meters";
            textTwo.text = distanceBetweenPlayers.ToString() + " meters";
        }
        else
        {
            alertImage.SetActive(false);
            textOne.gameObject.SetActive(false);
            textTwo.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
