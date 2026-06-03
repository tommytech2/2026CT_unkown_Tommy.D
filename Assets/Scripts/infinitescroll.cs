using UnityEngine;

namespace TommyGame.Parallax
{
    public class PlayerParallaxLayer : MonoBehaviour
    {
        public Transform player;
        public float parallaxMultiplier = 0.2f;
        public Vector3 followOffset;

        private Material mat;
        private Vector3 lastPlayerPos;
        private float offsetX;

        void Start()
        {
            if (player == null)
                player = GameObject.FindWithTag("Player").transform;

            mat = GetComponent<Renderer>().sharedMaterial;
            lastPlayerPos = player.position;
        }

        void LateUpdate()
        {
            Vector3 delta = player.position - lastPlayerPos;

           
            transform.position = new Vector3(
                player.position.x + followOffset.x,
                transform.position.y, 
                transform.position.z
            );

           
            offsetX += -delta.x * parallaxMultiplier;
            offsetX -= Mathf.Floor(offsetX);

            mat.SetTextureOffset("_MainTex", new Vector2(offsetX, 0f));

            lastPlayerPos = player.position;
        }
    }
}
