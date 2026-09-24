using UnityEngine;
using UnityEngine.Events;

public class PlayerGroundChecker : MonoBehaviour
{
    public Transform groundCheckTransform;
    public Vector3 groundCheckerObject;
    public UnityEvent<bool> BroadcastGrounded;
    public float groundDistance = 0.6f;
    public LayerMask groundLayer;

    // Update is called once per frame
    void Update()
    {
        bool grounded = false;

        //Ray ray = new Ray(groundCheckTransform.position, Vector3.down);
        //grounded = Physics.Raycast(ray, groundDistance);
        grounded = Physics.OverlapSphere(groundCheckerObject, groundDistance, groundLayer).Length > 0;

        BroadcastGrounded?.Invoke(grounded);
    }



}