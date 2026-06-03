using UnityEngine;

namespace TommyGame.CameraSystem
{
    public class SmoothCameraFollow : MonoBehaviour
    {
        public Transform target;       // your player
        public float smoothSpeed = 10f;
        public Vector3 offset;         // camera offset from player

        private Vector3 velocity = Vector3.zero;

        void LateUpdate()
        {
            if (target == null) return;

            Vector3 desiredPos = target.position + offset;

            // Smooth damp = buttery smooth movement
            Vector3 smoothedPos = Vector3.SmoothDamp(
                transform.position,
                desiredPos,
                ref velocity,
                1f / smoothSpeed
            );

            transform.position = smoothedPos;
        }
    }
}
