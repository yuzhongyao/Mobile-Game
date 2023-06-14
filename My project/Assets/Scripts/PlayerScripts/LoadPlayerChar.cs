using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayerChar : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawnPoint;
    void Awake()
    {
        int selectedChar = PlayerPrefs.GetInt("character");
        GameObject prefab = characterPrefabs[selectedChar];
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
