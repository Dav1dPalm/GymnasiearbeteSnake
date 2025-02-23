using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    EdgeCollider2D edgeCollider;
    private void Awake()
    {
        edgeCollider = this.GetComponent <EdgeCollider2D>();
        CreateEdgeCollider();
    }
    void CreateEdgeCollider()
    {
        List<Vector2> edges = new List<Vector2>();
        edges.Add(Camera.main.ScreenToWorldPoint(Vector2.zero));
        edges.Add(Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,0)));
        edges.Add(Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)));
        edges.Add(Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)));
        edges.Add(Camera.main.ScreenToWorldPoint(Vector2.zero));
        edgeCollider.SetPoints(edges);
    }

    void OnCollisisonEnter2D(Collision2D collision)
    {
        Rigidbody2D collidingRB = collision.transform.GetComponent<Rigidbody2D>();
        collidingRB.velocity = Vector3.zero;
    }
}
