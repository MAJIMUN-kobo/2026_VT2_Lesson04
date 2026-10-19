using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class TitleSceneState : BaseSceneState
{
    // === HUD設定 === //
    public override string HudAddress { get; protected set; } = "Assets/_TV2_Lesson04/Prefab/TitleHUDCanvas_FullHD.prefab";

    public override void Enter()
    {
        base.Enter();
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
}
