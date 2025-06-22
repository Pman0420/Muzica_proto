using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// 左スティック / WASD で 2D オブジェクトを移動させるシンプルなコンポーネント
/// </summary>
public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 4f;   // 1 秒あたりの移動速度（Units/Sec）
    Vector2 moveInput;                   // 入力ベクトル (-1〜+1)

    // Player Input の “Move” アクションが呼び出すコールバック
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();   // 横: -1← →+1, 縦: -1↓ →+1
    }

    void Update()
    {
        // 入力方向へ deltaTime で等速移動
        transform.Translate(moveInput * speed * Time.deltaTime);
    }
}
