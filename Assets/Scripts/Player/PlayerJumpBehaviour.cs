using UnityEngine;
using UnityEngine.Events;

public abstract class PlayerJumpBehaviour : MonoBehaviour
{
    public UnityEvent OnJump;

    [SerializeField] protected float force;

    public static bool isGrounded;
    private bool jumpInput;

    private void Update()
    {

        ApplyJump();

        if (ShouldJump())
        {
            Jump();
            OnJump?.Invoke();
        }

        if (isGrounded == false)
        {
            gameObject.tag = "PlayerAttackJump";
        }
        if (isGrounded == true && PlayerGroundAttack.isAttack == false)
        {
            gameObject.tag = "Player";
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy Detected, now jumping");
            ApplyJump();
            Jump();
            OnJump?.Invoke();
        }
    }

    protected virtual void ApplyJump()
    { }

    protected abstract void Jump();

    private bool ShouldJump()
    { return jumpInput && isGrounded; }

    public void SetGrounded(bool value)
    { isGrounded = value; }

    public void SetJumpInput(bool value)
    { jumpInput = value; }
}