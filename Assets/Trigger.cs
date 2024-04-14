using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene("GameOver");
    }
}
