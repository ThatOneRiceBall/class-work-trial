using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { }
        public float forceMult = 10.0f;
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 force = new Vector3(h, 0.0f, v) * forceMult;
        GetComponent<Rigidbody>().AddForce(force);
    }
}

    // Update is called once per fram
