// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Toolkit.Uwp.UI.Animations.Effects;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Animation;

namespace Microsoft.Toolkit.Uwp.UI.Animations
{
    /// <summary>
    /// These extension methods perform animation on UIElements
    /// </summary>
    public static partial class AnimationExtensions
    {
        /// <summary>
        /// Gets the blur effect.
        /// </summary>
        /// <value>
        /// The blur effect.
        /// </value>
        public static Blur BlurEffect { get; } = new Blur();

        /// <summary>
        /// Animates the Gaussian blur of the UIElement.
        /// </summary>
        /// <param name="associatedObject">The associated object.</param>
        /// <param name="value">The blur amount.</param>
        /// <param name="duration">The duration in milliseconds.</param>
        /// <param name="delay">The delay. (ignored if duration == 0)</param>
        /// <param name="easingType">The easing function</param>
        /// <param name="easingMode">The easing mode</param>
        /// <returns>
        /// An Animation Set.
        /// </returns>
        public static AnimationSet Blur(
            this FrameworkElement associatedObject,
            double value = 0d,
            double duration = 500d,
            double delay = 0d,
            EasingType easingType = EasingType.Default,
            EasingMode easingMode = EasingMode.EaseOut)
        {
            if (associatedObject == null)
            {
                return null;
            }

            var animationSet = new AnimationSet(associatedObject);
            return animationSet.Blur(value, duration, delay, easingType, easingMode);
        }

        /// <summary>
        /// Animates the Gaussian blur of the UIElement.
        /// </summary>
        /// <param name="animationSet">The animation set.</param>
        /// <param name="value">The blur amount.</param>
        /// <param name="duration">The duration in milliseconds.</param>
        /// <param name="delay">The delay. (ignored if duration == 0)</param>
        /// <param name="easingType">The easing function</param>
        /// <param name="easingMode">The easing mode</param>
        /// <returns>
        /// An Animation Set.
        /// </returns>
        public static AnimationSet Blur(
            this AnimationSet animationSet,
            double value = 0d,
            double duration = 500d,
            double delay = 0d,
            EasingType easingType = EasingType.Default,
            EasingMode easingMode = EasingMode.EaseOut)
        {
            return BlurEffect.EffectAnimation(animationSet, value, duration, delay, easingType, easingMode);
        }
    }
}
