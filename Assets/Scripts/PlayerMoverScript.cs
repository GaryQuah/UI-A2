using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMoverScript : MonoBehaviour
{
    private float moveSpeed = 0.0f;

    [SerializeField] private float rayCastDistance = 1.0f;
    [SerializeField] private float jumpForce = 10.0f;

    //RigidBody
    private Rigidbody rigidbody;

    private GameObject objectivesTrackerObject;

    private ObjectivesTracker objectivesTracker;

    // Start is called before the first frame update
    void Start()
    {
        //Reference to the rigidBody.
        rigidbody = GetComponent<Rigidbody>();

        //Reference to objectives
        objectivesTrackerObject = GameObject.Find("ObjectivesTracker");

        objectivesTracker = objectivesTrackerObject.GetComponent<ObjectivesTracker>();
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
        }
    }

    public float getSpeed()
    {
        return moveSpeed;
    }

    public void addToSpeed(float value)
    {
        moveSpeed += value;
    }

    private void move()
    {
        //A & D Key , Left & Right Arrow input
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        //W & S Key , Up & Down Arrow input
        float verticalAxis = Input.GetAxisRaw("Vertical");

        if (verticalAxis < 0)
            moveSpeed -= 1.5f;
        else if (verticalAxis >= 0)
        {
            if (moveSpeed < 200)
            {
                moveSpeed += 1.0f;

                objectivesTracker.setNitroActive(false);
            }
            else
                moveSpeed -= 0.1f;

            if (moveSpeed > 240)
                moveSpeed = 240;
        }

        Vector3 movement = new Vector3(0, 0, moveSpeed) * 0.002f;

        //Move based on the direction you are looking.
        Vector3 updatedPosition = rigidbody.position + rigidbody.transform.TransformDirection(movement);

        rigidbody.MovePosition(updatedPosition);
    }
}
