using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float turnSpeed;
    public Text scoreText;
    public int score;
    public float timeOutLength;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = timeOutLength;
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;
        if(timer < 0 )
        {
            scoreText.text = "Game Over";
        } else
        {
            scoreText.text = score.ToString();
        }

        
        if (Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0, 0, -Time.deltaTime * turnSpeed));
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0, 0, Time.deltaTime * turnSpeed));
        }

        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        score++;
        timer = timeOutLength;
    }
}
