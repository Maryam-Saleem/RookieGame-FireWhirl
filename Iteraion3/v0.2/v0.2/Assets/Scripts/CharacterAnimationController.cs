using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private static int _idleKey = Animator.StringToHash("idle");
    private static int _runFKey = Animator.StringToHash("runF");
    private static int _runBKey = Animator.StringToHash("runB");
    private static int _runLKey = Animator.StringToHash("runL");
    private static int _runRKey = Animator.StringToHash("runR");



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayIdle()
    {
        _animator.SetTrigger(_idleKey);
    }
    public void PlayRunF() //run forward
    {
        _animator.SetTrigger(_runFKey);
    }
    public void PlayRunB() //run backward
    {
        _animator.SetTrigger(_runBKey);
    }
    public void PlayRunL() //run left
    {
        _animator.SetTrigger(_runLKey);
    }
    public void PlayRunR() //run right
    {
        _animator.SetTrigger(_runRKey);
    }

}
