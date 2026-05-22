using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    float timer = 0f;
    void Update()
    {
        
        timer += Time.deltaTime;
      
        if (timer >= 3)
        {
            float x = Random.Range(-10f, 10f);
            float y = Random.Range(-10f, 10f);
            transform.position = new Vector3(x, y, 0);
            timer = 0f;
        }
    }
}
