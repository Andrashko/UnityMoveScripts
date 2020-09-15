using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public float Force = 1f;
    // Start is called before the first frame update
    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rigidbody.velocity == Vector3.zero)
            rigidbody.AddForce(new Vector3(1, 1, 1) * Force);
    }
}
