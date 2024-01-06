namespace Application.Repositories.Seeds
{
    public abstract class ISeedInitializer
    {
        public abstract void Initialize(InMemoryDatabase database);
    }
}
