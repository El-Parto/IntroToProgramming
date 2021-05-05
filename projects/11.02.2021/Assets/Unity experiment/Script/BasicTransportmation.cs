using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTransportmation : MonoBehaviour
{
    [SerializeField]
    private bool rotate = false;
    [SerializeField, Range(-1, 1)]
    private float rotateSpeed = 0.5f;
    [SerializeField]
    private bool scale = false;
    [SerializeField, Min(5)]
    private float scaleSpeed = 0.5f;
    [SerializeField, Range(-1, 1)]
    private float moveSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()

    {




    }

    // Update is called once per frame
    void Update()
    {
        if (rotate)
        {
            transform.Rotate(Vector3.forward, Time.deltaTime * rotateSpeed);
        }
        else if(scale)
        {
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        }
        else
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }
        
    }
}