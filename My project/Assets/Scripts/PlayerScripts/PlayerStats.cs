using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PlayerStats", menuName = "Player Stats" )]

public class PlayerStats : ScriptableObject
{
    public int Speed = 5;
    public int Strength = 1;
    public int Awareness = 2;
    public int Sprint = 1;
    public int SkillPoints = 3;
    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
}
