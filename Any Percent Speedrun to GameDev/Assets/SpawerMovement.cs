using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawerMovement : MonoBehaviour     
{
    public GameObject Spawner;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool dKeyHoldDown = Input.GetKey(KeyCode.D);
        bool aKeyHoldDown = Input.GetKey(KeyCode.A);
        bool wKeyHoldDown = Input.GetKey(KeyCode.W);
        bool sKeyHoldDown = Input.GetKey(KeyCode.S);

        if (dKeyHoldDown)
        {
            transform.Translate(new Vector3(Speed,0,0) * Time.deltaTime);

        }

        if (aKeyHoldDown)
        {
            transform.Translate(new Vector3(-Speed, 0,0) * Time.deltaTime);

        }
        if (wKeyHoldDown)
        {
            transform.Translate(new Vector3(0, 0, Speed) * Time.deltaTime);

        }

        if (sKeyHoldDown)
        {
            transform.Translate(new Vector3(0, 0, -Speed) * Time.deltaTime);

        }
    }
}
