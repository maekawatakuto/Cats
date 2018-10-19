using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Game_Start : MonoBehaviour {
    public bool fade_out = false;
    public void change_scene()
    {
        fade_out = true;          
    }
}
