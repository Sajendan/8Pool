using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public Material redMaterial;
    public int anzahl;
    public string penis;

    public float SpawnTime;
    public float ZeitBisZumNächstenSpawn;
    public int Force;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        ZeitBisZumNächstenSpawn = SpawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        bool sKeyPressed = Input.GetKeyDown(KeyCode.S);
        bool dKeyHoldDown = Input.GetKey(KeyCode.D);
        bool sKeyHoldDown = Input.GetKey(KeyCode.S);
        bool aKeyHoldDown = Input.GetKey(KeyCode.A);
        bool MouseButton = Input.GetMouseButton(0);
        bool MouseButtonHoldDown = Input.GetMouseButtonDown(0);




        if (dKeyHoldDown == true && sKeyPressed == true)  {

            Instantiate(cubePrefab, transform.position + new Vector3(0,0,-10), Quaternion.identity);



        
        
        }

        if (aKeyHoldDown == true && sKeyPressed == true)
        {

            Instantiate(cubePrefab, transform.position + new Vector3(0, 0, 10), Quaternion.identity);





        }

        ZeitBisZumNächstenSpawn -= Time.deltaTime;
        if(ZeitBisZumNächstenSpawn <= 0 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            SpikeSpawn();
            ZeitBisZumNächstenSpawn = SpawnTime;
            

        }


        // Instantiate(gameObject, position, rot2ation);
    }

          
    public void SpikeSpawn()


    {
       GameObject spawnedCube = Instantiate(cubePrefab, transform.position + new Vector3(0,0,0), Quaternion.identity);
       Rigidbody spawnedCubeRigidbody = spawnedCube.GetComponent<Rigidbody>();
        spawnedCubeRigidbody.AddForce(new Vector3(100f, 0f, 0f));

        print("PEnis");
    }
    public void RoterCubeSpawn(int anzahl2)
    {


        for (int i = 0; i < anzahl2; i++)
        {
            GameObject spawnedCube = Instantiate(cubePrefab, transform.position + new Vector3 (0,0,0), Quaternion.identity);
            spawnedCube.GetComponent<MeshRenderer>().material = redMaterial;
        }
    }
}
