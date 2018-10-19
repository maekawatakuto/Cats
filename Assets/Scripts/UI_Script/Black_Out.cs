using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Black_Out : MonoBehaviour {
    [SerializeField]
    Game_Start game_start;
    Image image;
    public float a;
    public int fade_timer;
	// Use this for initialization
	void Start () {
        a = 0;
         image = GetComponent<Image>();
        image.color = new Color(0, 0, 0,0);
    }
	
	// Update is called once per frame
	void Update () {
        if (game_start.fade_out)
        {
            a += 0.1f;
            fade_timer +=(int)Time.deltaTime;
            Debug.Log(a);
        }
        if (a>=1f){
            game_start.fade_out = false;
            SceneManager.LoadScene("diffeculty");
            }
        
        image.color = new Color(0, 0, 0, a);
    }
}
