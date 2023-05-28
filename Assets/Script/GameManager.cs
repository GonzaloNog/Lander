using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject[] buildings;
    private int buildID = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(this);

        DontDestroyOnLoad(this);
    }
    
    public void setBuildId(int _id)
    {
        buildID = _id;
    }
    public GameObject getBuilding()
    {
        return buildings[buildID];
    }
}
