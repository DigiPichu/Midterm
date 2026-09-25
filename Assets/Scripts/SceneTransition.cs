using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] private float duration = 0f;
    [SerializeField] private string sceneName;

    private void Update()
    {


        WaitRoutine(duration);
        SceneManager.LoadScene(sceneName);

    }

    private IEnumerator WaitRoutine(float Duration)
    {

        yield return new WaitForSeconds(Duration);

    }

}
