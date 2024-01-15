using Audrey;

namespace Undine.Audrey
{
    public class AudreyEntity : Core.IUnifiedEntity
    {
        public Entity Entity { get; }

        public AudreyEntity(Entity entity)
        {
            Entity = entity;
        }

        public void AddComponent<A>(in A component) where A : struct
        {
            this.Entity.AddComponent(new AudreyComponentWrapper<A>()
            {
                Component = component
            });
        }

        public ref A GetComponent<A>() where A : struct
        {
            return ref this.Entity.GetComponent<AudreyComponentWrapper<A>>().Component;
        }
    }
}