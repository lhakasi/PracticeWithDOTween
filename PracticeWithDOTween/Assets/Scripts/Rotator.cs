using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotateTo;
    [SerializeField] private float _duration;
    [SerializeField] private RotateMode _rotateMode;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start() => transform.DORotate(_rotateTo, _duration, _rotateMode).SetLoops(_repeats,_loopType).SetEase(Ease.Linear);    
}
