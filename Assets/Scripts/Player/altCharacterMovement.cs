using UnityEngine;

public class altCharacterMovement : MonoBehaviour
{

    public Transform visualsTransform;
    [SerializeField] private Animator anim;

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");

        if (moveInput > 0)
        {
            anim.SetBool("isRunning", true);
            visualsTransform.transform.localEulerAngles = new Vector3(0f, 90f, 0f);
        }
        else if (moveInput < 0)
        {
            anim.SetBool("isRunning", true);
            visualsTransform.transform.localEulerAngles = new Vector3(0f, 270f, 0f);
        }
        else { anim.SetBool("isRunning", false); }
    }
}