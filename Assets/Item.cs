using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    [SerializeField] ItemSO data;

    public int Getpoint()
    {
        return data.point;
    }
    
}
