namespace CodeLibrary24.GameEventSystem
{
    public interface IGameEventListener<T>
    {
        void OnEventRaised(T data);
    }
}