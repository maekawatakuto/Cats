using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rigidbody_;
    private Vector2 clickPosition;  //クリック地点を格納

    [SerializeField]
    private float distans_Min;
    [SerializeField]
    private float distans_Max;
    [SerializeField]
    private float adjustmentValue;
    private bool canMove;
    public bool isMoving { set; get; }
    private Vector2 force;

    void Start()
    {
        isMoving = false;
        rigidbody_ = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isMoving)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StopMovement();
            }
        }
        else
        {
            Vector2 _mousePosition = Input.mousePosition;

            if (Input.GetMouseButtonDown(0))
            {
                //クリック時の座標をclickPositionに格納
                clickPosition = _mousePosition;
            }
            if (Input.GetMouseButton(0))
            {
                //clickPositionと現在のmousePositionの距離を計算、powerとして格納
                float _power = Vector2.Distance(clickPosition, _mousePosition); //大きさ
                Vector2 _direction = (clickPosition - _mousePosition).normalized; //方向

                if (_power > distans_Min)
                {
                    if (_power > distans_Max) _power = distans_Max;
                    canMove = true;
                }
                else
                {
                    canMove = false;
                    _power = 0.0f;
                }
                force = _direction * _power * adjustmentValue;
            }
            if (Input.GetMouseButtonUp(0)&&canMove)
            {
                StartMoving();
                rigidbody_.AddForce(force);
            }
        }
    }

    void StartMoving()
    {
        isMoving = true;
        rigidbody_.simulated = true;
    }

    void StopMovement()
    {
        isMoving = false;
        rigidbody_.simulated = false;
        rigidbody_.velocity = Vector2.zero;
    }

    void OnColliderEnter(Collider2D collider)
    {
        Debug.Log("aaaaa");
    }
}
