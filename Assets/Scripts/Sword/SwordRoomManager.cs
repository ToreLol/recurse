using UnityEngine;

public class SwordRoomManager : MonoBehaviour
{
    public Animator playerAnimator;
    public GameObject enemy;

    private float _timer = 0f;
    public float attackCooldown = 2f;
    public  bool canAttack = true;
    
    void Start()
    {
        playerAnimator.gameObject.GetComponent<SwordPlayer>().roomManager = this;
    }

    void Update()
    {
        if (canAttack == true)
        {
            _timer += Time.deltaTime;
            if (_timer >= attackCooldown)
            {
                canAttack = false;
                _timer = 0;
                Attack();
            }
        }
    }

    public void Attack()
    {
        playerAnimator.SetTrigger("Attack");
        Debug.Log("Player Attacked!");
    }
}
