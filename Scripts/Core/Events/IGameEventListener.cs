namespace CircusCharlie.GameEventSystem
{
    public interface IGameEventListener<T>
    {
        void OnEventRaised(T data);
    }
}