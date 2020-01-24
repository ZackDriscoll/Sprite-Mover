using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class SpriteMover : MonoBehaviour
{
    private Transform tf;

    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move up if the player presses up
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            //Only works if shift is held down
            if (Input.GetKey(KeyCode.UpArrow))
            {
                tf.position = tf.position + Vector3.up * 1.0f;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                tf.position = tf.position + Vector3.down * 1.0f;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                tf.position = tf.position + Vector3.right * 1.0f;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                tf.position = tf.position + Vector3.left * 1.0f;
            }
        }
        else
        {
            //Only works if shift isn't held down
            if (Input.GetKey(KeyCode.UpArrow))
            {
                tf.position = tf.position + Vector3.up * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                tf.position = tf.position + Vector3.down * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                tf.position = tf.position + Vector3.right * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                tf.position = tf.position + Vector3.left * Time.deltaTime;
            }
        }
        //This works if player is holding down shift or ISN'T holding down shift.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tf.position = new Vector3(0, 0, 0);
        }
    }
}
