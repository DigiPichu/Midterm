using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerCharacterControllerAttackBehaviour : PlayerGroundAttack
{/*
    [SerializeField] private float attackFrames;
    private float attackModifier;

    private CharacterController controller;

    private void Start()
    { controller = GetComponent<CharacterController>(); }

    protected override void ApplyAttack()
    {
        ChangePlayerTag();
        Debug.Log("Pressed Attack");
    }
    public IEnumerator ChangePlayerTag()
    {
        gameObject.tag = "PlayerAttack";
        yield return new WaitForSeconds(attackFrames);
        gameObject.tag = "Player";

    }
    protected override void Attack()
    {  }*/
}
