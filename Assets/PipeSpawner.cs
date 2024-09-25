using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{   
    public GameObject Pipe;
    public float Spawnrate=2;
    private float timer = 0;
    public float heightOFFSEt=5;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < Spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
        
    }
    
    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOFFSEt;
        float highestpoint=transform.position.y + heightOFFSEt;
        Instantiate(Pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestpoint),0), transform.rotation);
    }
}
