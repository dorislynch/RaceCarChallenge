using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Race.Car.Challenge.RNRaceCarChallenge
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNRaceCarChallengeModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNRaceCarChallengeModule"/>.
        /// </summary>
        internal RNRaceCarChallengeModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNRaceCarChallenge";
            }
        }
    }
}
