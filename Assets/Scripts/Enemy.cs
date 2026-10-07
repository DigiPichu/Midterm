using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

        }

        if (collision.gameObject.CompareTag("PlayerAttack"))
        {
            Destroy(enemy);
        }
    }
}
