using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    //private bool isPaused = false;
    private float WaitTime = 3.0f;

    [SerializeField] string gameScene;

    public void Update()
    {
        
    }


    public void PauseAction()
    {
        Time.timeScale = 0f;
        //isPaused = true;
    }

    public void ResumeAction()
    {
        Time.timeScale = 1f;
        //isPaused = false;
    }

    public IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime(WaitTime);

    }

    public void changeScene()
    {
        SceneManager.LoadScene(gameScene);
    }
}
