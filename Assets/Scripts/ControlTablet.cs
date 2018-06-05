using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTablet : MonoBehaviour {

    public GameObject moveTablet;

    public int moveSpeed = 10;

    private void Start()
    {
        moveTablet = GameObject.Find("gmo_MoveWhenDraged"); 
    }

    private void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
        {
            moveTablet.transform.Translate(Vector2.up * moveSpeed * Time.unscaledDeltaTime);
            if (moveTablet.transform.position.y > 940)
            {
                moveTablet.transform.position = new Vector2(moveTablet.transform.position.x, 940);
            }
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
        {
            moveTablet.transform.Translate(Vector2.down * moveSpeed * Time.unscaledDeltaTime);
            if (moveTablet.transform.position.y < 400)
            {
                moveTablet.transform.position = new Vector2(moveTablet.transform.position.x, 400);
            }
        }
    }
}
