using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipecreator : MonoBehaviour
{
    public float generateTime;
    public GameObject pipe;
    float time=0;
    public float maxHeight;
    public float minHeight;
    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime;
       
        if(time>generateTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-minHeight, maxHeight),0);
            Destroy(newpipe, 6);
            time = 0;
        }
        
    }
}
