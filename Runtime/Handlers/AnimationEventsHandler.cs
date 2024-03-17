

using Packages.Estenis.GameEvent_;

public class AnimationEventsHandler : EventMonoBehaviour
{
    public void OnAnimationEvent(GameEventObject gameEvent) =>
        gameEvent.Raise(EventId, this, null);
}