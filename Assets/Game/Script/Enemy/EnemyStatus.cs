using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    [SerializeField][Tooltip("最大HP")] private int _maxHp;
    [SerializeField][Tooltip("HP")] private float _hp;
    [SerializeField][Tooltip("攻撃力")] private float _power;
    [SerializeField][Tooltip("行動の回数")] private int _actionNum;
    //public int MaxHp1 { get => MaxHp; set => MaxHp = value; }

    
    /// <summary>
    /// 最大Hp
    /// </summary>
    /// <param name="hp"></param>
    public void SetMaxHp(int hp)
    {
        this._maxHp = hp;
    }

    public int GetMaxHp() => _maxHp;

    /// <summary>
    /// 現在のHp
    /// </summary>
    /// <param name="hp"></param>
    public void SetHp(float hp)
    {
        this._hp = Mathf.Max(0, Mathf.Min(GetMaxHp(), hp));
    }


    public float GetHp() => _hp;

    /// <summary>
    /// 現在の攻撃力
    /// </summary>
    /// <param name="power">力</param>
    public void SetPower(float power)
    {
        this._power = power;
    }

    public float GetPower() => _power;
}
