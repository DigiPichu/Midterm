using UnityEngine;
using UnityEngine.SceneManagement;

public class StageTransition : MonoBehaviour
{
    public SceneTransition SceneTransition;
    [SerializeField] private string StageSelect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("PlayerAttack") || other.gameObject.CompareTag("PlayerAttackJump"))
        {
            SceneTransition.PauseAction();
            SceneTransition.Wait();
            SceneManager.LoadScene(StageSelect);
            SceneTransition.ResumeAction();
        }
    }// Update is called once per frame
            void Update()
    {
        
    }
}
