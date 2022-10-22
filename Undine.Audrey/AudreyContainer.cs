using Audrey;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.Audrey
{
    public class AudreyContainer : EcsContainer
    {
        private Engine Engine { get; }
        private List<ISystem> Systems { get; }

        public AudreyContainer()
        {
            Engine = new Engine();
            Systems = new List<ISystem>();
        }

        public override void AddSystem<A>(UnifiedSystem<A> system)
        {
            Systems.Add(new AudreySystem<A>(Engine)
            {
                System = system
            });
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            Systems.Add(new AudreySystem<A, B>(Engine)
            {
                System = system
            });
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            Systems.Add(new AudreySystem<A, B, C>(Engine)
            {
                System = system
            });
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            Systems.Add(new AudreySystem<A, B, C, D>(Engine)
            {
                System = system
            });
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            Entity entity = Engine.CreateEntity();
            return new AudreyEntity(entity);
        }

        public override ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            return new AudreySystem<A>(Engine)
            {
                System = system
            };
        }

        public override ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            return new AudreySystem<A, B>(Engine)
            {
                System = system
            };
        }

        public override ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            return new AudreySystem<A, B, C>(Engine)
            {
                System = system
            };
        }

        public override ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            return new AudreySystem<A, B, C, D>(Engine)
            {
                System = system
            };
        }

        public override void Run()
        {
            foreach (var system in Systems)
            {
                system.ProcessAll();
            }
        }
    }
}