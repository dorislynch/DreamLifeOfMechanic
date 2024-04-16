using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Dream.Life.Of.Mechanic.RNDreamLifeOfMechanic
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNDreamLifeOfMechanicModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNDreamLifeOfMechanicModule"/>.
        /// </summary>
        internal RNDreamLifeOfMechanicModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNDreamLifeOfMechanic";
            }
        }
    }
}
