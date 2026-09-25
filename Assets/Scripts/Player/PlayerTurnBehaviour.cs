using UnityEngine;

public class PlayerTurnBehaviour : MonoBehaviour
{
    /*[SerializeField] private float turnSpeed;
    private float rotation = 0;

    private float turnInput;

    private void Update()
    {
        if (Input.GetButton("Horizontal"))
            TurnLeft();
        else if (Input.GetButton("Horizontal"))
            TurnRight(); 
    }

    private void TurnLeft()
    {
        transform.Rotate(0f, 180f, 0f);
    }


    private void TurnRight()
    {
        transform.Rotate(0f, 180f, 0f);
    }*/
    private bool isFacingRight = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            FlipLeft();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            FlipRight();
        }
    }

    void FlipLeft()
    {
        if (isFacingRight == false)
        {
            isFacingRight = !isFacingRight;


            transform.rotation *= Quaternion.Euler(0, 180, 0);
        }
    }
    void FlipRight()
    {
        if (isFacingRight == true)
        {
            isFacingRight = true;


            transform.rotation *= Quaternion.Euler(0, -180, 0);
        }
    }

}