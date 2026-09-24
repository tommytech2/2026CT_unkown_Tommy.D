
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class Levle : MonoBehaviour
{
 
    public Animator transition;

    public float transitionTime = 11;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    IEnumerator LoadLevel(int levelIndex)
    { 
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);

    }


}