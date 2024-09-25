using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float FlapStrength;
    public logic Log;
    public bool Bird_Alive=true;
    public float Deadzone = -5;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Udankhatola";
        Log = GameObject.FindGameObjectWithTag("logics").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && Bird_Alive == true)
        {
            myRigidbody.velocity = Vector2.up * FlapStrength;
        }
        if (transform.position.y < Deadzone)
        {
            Log.Is_Hit();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            Log.Is_Hit();
            Bird_Alive = false;
    }
}
