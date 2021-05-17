using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFolder : MonoBehaviour
{
    public void ActivateDesactivate()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
