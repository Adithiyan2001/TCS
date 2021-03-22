using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody rb;
    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();
    }

    private void playerMove()
    {
        float x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        //float z = Input.GetAxis("Vertical")*Time.deltaTime*speed;
       // rb.velocity = new Vector3(x, 0, z) * speed;


         transform.Translate(x, 0, 0);

    }
}
