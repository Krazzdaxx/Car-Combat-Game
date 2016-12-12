using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CarHealth : MonoBehaviour {

    public int carHP = 100;
    public Text HP;

    void Update()
    {
        HP.text = "Health: " + carHP;

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "GreenProjectile")
        {

            DamageCar(10);
            Destroy(collider);
        }

        if (collider.tag == "RedProjectile")
        {

            DamageCar(1);
            Destroy(collider);
        }
    }

    public void DamageCar(int damage)
    {

        carHP -= damage;
        if (carHP <= 0)
            Destroy(gameObject);
    }
}
