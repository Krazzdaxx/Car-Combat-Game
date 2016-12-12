using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TurretHealth : MonoBehaviour {

    public int turretHP= 100;
 

    public void KillTurret(int damage)
    {
        
        turretHP -= damage;
        if (turretHP <= 0)
            
        Destroy(gameObject);
    }
}
