using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSurvive : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
