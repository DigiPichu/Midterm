using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    public SceneTransition SceneTransition;
    public StageUI stageUI;
    private int lifeValue = -1;


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player") && ScoreManager.Life > 0)
        {
            Debug.Log("Touched a Player");
            SceneTransition.PauseAction();
            SceneTransition.Wait();
            SceneManager.LoadScene("Stage Select");
            stageUI.changeLife(lifeValue);
            SceneTransition.ResumeAction();

        }

        if (collision.gameObject.CompareTag("PlayerAttackJump") && ScoreManager.Life > 0)
        {
            Debug.Log("Touched a Player");
            SceneTransition.PauseAction();
            SceneTransition.Wait();
            SceneManager.LoadScene("Stage Select");
            stageUI.changeLife(lifeValue);
            SceneTransition.ResumeAction();

        }

        if (collision.gameObject.CompareTag("Player") && ScoreManager.Life <= 0)
        {
            Debug.Log("Touched a Player");
            SceneManager.LoadScene("Game Over");
        }

        if (collision.gameObject.CompareTag("PlayerAttackJump") && ScoreManager.Life > 0)
        {
            Debug.Log("Touched a Player");
            SceneManager.LoadScene("Game Over");
        }



        if (collision.gameObject.CompareTag("PlayerAttack"))
        {
            Destroy(enemy);
        }
    }
}
