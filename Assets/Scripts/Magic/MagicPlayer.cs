using UnityEngine;

public class MagicPlayer : MonoBehaviour
{
    public GameObject projectile;

    public Transform spawnPoint;

    public void Fire()
    {
        Instantiate(projectile, spawnPoint.position, Quaternion.identity);
    }
}
