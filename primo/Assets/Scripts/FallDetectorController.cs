using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDetectorController : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) 
   {
        SceneManager.LoadScene(1);
   }
}
