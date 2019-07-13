using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public Transform playerObject;
    public float distanceFromObject = 10f;
    void Update()
    {
        Vector3 lookOnObject = playerObject.position - transform.position;
        lookOnObject = playerObject.position - transform.position;
        transform.forward = lookOnObject.normalized;
        Vector3 playerLastPosition;
        playerLastPosition = playerObject.position - lookOnObject.normalized * distanceFromObject;
        playerLastPosition.y = playerObject.position.y + distanceFromObject/4;
        transform.position = playerLastPosition;
    }
}