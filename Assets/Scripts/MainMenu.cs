using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        StartCoroutine(TransitionToScene());
        //SceneManager.LoadScene(0);
    }

 

    private IEnumerator TransitionToScene()
    {
        // Wait for 2 seconds
        yield return new WaitForSeconds(2f);
        // Load the specified scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
