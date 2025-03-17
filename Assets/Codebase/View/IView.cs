namespace Codebase.View
{
    public interface IView<T>
    {
        public void Render(T value);
    }
}