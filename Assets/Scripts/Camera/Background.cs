using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float backgroundSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x * backgroundSpeed, transform.position.y, transform.position.z);
    }
}

