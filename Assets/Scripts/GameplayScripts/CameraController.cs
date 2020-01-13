using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float lookSensitivity;
    [SerializeField] private float smoothingHorizontal;
    [SerializeField] private float smoothingVertical;

    //Get a reference to the camera
    public GameObject player;

    private Vector3 offSet;
    private Vector2 smoothedVelocity;
    private Vector2 lookAtPosition;

    // Start is called before the first frame update
    void Start()
    {
        player = transform.parent.gameObject;
        Screen.lockCursor = true;
    }

    private void Update()
    {
        RotateCamera();
        checkForShootCollision();
    }

    private void RotateCamera()
    {
        //Get input from mouse.
        Vector2 inputValues = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        //Scale input from mouse according to sensitivity settings
        inputValues = Vector2.Scale(inputValues, new Vector2(lookSensitivity * smoothingHorizontal, lookSensitivity * smoothingVertical));

        //Interpolation - Range for how much u want the screen to 'slide'. range from 0 to 1
        smoothedVelocity.x = Mathf.Lerp(smoothedVelocity.x, inputValues.x, 1.0f / smoothingHorizontal);
        smoothedVelocity.y = Mathf.Lerp(smoothedVelocity.y, inputValues.y, 1.0f / smoothingVertical);

        lookAtPosition += smoothedVelocity;

        //Do the looking.
        //Up and down rotation. Only rotate the camera as we dont want the player to be flipping about the y axis.
        //Quaternion is a struct that handles rotations - Rotate by an amount about the right axis
       // transform.localRotation = Quaternion.AngleAxis(-lookAtPosition.y, Vector3.right);
        //Left and right. Rotate the player based off the mouse rotation.
        player.transform.localRotation = Quaternion.AngleAxis(lookAtPosition.x, player.transform.up);
    }

    private void checkForShootCollision()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    RaycastHit objectHit;

        //    if (Physics.Raycast(transform.position, transform.forward, out objectHit, Mathf.Infinity))
        //    {
        //        if (objectHit.collider.gameObject.name.Contains("Target"))
        //        {
        //            GameObject currentObject;

        //            //if (objectHit.collider.gameObject.transform.parent)
        //            //{
        //            //    currentObject = objectHit.collider.gameObject.GetComponentInParent;
        //            //}


        //            Destroy(objectHit.collider.gameObject, 0.0f);

        //            Debug.Log(objectHit.collider.name);
        //        }
        //    }
        //}
    }
}
