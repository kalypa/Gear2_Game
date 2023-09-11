using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="SO/PlayerStat")]
public class PlayerStat : ScriptableObject
{
    public int level;
    public int atk;
    public int hp;
    public float atkSpeed;
    public float criticalProbability;
    public float criticalDamageAmount;
    public float selfhealing;
}
