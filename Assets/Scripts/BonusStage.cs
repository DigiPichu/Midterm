using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class BonusStage : MonoBehaviour
{
    public SceneTransition SceneTransition;
    public static float totalItems;
    public float TrueItems;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        totalItems = TrueItems;
    }

    // Update is called once per frame
    void Update()
    {
        if (BonusStageItems.bonusStageItems == 0)
        {
            SceneTransition.PauseAction();
            SceneTransition.Wait();
            SceneManager.LoadScene("Demo Stage 2");
            SceneTransition.ResumeAction();
        }
    }
}
