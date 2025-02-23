using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public int speed = 2;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.RightArrow)) { rb.velocity = Vector2.right * speed; }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) { rb.velocity = Vector2.left * speed; }
        else if (Input.GetKeyDown(KeyCode.UpArrow)) { rb.velocity = Vector2.up * speed; }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) { rb.velocity = Vector2.down * speed; }
        
    }

}
