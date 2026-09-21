using UnityEngine;
using UnityEngine.SceneManagement;


public class MENU_script : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("Level1");

    }

    public void OnExitClick()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
        
    }

}
