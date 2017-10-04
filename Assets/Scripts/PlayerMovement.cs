using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;

    private Vector3 _forward = new Vector3(0f, 0f, 1f);
    private Vector3 _backward = new Vector3(0f, 0f, -1f);
    private Vector3 _right = new Vector3(1f, 0f, 0f);
    private Vector3 _left = new Vector3(-1f, 0f, 0f);
    private Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(_forward * speed * Time.deltaTime);
            rb.velocity = _forward * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(_left * speed * Time.deltaTime);
            rb.velocity = _left * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(_backward * speed * Time.deltaTime);
            rb.velocity = _backward * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(_right * speed * Time.deltaTime);
            rb.velocity = _right * speed;
        }

    }

}
