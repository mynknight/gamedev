using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{ 
    public float speed = 10;
    void Update()
    { Vector3 position=transform.position; 
        position.x +=speed * Time.deltaTime;
        transform.position = position;
    }
}
