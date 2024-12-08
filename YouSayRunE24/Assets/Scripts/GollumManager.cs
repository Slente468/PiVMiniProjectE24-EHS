using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GollumManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        print("I'm hit!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
