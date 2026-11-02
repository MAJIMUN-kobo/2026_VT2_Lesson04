using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class TitleSceneState : BaseSceneState
{
    // === HUD設定 === //
    public override string HudAddress { get; protected set; } = "Assets/_TV2_Lesson04/Prefab/TitleHUDCanvas_FullHD.prefab";

    private TitleHUDController _hudController;
    private int _score;

    public override void Enter()
    {
        base.Enter();

        // HUDのビューを初期化
        var hudView = new TitleHUDView();
        hudView.Initialize(_hudCanvas.GetComponent<Canvas>());

        // HUDのコントローラーを初期化
        _hudController = new TitleHUDController(hudView, this);
    }


    public override void Execute() 
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // ゲーム画面に切り替える
            _sceneManager.ChangeScene(new GameSceneState());
        }

        base.Execute();
    }


    public void AddScore()
    {
        _score++;
    }
}
