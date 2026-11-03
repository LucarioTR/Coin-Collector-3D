using UnityEngine;

public class CoinFloat : MonoBehaviour
{
    [SerializeField] private float height = 0.5f;
    [SerializeField] private float speed = 2f;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newY = startPosition.y + Mathf.PingPong(Time.time * speed, height);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}