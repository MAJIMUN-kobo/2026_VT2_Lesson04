using UnityEngine;
using UnityEngine.InputSystem;

public class PauseSceneState : BaseSceneState
{
    // === HUD設定 === //
    public override string HudAddress { get; protected set; } = "Assets/_TV2_Lesson04/Prefab/PauseHUDCanvas_FullHD.prefab";

    public override void Execute()
    {
        if(Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            _sceneManager.ChangeScene(new GameSceneState());
        }

        base.Execute();
    }
}
