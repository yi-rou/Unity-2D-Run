using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 離開遊戲.載入遊戲
/// </summary>
public class SceneControl : MonoBehaviour
{
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }

    /// <summary>
    /// 載入遊戲
    /// </summary>
    public void LoadScene()
    {
        SceneManager.LoadScene("遊戲場景");
    }

    public void DelayLoadScene()
    {
        Invoke("LoadScene",1.2f);
    }
}
