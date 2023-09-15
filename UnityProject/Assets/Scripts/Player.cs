using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed = 10;
    private Rigidbody _rigidbody;
    private float _horizontalInput;
    private float _verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");  
    }

    private void FixedUpdate()
    {
        Vector3 dir = new Vector3(_horizontalInput, 0,  _verticalInput);
        if (dir.magnitude > 1f)
            dir = dir.normalized;
        _rigidbody.velocity = dir * speed;
    }
}
