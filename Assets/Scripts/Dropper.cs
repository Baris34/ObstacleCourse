using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private int timeToWait;
    private Rigidbody _rigidbody;
    private MeshRenderer _meshRenderer;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _meshRenderer = GetComponent<MeshRenderer>();

        _rigidbody.useGravity = false;
        _meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            _meshRenderer.enabled = true;
            _rigidbody.useGravity = true;
        }
    }
}
