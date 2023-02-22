using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;

public class RedBallMove : MonoBehaviour
   
    
    
{
    public Rigidbody rb;
    public int Speed;
    public int SpeedDash;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
      

        Vector3 inputDirection = Vector3.forward * vertical + Vector3.right * horizontal;

        rb.AddForce(inputDirection * Time.deltaTime * Speed);
        if (Input.GetKeyDown(KeyCode.Space)) 
        
        { 
            rb.AddForce(inputDirection * SpeedDash, ForceMode.Impulse);
        }
        


        print(horizontal + " " + vertical);

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 inputDirection = Vector3.forward * vertical + Vector3.right * horizontal;
        Gizmos.DrawRay(transform.position, inputDirection);
    }
}
