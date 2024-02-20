using DG.Tweening;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _toScale;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOScale(_toScale, _duration).SetLoops(_repeats,_loopType).SetEase(Ease.Linear);
    }
}
