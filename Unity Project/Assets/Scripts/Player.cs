using UnityEngine;

public class Player : MonoBehaviour
{

    // 單行註解

    /*
     * 多行註解
     * 多行註解
     */

    #region 欄位區域

    /* 
     * 命名規則
     * 1. 用有意義的名稱
     * 2. 不要使用數字開頭
     * 3.不要使用特殊符號 @#/* 空格
     * 4. 可以使用中文(建議不要)
     */

    // Header 標題
    // Tooltip 提示
    // Range 範圍
    [Header("速度"), Tooltip("角色速度"), Range(1, 50)]
    public int speed = 8;
    [Header("血量"), Tooltip("角色血量"), Range(500, 1500)]
    public float hp = 799.99f;
    public int coin;
    [Header("跳躍高度"), Range(100, 1000)]
    public int height = 500;
    [Header("音效區域")]
    public AudioClip soundJump;
    public AudioClip soundSlide;
    public AudioClip soundHit;
    [Header("是否死亡")]
    public bool dead;
    [Header("動畫控制器")]
    public Animator ani;

    public CapsuleCollider2D cc2D;

    public Rigidbody2D rig;

    public bool isGround;
    #endregion

    #region  方法區域

    /// <summary>
    /// 跳躍音效.跳躍動畫
    /// </summary>

    private void Move()
    {
        //   剛體.加速度.大小
        if (rig.velocity.magnitude < 10)
        {
            rig.AddForce(new Vector2(speed, 0));
        }
    }

    private void Jump()
    {
        bool code = Input.GetKey(KeyCode.J);
        ani.SetBool("跳躍開關", !isGround);
        if (isGround)
        {
            if (code)
            {
                isGround = false;
                rig.AddForce(new Vector2(0, height));
            }

        }
    }

    /// <summary>
    /// 滑行動畫.滑行音效.縮小碰撞範圍
    /// </summary>
    private void Slide()
    {
        bool key = Input.GetKey(KeyCode.S);
        ani.SetBool("滑行開關", key);
        if (key)
        {
            cc2D.offset = new Vector2(-1.3f, -0.7f);
            cc2D.size = new Vector2(1.7f, 2);
        }
        else
        {
            cc2D.offset = new Vector2(-1.3f, 0.05f);
            cc2D.size = new Vector2(1.7f, 3.8f);
        }
    }

    /// <summary>
    /// 碰到障礙物時會扣血
    /// </summary>
    private void Hit()
    {

    }

    /// <summary>
    /// 吃到金幣會增加數量.更新介面.吃金幣音效
    /// </summary>
    private void EatCoin()
    {

    }

    /// <summary>
    /// 死亡動畫.遊戲結束
    /// </summary>
    private void Dead()
    {

    }

    #endregion

    #region 事件區域


    private void Start()
    {

    }

    //一秒執行60次
    //監控玩家鍵盤.滑鼠與觸控
    private void Update()
    {
        Slide();
    }

    /// <summary>
    /// 如果有剛體的方法 建議使用
    /// </summary>
    private void FixedUpdate()
    {        
        Move();
        Jump();
    }
    #endregion

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "地板")
        {
            isGround = true;
        }
    }
}
