using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float push = 50f;
    Rigidbody rb;

    [SerializeField] TMP_Text scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rb.AddForce(h * push, 0,v * push);
    }

    private void OnCollisionEnter(Collision other) 
    {
        score += 100;
        scoreText.text = score.ToString();
        Debug.Log("collisione, score = " + score);
    }
}
