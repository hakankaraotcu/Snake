using UnityEngine;

public class GameOverWindow : MonoBehaviour
{

    public static void LoadGame()
    {
        Loader.Load(Loader.Scene.GameScene);
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    public static void ShowStatic()
    {
        Loader.Load(Loader.Scene.LoseScene);
    }
}
