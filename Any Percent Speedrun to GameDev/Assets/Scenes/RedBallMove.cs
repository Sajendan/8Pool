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
    public int JumpForce;
    public MovementState LaufModus;
    public int Running;
    public CoolDown DashCooldown;
    public CoolDown JumpCooldown;
    public Transform orientation;




    public enum MovementState
    {
        Walking ,
        Running ,
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DashCooldown.updatetimer();
        JumpCooldown.updatetimer();
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
      

        Vector3 inputDirection = orientation.forward * vertical + orientation.right * horizontal;
        if (LaufModus == MovementState.Walking)
        {
            rb.AddForce(inputDirection * Time.deltaTime * Speed);
        }
        
        else
        {
            rb.AddForce(inputDirection * Time.deltaTime * Running);
        }
        
        if (Input.GetKeyDown(KeyCode.LeftShift)&& DashCooldown.TimerFinished()) 
        
        { 
            rb.AddForce(inputDirection * SpeedDash, ForceMode.Impulse);

            DashCooldown.ResetTimer();
        }


            


        if (Input.GetKeyDown(KeyCode.Space)&& JumpCooldown.TimerFinished())
        {
            rb.AddForce(Vector3.up * JumpForce , ForceMode.Impulse);

            JumpCooldown.ResetTimer();

        }

        print(horizontal + " " + vertical);

        MovementState auswahl = MovementState.Walking;

        if (Input.GetKey(KeyCode.LeftControl) ==  true)
            LaufModus = MovementState.Running;
        
        

        else
        {
            LaufModus = MovementState.Walking;
        }

        //LaufModus = Input.GetKey(KeyCode.RightControl) ? MovementState.Running : MovementState.Walking;
        //wenn der Input gedrückt wird also true dann das erste sonst das zweite?
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
