using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerScript : MonoBehaviour
{
    public Animator animator;
    private int levelToLoad;
 
    public void FadeToNextLevel ()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void FadeToLevel (int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeIn");
    }
    public void OnFadeComplete ()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
