using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float Move_speed = 5;
    public float Deadzone = -14;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * Move_speed) * Time.deltaTime;
        if(transform.position.x<Deadzone)
        {
            Debug.Log("PipeDeleted");
            Destroy(gameObject);       
        }
    }
}
