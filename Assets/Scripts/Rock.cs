using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // apply impulse force to get game object moving
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 4f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);
    }

    //void Update()
    //{
    //    Vector3 position = Input.mousePosition;
    //    position.z = -Camera.main.transform.position.z;
    //    position = Camera.main.ScreenToWorldPoint(position);

    //    transform.position = position;
    //}

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
