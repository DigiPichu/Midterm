using Unity.VisualScripting;
using UnityEngine;

public class PlayerJumpAttack : MonoBehaviour
{
    [SerializeField] private float decay;
    [SerializeField] private float jumpModifier;


    private void OnCollisionEnter(Collision collision)
    {
        if (CompareTag("Enemy")){
            ApplyJump();
        }
    }

    private void ApplyJump()
    {
        jumpModifier = jumpModifier - decay * Time.deltaTime;
        if (jumpModifier < 0)
        {
            jumpModifier = 0;
        }

        Vector3 movementVector = Physics.gravity;
        movementVector += Vector3.up * jumpModifier;
    }


    void Update()
    {


    }
}
