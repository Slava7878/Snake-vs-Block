using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Transform _finish;
    [SerializeField] private Slider _slider;
    [SerializeField] private float _acceptableFinishPlayerDistance = 1f;

    private float _startZ;
    private float _maximumReachedZ;

    private void Start()
    {
        _startZ = _player.transform.position.z;
    }

    private void Update()
    {
        _maximumReachedZ = Mathf.Max(_maximumReachedZ, _player.transform.position.z);        
        float finishZ = _finish.position.z;
        float t = Mathf.InverseLerp(_startZ, finishZ - _acceptableFinishPlayerDistance, _maximumReachedZ);
        _slider.value = t;
    }
}
