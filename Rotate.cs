using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
     private float propellorSpeed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

void Update() {
transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);
}
}

