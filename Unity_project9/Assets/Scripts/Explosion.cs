using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var hasFinished = anim.GetCurrentAnimatorStateInfo(0).normalizedTime;
        if (hasFinished >= 0.5f)
        {
            Destroy(gameObject);
        }
    }
}
