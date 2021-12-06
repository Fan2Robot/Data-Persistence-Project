using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinfo : MonoBehaviour
{
    public static Playerinfo Instance;
    public string playerName;
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
}
