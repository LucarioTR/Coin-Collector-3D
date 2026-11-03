using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 90f;

    void Update()
    {
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime, Space.World);
    }
}