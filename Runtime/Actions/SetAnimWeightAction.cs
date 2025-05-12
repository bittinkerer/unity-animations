using Packages.Estenis.EventActions_;
using UnityEngine;

namespace Assets.Scripts.Actions.Animations
{
  public class SetAnimWeightAction : BaseGameObjectAction
  {
    [SerializeField] private string _animLayer;
    [SerializeField] private float _animWeight;
    [SerializeField] private Animator _animator;
    [SerializeField] private string _animName;
    [SerializeField] private bool _playAnim;

    protected override object Action(object data)
    {
      var animIndex = _animator.GetLayerIndex(_animLayer);

      if (animIndex < 0)
      {
        return null;
      }
      _animator.SetLayerWeight(animIndex, _animWeight);
      if (_playAnim)
      {
        _animator.Play($"{_animLayer}.{_animName}", -1, 0f);
      }
      return null;
    }
  }
}
