using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

public class DeathPlane : MonoBehaviour
{

    [SerializeField] private int lifeValue = -1;
    public SceneTransition SceneTransition;
    // Add an instance reference to StageUI
    public StageUI stageUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && ScoreManager.Life > 0 || other.gameObject.CompareTag("PlayerAttack") && ScoreManager.Life > 0 || other.gameObject.CompareTag("PlayerAttackJump") && ScoreManager.Life > 0)
        {
            Debug.Log("Touched a Player");
            SceneTransition.PauseAction();
            SceneTransition.Wait();
            SceneManager.LoadScene("Stage Select");
            stageUI.changeLife(lifeValue);
            SceneTransition.ResumeAction();
        }
        if (other.gameObject.CompareTag("Player") && ScoreManager.Life <= 0 || other.gameObject.CompareTag("PlayerAttack") && ScoreManager.Life <= 0 || other.gameObject.CompareTag("PlayerAttackJump") && ScoreManager.Life <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
