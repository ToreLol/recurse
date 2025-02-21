using UnityEngine;

public class SwordPlayer : MonoBehaviour
{
    public SwordRoomManager roomManager;
    public Sword sword;

    public void ResetAttack()
    {
        roomManager.canAttack = true;
    }

    public void StartCollision()
    {
        sword.canCollide = true;
    }

}
