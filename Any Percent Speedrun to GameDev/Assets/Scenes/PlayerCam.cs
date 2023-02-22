using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;
    public Transform orientation;
    public Transform cameratransform;
    private float xRot;
    private float yRot;



    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible= false;
    }

    // Update is called once per frame
    void Update()
    {
        
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y")* Time.deltaTime * sensY;

        xRot += mouseX;
        yRot -= mouseY;

        yRot = Mathf.Clamp(yRot, -90f, 90f);
        cameratransform.rotation = Quaternion.Euler(yRot, xRot, 0);
        orientation.rotation = Quaternion.Euler(0,xRot, 0);


    }
}
