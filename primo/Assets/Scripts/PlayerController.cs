using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float push = 50f;
    Rigidbody rb;

    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text timeText;
    private int score = 1000;
    private float malusScore = 0;
    private float timeSofar = 0;


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
        rb.AddForce(h * push * Time.deltaTime, 0, v * push * Time.deltaTime);
        timeSofar += Time.deltaTime;
        timeText.text = timeSofar.ToString("0");
        if(malusScore<1)
        {
            malusScore += Time.deltaTime;
        }
        else
        {
            malusScore = 0;
            score -= 10;
            scoreText.text = score.ToString();
        }
        Debug.Log("malusScore: " + malusScore);
    }

    private void OnCollisionEnter(Collision other) 
    {
        score += 100;
        scoreText.text = score.ToString();
        // Debug.Log("collisione, score = " + score);
    }
}
