using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectController : MonoBehaviour {

    Renderer objectRenderer;

    // Use this for initialization
    void Start () {

        objectRenderer = GetComponent<Renderer>();


    }

    // Update is called once per frame
    void Update () {
        if (objectRenderer.isVisible)
            {
                 Destroy(gameObject);
            }


    }
}
