using UnityEngine;

public class SmoothCamera2D : MonoBehaviour
{
    public Transform target;          // Player
    public float smoothSpeed = 10f;   // Higher = smoother
    public Vector3 offset;            // Camera offset from player

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null) return;

        // Desired camera position
       Vector3 desiredPos = new Vector3(
    target.position.x + offset.x,
    transform.position.y,   // lock Y
    transform.position.z
);


        // Smooth movement
        Vector3 smoothedPos = Vector3.SmoothDamp(
            transform.position,
            desiredPos,
            ref velocity,
            1f / smoothSpeed
        );

        transform.position = smoothedPos;
    }
}
