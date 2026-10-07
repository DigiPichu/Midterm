using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PlayerGroundAttack : MonoBehaviour
{
    public UnityEvent OnAttack;

    [SerializeField] private float attackFrames;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(ChangePlayerTag());
            Debug.Log("Pressed Attack");
        }
    }
    private IEnumerator ChangePlayerTag()
    {
        gameObject.tag = "PlayerAttack";
        Debug.Log("Player should be attack!");
        yield return new WaitForSeconds(attackFrames);
        gameObject.tag = "Player";
        Debug.Log("Player should be normal");

    }


    /*private bool isGrounded;
    private bool attackInput;

    void Update()
    {
        ApplyAttack();

        if (ShouldAttack())
        {
            Attack();
            OnAttack?.Invoke();
        }
    }

    protected virtual void ApplyAttack()
    { }

    protected abstract void Attack();

    private bool ShouldAttack()
    { return attackInput && isGrounded; }



    public void SetAttackInput(bool value)
    { attackInput = value; }
    */
}
