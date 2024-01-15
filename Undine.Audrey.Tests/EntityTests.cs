using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undine.Audrey.Tests.Components;
using Undine.Core;

namespace Undine.Audrey.Tests
{
    [TestClass]
    public class EntityTests
    {
        [TestInitialize]
        public void Init()
        {
        }

        [TestMethod]
        public void ComponentCanBeAdded()
        {
            var container = new AudreyContainer();
            container.Init();
            var entity = container.CreateNewEntity();
            entity.AddComponent(new AComponent());
        }

        [TestMethod]
        public void ComponentCanBeRetrieved()
        {
            var container = new AudreyContainer();
            var mock = Substitute.For<UnifiedSystem<AComponent>>();
            container.AddSystem(mock);
            container.Init();
            var entity = (AudreyEntity)container.CreateNewEntity();
            entity.AddComponent(new AComponent());
            container.Run();
            ref var component = ref entity.GetComponent<AComponent>();
            Assert.IsNotNull(component);
        }//
    }
}
