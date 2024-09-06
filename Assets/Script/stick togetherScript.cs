using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sticktogetherScript : MonoBehaviour
{
    GameObject Player;
    Vector3 PlayerPos;
    Vector3 Distance;

    Rigidbody rb;

    Vector3 def;
    Vector3 _parent;
    Vector3 before;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerPos = other.transform.position;

            Distance = transform.position - PlayerPos;
            Distance = Distance * 0.7f;
            transform.position = PlayerPos + Distance;
 
            this.transform.parent = other.transform;
            rb = GetComponent<Rigidbody>();
            Destroy(rb );

        }
    }
}
