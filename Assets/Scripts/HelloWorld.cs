using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private Vector2 v2;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log($"GetButtonDown Frame {Time.frameCount}");
        }
        
        if (Input.GetButton("Jump"))
        {
            Debug.Log($"GetButton Frame {Time.frameCount}");
        }

        Vector3 pos = transform.position;
        pos.x += move;
    }
}
