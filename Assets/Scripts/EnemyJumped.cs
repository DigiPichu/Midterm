using UnityEngine;

public class EnemyJumped : MonoBehaviour
{
    [SerializeField] GameObject enemy;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerAttackJump"))
        {
            Destroy(enemy);
        }
} 
}
