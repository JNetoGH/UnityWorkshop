using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private float _rotSpeed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(_target.transform.position, Vector3.up, Time.deltaTime * _rotSpeed);
    }
}
