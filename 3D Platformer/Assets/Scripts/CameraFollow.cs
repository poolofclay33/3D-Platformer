using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform _player;

    public Vector3 offset;

    public bool useOffsetValue;

    public float rotateSpeed;

    public Transform pivot;

    private void Start()
    {
        if (!useOffsetValue)
        {
            offset = _player.position - transform.position;
        }

        pivot.transform.position = _player.transform.position;
        pivot.transform.parent = _player.transform;

        Cursor.lockState = CursorLockMode.Locked;
    }

    private void LateUpdate()
    {
        float horizontal = Input.GetAxisRaw("Mouse X") * rotateSpeed;
        _player.Rotate(0, horizontal, 0);

        /*
        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        pivot.Rotate(-vertical, 0, 0);
        */

        float desiredYAngle = _player.eulerAngles.y;
        float desiredXAngle = pivot.eulerAngles.x;
        Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
        transform.position = _player.position - (rotation * offset);

        if(transform.position.y < _player.position.y)
        {
            transform.position = new Vector3(transform.position.x, _player.position.y - .5f, transform.position.z);
        }

        transform.LookAt(_player);
    }
}
