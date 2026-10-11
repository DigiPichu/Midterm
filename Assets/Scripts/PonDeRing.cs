using UnityEngine;

public class PonDeRing : MonoBehaviour
{
    public int value;
    [SerializeField] private int lifeValue = 1;

    // Add an instance reference to StageUI
    public StageUI stageUI;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("PlayerAttack") || other.gameObject.CompareTag("PlayerAttackJump"))
        {
            stageUI.changePonDeRing(value);
            Destroy(gameObject);
            Debug.Log ($"Pon-De-Rings: {ScoreManager.PonDeRing}");
        }
        if (other.gameObject.CompareTag("Player") && ScoreManager.PonDeRing > 99 || other.gameObject.CompareTag("PlayerAttack") && ScoreManager.PonDeRing > 99 || other.gameObject.CompareTag("PlayerAttackJump") && ScoreManager.PonDeRing > 99)
        {
            stageUI.changeLife(lifeValue);
            ScoreManager.PonDeRing = 0;
            stageUI.changePonDeRing(value);
            Destroy(gameObject);
            Debug.Log($"Life: {ScoreManager.Life}");
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}