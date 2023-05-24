using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,2 * Time.deltaTime,0 );
    }

    private void OnCollisionEnter(Collision other) 
    {
        gameObject.SetActive(false);    
    }
}
