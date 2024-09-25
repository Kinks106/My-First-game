using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipemid : MonoBehaviour
{
    // Start is called before the first frame update
    public logic Log;
    void Start()
    {
        Log = GameObject.FindGameObjectWithTag("logics").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.gameObject.layer==3)
        {
            Log.add_score();
        }

    }
}
