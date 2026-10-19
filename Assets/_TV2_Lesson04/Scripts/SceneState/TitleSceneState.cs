using UnityEngine;
using UnityEngine.InputSystem;

public class TitleSceneState : IState
{
    // === メンバー変数 === //
    private SceneManager _sceneManager;

    public void Enter() 
    {
        Debug.Log($"{GetType().Name} が始まります。");

        // SceneManager を取得
        _sceneManager = GameObject.FindAnyObjectByType<SceneManager>();
    }

    public void Execute() 
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // ゲーム画面に切り替える
            _sceneManager.ChangeScene(new GameSceneState());
        }
    }

    public void Exit() 
    {
        Debug.Log($"{GetType().Name} を終了します。");
    }
}
