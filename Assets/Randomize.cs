using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomize : MonoBehaviour
{
    float spawnTime = 0;
    [SerializeField] GameObject wallUp;
    [SerializeField] GameObject wallDown;

    // Update is called once per frame
    void Update()
    {
        spawnTime += Time.deltaTime;

        if (spawnTime >= 1.5f)
        {
            spawnTime -= 1.5f;

            WallScript up = Instantiate(wallUp, new Vector3(6, 4, 0), Quaternion.identity).GetComponent<WallScript>();
            WallScript down = Instantiate(wallDown, new Vector3(6, -4, 0), Quaternion.identity).GetComponent<WallScript>();

            float offset = Random.Range(-1f, 1f);
            up.transform.Translate(Vector3.up * offset);
            down.transform.Translate(Vector3.up * offset);
        }
    }
}