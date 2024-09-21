using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private float _raycastLength;

    [SerializeField] private LayerMask _layerMask;

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, _raycastLength, _layerMask);

        if (hit)
        {
            Debug.Log($"Hit: {hit.collider.name}");
        }
        else
        {
            Debug.Log($"No hit!");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, Vector2.right * _raycastLength);
    }
}
