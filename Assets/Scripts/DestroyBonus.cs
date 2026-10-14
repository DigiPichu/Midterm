using TMPro;
using UnityEngine;

public class DestroyBonus : MonoBehaviour
{

    public TMP_Text destroyText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        destroyText.text = $"Destroy Them All: {BonusStageItems.bonusStageItems}";
    }

    void Update()
    {
        destroyText.text = $"Destroy Them All: {BonusStageItems.bonusStageItems}";
    }

    public void changeDestroy(int amount)
    {
        ScoreManager.PonDeRing += amount;
        destroyText.text = "Destroy Them All: " + BonusStageItems.bonusStageItems;
    }
}
