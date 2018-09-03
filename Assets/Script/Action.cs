using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Action : MonoBehaviour {
    public GameObject Arm;
    public int AttackSpeed = 1;
    public GameObject Weapon;   

    [SerializeField]
    private float angle = 0; //팔의 회전 각도

    [SerializeField]
    private float speed = 160; //팔의 회전속도 = 공격속도

    [SerializeField]
    private int conditioncheck = 0; //0: 팔을 앞으로 회전 1:팔을 뒤로 회전

    [SerializeField]
    private int attackcon = 0; //0:공격x 1:공격o

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        AttackAction();
        Attackmotion();
	}

    public void AttackAction()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * Time.smoothDeltaTime);
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //this.transform.Translate(Vector3.right * Time.smoothDeltaTime);
            this.transform.Translate(Vector3.forward * Time.smoothDeltaTime);
            this.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //this.transform.Translate(Vector3.left * Time.smoothDeltaTime);
            this.transform.Translate(Vector3.forward * Time.smoothDeltaTime);
            this.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //this.transform.Translate(Vector3.back * Time.smoothDeltaTime);
            this.transform.Translate(Vector3.forward * Time.smoothDeltaTime);
            this.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            this.transform.Translate(Vector3.right * Time.smoothDeltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Translate(Vector3.left * Time.smoothDeltaTime);
        }

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    if (conditioncheck == 0)
        //    {
        //        angle += Time.deltaTime * speed;
        //        Arm.transform.Rotate(0, -speed * Time.deltaTime, 0);
        //    }
        //    if (conditioncheck == 1)
        //    {
        //        angle -= Time.deltaTime * speed;
        //        Arm.transform.Rotate(0, speed * Time.deltaTime, 0);
        //    }
        //    if (angle >= 80)
        //    {
        //        conditioncheck = 1;
        //    }
        //    if (angle <= 0)
        //    {
        //        conditioncheck = 0;
        //    }
        //}

        if (Input.GetMouseButton(0))
        {
            attackcon = 1;
        }
    }

    public void Attackmotion()
    {
        if (attackcon == 1)
        {
            if (conditioncheck == 0)
            {
                angle += Time.deltaTime * speed;
                Arm.transform.Rotate(0, -speed * Time.deltaTime, 0);
            }
            if (conditioncheck == 1)
            {
                angle -= Time.deltaTime * speed;
                Arm.transform.Rotate(0, speed * Time.deltaTime, 0);
            }
            if (angle >= 80)
            {
                conditioncheck = 1;
            }
            if (angle < 0)
            {
                conditioncheck = 0;
                attackcon = 0;
            }
        }
    }
}
