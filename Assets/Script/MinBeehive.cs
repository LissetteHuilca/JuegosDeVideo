using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinBeehive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var otherObject = collision.collider.gameObject;
        if (otherObject.tag == "Player")
        {
            var scale = this.transform.localScale;
            scale.y = 0.2f;
            scale.x = 0.2f;
            this.transform.localScale = scale;

            var position = this.transform.localPosition;
            position.x = 5.5f;
            this.transform.localPosition = position;
        }
    }
}
