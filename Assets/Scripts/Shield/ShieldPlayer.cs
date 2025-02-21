using UnityEngine;

public class ShieldPlayer : MonoBehaviour
{
    public GameObject shield;
    public void StartDefense()
    {
        shield.SetActive(true);
    }
    public void StopDefense()
    {
        shield.SetActive(false);
    }
}
