using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

/// <summary>
/// インターフェース (interface)
/// └　このインターフェースを継承するクラスは、
/// 　　記述されているメソッドやプロパティを全て実装しなければならない
/// </summary>
public interface IState
{
    void Enter();       // 状態の初期処理
    void Execute();     // 状態の繰り返し処理
    void Exit();        // 状態の終了処理
}


/// <summary>
/// 具象クラスに継承させる抽象クラス
/// </summary>
public abstract class BaseSceneState : IState
{
    // === 親クラスのメンバー === //
    protected SceneManager _sceneManager;

    // === Canvas 設定プロパティ === //
    // ヘッドアップディスプレイ（UI）のプレハブのアドレスを入力
    public abstract string HudAddress { get; protected set; }
    private GameObject _hudCanvas;


    public virtual void Enter()
    {
        Debug.Log($"{GetType().Name} が始まります。");

        // SceneManager を取得
        _sceneManager = GameObject.FindAnyObjectByType<SceneManager>();

        // === 👇プレハブの読み込み
        GameObject hudPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(HudAddress);
        _hudCanvas = GameObject.Instantiate(hudPrefab);
    }

    public virtual void Execute() { }

    public virtual void Exit()
    {
        Debug.Log($"{GetType().Name} を終了します。");

        GameObject.Destroy(_hudCanvas);
    }
}
