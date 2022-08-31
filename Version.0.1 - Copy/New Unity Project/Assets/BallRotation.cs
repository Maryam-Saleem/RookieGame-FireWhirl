using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour
{
    public float _forceSize;
    private Rigidbody _rb;
    Vector3 _forceVector;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontaleInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        _forceVector = new Vector3(horizontaleInput, 0, verticalInput);
        _forceVector.Normalize();
       


    }
    void FixedUpdate()
    {
        _rb.AddForce(_forceVector * _forceSize);

    }
}
