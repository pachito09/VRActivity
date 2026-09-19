using UnityEngine;

public class trigger : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("entro " + other.gameObject.name);
    }    
}

