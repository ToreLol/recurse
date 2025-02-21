using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform leftBase;
    public Transform rightBase;

    public bool onLeft;

    public Animator animator;

    public void Teleport()
    {
        if(onLeft)
        {
            animator.rootPosition = rightBase.position;
        } else
        {
            animator.rootPosition = leftBase.position;
        }
        onLeft = !onLeft;
    }
}
