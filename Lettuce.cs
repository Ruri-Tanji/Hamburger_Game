using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lettuce : MonoBehaviour
{
    GameObject pans;

    // Start is called before the first frame update
    void Start()
    {
        this.pans = GameObject.Find("pans");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.009f, 0);

        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
            Debug.Log("GameOver");
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.pans.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.2f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            Vector3 pos = transform.position;
            pos.y = -4.2f;
            transform.position = pos;
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(-1, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Translate(1, 0, 0);
            }
        }

    }
}
