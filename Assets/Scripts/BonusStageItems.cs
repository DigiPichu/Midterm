using UnityEditor.SceneManagement;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class BonusStageItems : MonoBehaviour
{
    public int value;

    public static float bonusStageItems;
    public DestroyBonus DestroyBonus;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       bonusStageItems = BonusStage.totalItems;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("PlayerAttack") || other.gameObject.CompareTag("PlayerAttackJump"))
        {
            //DestroyBonus.changeDestroy(value);
            BonusStageItems.bonusStageItems--;
            Debug.Log(bonusStageItems);
        }
    }
}
