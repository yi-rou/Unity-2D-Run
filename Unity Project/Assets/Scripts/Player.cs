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
    [Header("速度"),Tooltip("角色速度"),Range(50, 500)]
    public int speed = 59;
    [Header("血量"),Tooltip("角色血量"),Range(500, 1500)]
    public float hp = 799.99f;
    public int coin;
    [Header("跳躍高度"),Range(500, 1000)]
    public int height = 659;
    [Header("音效區域")]
    public AudioClip soundJump;
    public AudioClip soundSlide;
    public AudioClip soundHit;
    [Header("是否死亡")]
    public bool dead;

    #endregion

    #region  方法區域

    /// <summary>
    /// 跳躍音效.跳躍動畫
    /// </summary>
    private void Jump()
    {
        print("跳躍");
    }

    /// <summary>
    /// 滑行動畫.滑行音效.縮小碰撞範圍
    /// </summary>
    private void Slide()
    {

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
         
    }
    #endregion
}
