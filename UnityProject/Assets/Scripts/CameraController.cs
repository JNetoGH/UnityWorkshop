using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CameraController : MonoBehaviour
{
    public float distanceFromPlayerInY = 0;
    public float distanceFromPlayerInZ = 0;

    private GameObject _player;
    private Vector3 compensationDistance;


    void MoveToPlayerPosition()
    {

        _player = GameObject.FindGameObjectWithTag("Player");

        // se tiver algo nas distancias move a camera pra lá no start, se n, deixa onde foi largada na Cena
        transform.position = new Vector3(_player.transform.position.x,
            distanceFromPlayerInY == 0 ? this.transform.position.y : _player.transform.position.y + distanceFromPlayerInY,
            distanceFromPlayerInZ == 0 ? this.transform.position.z : _player.transform.position.z + distanceFromPlayerInZ);
    }

    void Start()
    {
        MoveToPlayerPosition();
        compensationDistance = this.transform.position - _player.transform.position;
    }

    void Update()
    {
        this.transform.position = _player.transform.position + compensationDistance;
    }
}