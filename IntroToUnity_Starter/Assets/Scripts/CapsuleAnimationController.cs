using UnityEngine;
using System.Collections;

public class CapsuleAnimationController : MonoBehaviour
{

    private Animator _animator;
    private bool _spinning;


    // Use this for initialization
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.X))
        {
            _spinning = !_spinning;
            if (_animator)
                _animator.SetBool("IsSpinning", _spinning);
        }
    }
}
