using Packages.Estenis.EventActions_;
using System;
using UnityEngine;

namespace Assets.Scripts.Actions.Animations
{
  public class AnimationBinderAction : BaseGameObjectAction
  {
    [SerializeField] private Animator _animator;
    [SerializeField] private string _animationLayer = "Base";
    [SerializeField] private string _animationName;

    protected override object Action(object data)
    {
      _animator.Play($"{_animationLayer}.{_animationName}", -1, 0f);
      return _animationName;
    }
  }
}