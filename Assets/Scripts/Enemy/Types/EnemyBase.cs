using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public void Kill()
    {
        Destroy(this.gameObject);
    }
}