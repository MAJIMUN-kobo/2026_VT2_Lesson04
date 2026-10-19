using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ResultSceneState : BaseSceneState
{
    // === HUD設定 === //
    public override string HudAddress { get; protected set; } = "Assets/_TV2_Lesson04/Prefab/ResultHUDCanvas_FullHD.prefab";


    public override void Enter() 
    {
        base.Enter();
    }


    public override void Execute() 
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // ResultSceneState へ遷移
            _sceneManager.ChangeScene(new TitleSceneState());
        }

        base.Execute();
    }
}
