using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    public int currentStage = 0;
    public PlayerStat playerStat;
}
