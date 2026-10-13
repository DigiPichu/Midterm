using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

public class BonusDeathPlane : MonoBehaviour
{


    public SceneTransition SceneTransition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")  || other.gameObject.CompareTag("PlayerAttack") || other.gameObject.CompareTag("PlayerAttackJump"))
        {
            Debug.Log("Touched a Player");
            SceneTransition.PauseAction();
            SceneTransition.Wait();
            SceneManager.LoadScene("Stage Select");
            SceneTransition.ResumeAction();
        }

    }
}