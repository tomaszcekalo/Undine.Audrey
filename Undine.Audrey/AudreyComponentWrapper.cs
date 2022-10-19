using Audrey;
using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.Audrey
{
    public class AudreyComponentWrapper<A> : IComponent
        where A : struct
    {
        public A Component;
    }
}