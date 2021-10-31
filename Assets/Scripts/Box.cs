using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Box : MonoBehaviour
{
    public float Health = 50f;
    public UnityAction<GameObject> OnBoxDestroyed = delegate { };

    private bool _isHit = false;

    void OnDestroy()
    {
        if (_isHit)
        {
            OnBoxDestroyed(gameObject);
            //Spawner1.IncreaseScore();
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<Rigidbody2D>() == null) return;

        if (col.gameObject.tag == "Ball")
        {
            _isHit = true;
            Destroy(gameObject);
            ScoreManager.scoreValue += 1;
        }

        else if (col.gameObject.tag == "Bullet")
        {
            float damage = col.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude * 10;
            Health -= damage;

            if (Health <= 0)
            {
                _isHit = true;
                Destroy(gameObject);
            }
        }
    }
}
