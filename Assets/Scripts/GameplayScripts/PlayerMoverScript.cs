using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMoverScript : MonoBehaviour
{
    private float moveSpeed = 0.0f;

    [SerializeField] private float rayCastDistance = 1.0f;
    [SerializeField] private float jumpForce = 10.0f;
    [SerializeField] private ParticleSystem SmokeCloud;

    private Rigidbody rigidbody;

    private GameObject objectivesTrackerObject;

    private ObjectivesTracker objectivesTracker;

    private RawImage windImage;

    private AudioSource engineAudio;

    private bool breaking = false;

    private AudioSource finishingLineAudio;

    // Start is called before the first frame update
    void Start()
    {
        //Reference to the rigidBody.
        rigidbody = GetComponent<Rigidbody>();
        engineAudio = GetComponent<AudioSource>();

        GameObject temp = GameObject.Find("FinishingLine");
        finishingLineAudio = temp.GetComponent<AudioSource>();

        engineAudio.volume = 0;
        //Reference to objectives
        objectivesTrackerObject = GameObject.Find("ObjectivesTracker");

        objectivesTracker = objectivesTrackerObject.GetComponent<ObjectivesTracker>();

        //Getting a reference to the wind effect image.
        GameObject tempGo = GameObject.Find("WindImageEffect");

        windImage = tempGo.GetComponent<RawImage>();
        windImage.enabled = false;
    }

    public void slowDown()
    {
        breaking = true;

            moveSpeed -= 1.5f;
        Debug.Log("Breaking ! ");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (objectivesTracker.getNitro() >= 0.25f)
                objectivesTracker.activateNitro();
        }
        move();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FinishingLine")
        {
            objectivesTracker.updateCurrentLap();
            finishingLineAudio.Play();
        }
    }

    public float getSpeed()
    {
        return moveSpeed;
    }

    public void addToSpeed(float value)
    {
        if (moveSpeed >= -20)
            moveSpeed += value;
    }

    private void move()
    {
        //A & D Key , Left & Right Arrow input
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        //W & S Key , Up & Down Arrow input
        float verticalAxis = Input.GetAxisRaw("Vertical");

        var main = SmokeCloud.main;
        main.simulationSpeed = moveSpeed / 20;

        if (main.simulationSpeed <= 0)
            main.simulationSpeed = 0.1f;

        engineAudio.volume = moveSpeed / 2000;

        if (verticalAxis >= 0 && breaking == false)
        {
            if (moveSpeed < 200)
            {
                moveSpeed += 30.0f * Time.deltaTime;

                objectivesTracker.setNitroActive(false);
                windImage.enabled = false;
            }
            else
            {
                moveSpeed -= 15.0f * Time.deltaTime;

            }

            if (moveSpeed > 240)
                moveSpeed = 240;
        }

        if (objectivesTracker.getNitroActive())
        {
            windImage.enabled = true;
        }


        if (Time.timeScale > 0)
        {
            Vector3 movement = new Vector3(0, 0, moveSpeed) * 0.002f;

            //Move based on the direction you are looking.
            Vector3 updatedPosition = rigidbody.position + rigidbody.transform.TransformDirection(movement);

            rigidbody.MovePosition(updatedPosition);
        }
    }
}
