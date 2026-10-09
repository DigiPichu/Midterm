using TMPro;
using UnityEngine;

public class StageUI : MonoBehaviour
{
    public TMP_Text collectableText;
    public TMP_Text lifeText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collectableText.text = $"Pon-De-Rings: {ScoreManager.PonDeRing}";
        lifeText.text = $"Life: {ScoreManager.Life}";
    }

    public void changePonDeRing(int amount)
    {
        ScoreManager.PonDeRing += amount;
        collectableText.text = "Pon-De-Ring: " + ScoreManager.PonDeRing;
    }

    public void changeLife(int amount)
    {
        ScoreManager.Life += amount;
        lifeText.text = "Life: " + ScoreManager.Life;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
