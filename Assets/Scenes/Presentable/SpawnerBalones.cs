using UnityEngine;

public class SpawnerBalones : MonoBehaviour
{
    public GameObject bola;
    public void SpawnBola()
    {
        Instantiate(bola, transform.position, Quaternion.identity);
    }
}
