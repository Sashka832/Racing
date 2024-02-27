using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    public Vector2 turn;
    public float sensetivity = .5f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensetivity;
        turn.y += Input.GetAxis("Mouse Y") * sensetivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
