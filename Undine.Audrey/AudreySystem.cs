using Audrey;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.Audrey
{
    public class AudreySystem<A> : ISystem
        where A : struct
    {
        public Engine Engine { get; }
        public Family Family { get; }
        public UnifiedSystem<A> System { get; set; }

        public AudreySystem(Engine engine)
        {
            Engine = engine;
            Family = Family
                .All(typeof(AudreyComponentWrapper<A>))
                .Get();
        }

        public void ProcessAll()
        {
            foreach (var entity in Engine.GetEntitiesFor(Family))
            {
                System.ProcessSingleEntity(
                    0,
                    ref entity.GetComponent<AudreyComponentWrapper<A>>().Component);
            }
        }
    }

    public class AudreySystem<A, B> : ISystem
        where A : struct
        where B : struct
    {
        public Engine Engine { get; }
        public Family Family { get; }
        public UnifiedSystem<A, B> System { get; set; }

        public AudreySystem(Engine engine)
        {
            Engine = engine;
            Family = Family
                .All(typeof(AudreyComponentWrapper<A>)
                    , typeof(AudreyComponentWrapper<B>))
                .Get();
        }

        public void ProcessAll()
        {
            foreach (var entity in Engine.GetEntitiesFor(Family))
            {
                System.ProcessSingleEntity(
                    0,
                    ref entity.GetComponent<AudreyComponentWrapper<A>>().Component,
                    ref entity.GetComponent<AudreyComponentWrapper<B>>().Component);
            }
        }
    }

    public class AudreySystem<A, B, C> : ISystem
        where A : struct
        where B : struct
        where C : struct
    {
        public Engine Engine { get; }
        public Family Family { get; }
        public UnifiedSystem<A, B, C> System { get; set; }

        public AudreySystem(Engine engine)
        {
            Engine = engine;
            Family = Family
                .All(typeof(AudreyComponentWrapper<A>)
                    , typeof(AudreyComponentWrapper<B>)
                    , typeof(AudreyComponentWrapper<C>))
                .Get();
        }

        public void ProcessAll()
        {
            foreach (var entity in Engine.GetEntitiesFor(Family))
            {
                System.ProcessSingleEntity(
                    0,
                    ref entity.GetComponent<AudreyComponentWrapper<A>>().Component,
                    ref entity.GetComponent<AudreyComponentWrapper<B>>().Component,
                    ref entity.GetComponent<AudreyComponentWrapper<C>>().Component);
            }
        }
    }

    public class AudreySystem<A, B, C, D> : ISystem
        where A : struct
        where B : struct
        where C : struct
        where D : struct

    {
        public Engine Engine { get; }
        public Family Family { get; }
        public UnifiedSystem<A, B, C, D> System { get; set; }

        public AudreySystem(Engine engine)
        {
            Engine = engine;
            Family = Family
                .All(typeof(AudreyComponentWrapper<A>)
                    , typeof(AudreyComponentWrapper<B>)
                    , typeof(AudreyComponentWrapper<C>)
                    , typeof(AudreyComponentWrapper<D>))
                .Get();
        }

        public void ProcessAll()
        {
            foreach (var entity in Engine.GetEntitiesFor(Family))
            {
                System.ProcessSingleEntity(
                    0,
                    ref entity.GetComponent<AudreyComponentWrapper<A>>().Component,
                    ref entity.GetComponent<AudreyComponentWrapper<B>>().Component,
                    ref entity.GetComponent<AudreyComponentWrapper<C>>().Component,
                    ref entity.GetComponent<AudreyComponentWrapper<D>>().Component);
            }
        }
    }
}