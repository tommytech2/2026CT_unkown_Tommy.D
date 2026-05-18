using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    public LineRenderer line;
    public LayerMask grappleLayer;
    public float maxDistance = 15f;
    public float pullSpeed = 10f;

    private Vector2 grapplePoint;
    private bool isGrappling = false;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        line.positionCount = 0;
    }

    void Update()
    {
        // Fire grappling hook
        if (Input.GetMouseButtonDown(1)) // Right mouse button
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mousePos - (Vector2)transform.position;

            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, maxDistance, grappleLayer);

            if (hit.collider != null)
            {
                grapplePoint = hit.point;
                isGrappling = true;

                line.positionCount = 2;
                line.SetPosition(0, transform.position);
                line.SetPosition(1, grapplePoint);
            }
        }

        // Release grappling hook
        if (Input.GetMouseButtonUp(1))
        {
            isGrappling = false;
            line.positionCount = 0;
        }

        // Update rope line
        if (isGrappling)
        {
            line.SetPosition(0, transform.position);
        }
    }

    void FixedUpdate()
    {
        if (isGrappling)
        {
            Vector2 direction = (grapplePoint - (Vector2)transform.position).normalized;
            rb.linearVelocity = direction * pullSpeed;

            // Auto-release when close
            if (Vector2.Distance(transform.position, grapplePoint) < 1f)
            {
                isGrappling = false;
                line.positionCount = 0;
            }
        }
    }
}
