using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;
    public Vector3 offset = new Vector3(0f, 0f, -10f);
    public float fixedYPosition = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;

        Vector3 targetPosition = target.position + offset;
        //transform.position = new Vector3(target.position.x, fixedYPosition, targetPosition.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
