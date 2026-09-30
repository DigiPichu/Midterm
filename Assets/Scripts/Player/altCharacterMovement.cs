using UnityEngine;

public class altCharacterMovement : MonoBehaviour
{

    public Transform visualsTransform;
    private bool facingRight = true;

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");

        if (moveInput > 0 && !facingRight)
        {
            FlipVisuals();
        }
        else if (moveInput < 0 && facingRight)
        {
            FlipVisuals();
        }
    }

    void FlipVisuals()
    {
        facingRight = !facingRight;
        visualsTransform.Rotate(0f, 180f, 0f);
    }
}