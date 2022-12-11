using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    // The Target defines the domain-specific interface used by the client code.
        public interface ITarget
        {
            string GetRequest();
        }

        // The Adaptee contains some useful behavior, but its interface is
        // incompatible with the existing client code. The Adaptee needs some
        // adaptation before the client code can use it.
       public class Adaptee
        {
            public string GetSpecificRequest()
            {
                return "Specific request.";
            }
        }

        // The Adapter makes the Adaptee's interface compatible with the Target's
        // interface.
        public class Adapter : ITarget
        {
            private readonly Adaptee _adaptee;

            public Adapter(Adaptee adaptee)
            {
                this._adaptee = adaptee;
            }

            public string GetRequest()
            {
                return $"This is '{this._adaptee.GetSpecificRequest()}'";
            }
        }

    }
