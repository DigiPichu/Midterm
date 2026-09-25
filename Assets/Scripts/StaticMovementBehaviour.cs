using UnityEngine;

public class StaticMovementBehaviour : MonoBehaviour
{
    public float speed = 2f;          // how fast it moves
    public float moveDistance = 3f;   // how far it moves from the start point

    private Vector3 startPos;
    private bool movingLeft = true;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float movement = speed * Time.deltaTime;

        if (movingLeft)
        {
            transform.position += Vector3.left * movement;

            if (transform.position.x <= startPos.x - moveDistance)
                movingLeft = false;
        }
        else
        {
            transform.position += Vector3.left * movement;

            if (transform.position.x >= startPos.x + moveDistance)
                movingLeft = true;
        }
    }
}