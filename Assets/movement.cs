using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody player;
    [SerializeField] float Movement = 150.0f;
    [SerializeField] float MovementBawah = 100.0f;
    public TextMeshProUGUI ScoreText;
    private int _score;
    //public float MovementKanan = 50.0f;

    private void UpdateScoreDisplay(string scoreEarned)
    {
        if (ScoreText != null)
        {
            ScoreText.SetText($"Score {scoreEarned}");
        }
    }
    // Update is called once per frame
    void Update()
    {
        player.AddForce(0, -MovementBawah * Time.deltaTime, 0);
        _score++;
        UpdateScoreDisplay(_score.ToString());
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.AddForce(0, Movement, 0);
            Debug.Log("keatas");
        }

        /*
        if (Input.GetKey(KeyCode.D))
        {
            player.AddForce(Movement * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.AddForce(-Movement * Time.deltaTime, 0, 0);
        }

        */


        /*if (Input.GetKey(KeyCode.S))
        {
            player.AddForce(0, -Movement * Time.deltaTime, 0);
        }
       
        //misal untuk spawning
        /*if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("habis ditekan dilepas");
        }

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("ditekan first time");
        }
        */
    }
}
