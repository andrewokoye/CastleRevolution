using UnityEngine;

public class Hover : MonoBehaviour
{
    [SerializeField] private float movementDistance;
    private bool movingUp;
    private float topEdge;
    private float bottomEdge;

    private void Awake()
    {
        topEdge = transform.position.y + movementDistance / 10;
        bottomEdge = transform.position.y - movementDistance / 10;
    }

    private void Update()
    {
        if (movingUp)
        {
            if (transform.position.y < topEdge)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f * Time.deltaTime, transform.position.z);
            }
            else
            {
                movingUp = false;
            }
        }
        else
        {
            if (transform.position.y > bottomEdge)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f * Time.deltaTime, transform.position.z);
            }
            else
            {
                movingUp = true;
            }
        }
    }
}
