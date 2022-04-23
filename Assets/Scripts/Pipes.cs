using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] float pipeSpeed = 5f;
    float leftEdge;

    private void Start()
    {
        leftEdge = cam.ScreenToWorldPoint(Vector3.zero).x - 1;
    }
    private void Update()
    {
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
        if (transform.position.x < leftEdge)
        {
            Destroy(this.gameObject);
        }
    }
}