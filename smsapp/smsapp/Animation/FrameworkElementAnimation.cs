﻿using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace smsapp
{
    public static class FrameworkElementAnimations
    {
        /// <summary>
        /// Framework element animations
        /// </summary>
        /// <param name="element">The element that needs to be animated</param>
        /// <param name="seconds">Duration of the animation </param>
        /// <param name="keepMargin">Flag to indicate whether to keep the margin or not</param> 
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRight(this FrameworkElement element, float seconds, bool keepMargin = true)
        {
            var sb = new Storyboard();
            sb.AddSlideFromRight(seconds, element.ActualWidth - 6, keepMargin: keepMargin);
            sb.AddFadeIn(seconds);
            sb.Begin(element);
            element.Visibility = Visibility.Visible;
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Framework element animations
        /// </summary>
        /// <param name="element">The page that needs to be animated</param>
        /// <param name="seconds">Duration of the animation </param>
        /// <param name="keepMargin">Flag to indicate whether to keep the margin or not</param> 
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeft(this FrameworkElement element, float seconds, bool keepMargin = true)
        {
            var sb = new Storyboard();
            sb.AddSlideToLeft(seconds, element.ActualWidth, keepMargin: keepMargin);
            sb.AddFadeOut(seconds);
            sb.Begin(element);
            await Task.Delay((int)(seconds * 1000));
            element.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Framework element animations
        /// </summary>
        /// <param name="element">The element that needs to be animated</param>
        /// <param name="seconds">Duration of the animation </param>
        /// <param name="keepMargin">Flag to indicate whether to keep the margin or not</param> 
        /// <returns></returns>
        public static async Task SlideAndFadeInFromLeft(this FrameworkElement element, float seconds, bool keepMargin = true)
        {
            var sb = new Storyboard();
            sb.AddSlideFromLeft(seconds, element.ActualWidth - 6, keepMargin: keepMargin);
            sb.AddFadeIn(seconds);
            sb.Begin(element);
            element.Visibility = Visibility.Visible;
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides an element in
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="direction">The direction of the slide</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="keepMargin">Whether to keep the element at the same width during animation</param>
        /// <param name="size">The animation width/height to animate to. If not specified the elements size is used</param>
        /// <param name="firstLoad">Indicates if this is the first load</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInAsync(this FrameworkElement element, AnimationSlideInDirection direction, bool firstLoad, float seconds = 0.3f, bool keepMargin = true, int size = 0)
        {
            // Create the storyboard
            var sb = new Storyboard();

            // Slide in the correct direction
            switch (direction)
            {
                // Add slide from left animation
                case AnimationSlideInDirection.Left:
                    sb.AddSlideFromLeft(seconds, size == 0 ? element.ActualWidth : size, keepMargin: keepMargin);
                    break;
                // Add slide from right animation
                case AnimationSlideInDirection.Right:
                    sb.AddSlideFromRight(seconds, size == 0 ? element.ActualWidth : size, keepMargin: keepMargin);
                    break;
                // Add slide from top animation
                case AnimationSlideInDirection.Top:
                    sb.AddSlideFromTop(seconds, size == 0 ? element.ActualHeight : size, keepMargin: keepMargin);
                    break;
                // Add slide from bottom animation
                case AnimationSlideInDirection.Bottom:
                    sb.AddSlideFromBottom(seconds, size == 0 ? element.ActualHeight : size, keepMargin: keepMargin);
                    break;
            }
            // Add fade in animation
            sb.AddFadeIn(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible only if we are animating or its the first load
            if (seconds != 0 || firstLoad)
                element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides an element out
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="direction">The direction of the slide (this is for the reverse slide out action, so Left would slide out to left)</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="keepMargin">Whether to keep the element at the same width during animation</param>
        /// <param name="size">The animation width/height to animate to. If not specified the elements size is used</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutAsync(this FrameworkElement element, AnimationSlideInDirection direction, float seconds = 0.3f, bool keepMargin = true, int size = 0)
        {
            // Create the storyboard
            var sb = new Storyboard();

            // Slide in the correct direction
            switch (direction)
            {
                // Add slide to left animation
                case AnimationSlideInDirection.Left:
                    sb.AddSlideToLeft(seconds, size == 0 ? element.ActualWidth : size, keepMargin: keepMargin);
                    break;
                // Add slide to right animation
                case AnimationSlideInDirection.Right:
                    sb.AddSlideToRight(seconds, size == 0 ? element.ActualWidth : size, keepMargin: keepMargin);
                    break;
                // Add slide to top animation
                case AnimationSlideInDirection.Top:
                    sb.AddSlideToTop(seconds, size == 0 ? element.ActualHeight : size, keepMargin: keepMargin);
                    break;
                // Add slide to bottom animation
                case AnimationSlideInDirection.Bottom:
                    sb.AddSlideToBottom(seconds, size == 0 ? element.ActualHeight : size, keepMargin: keepMargin);
                    break;
            }

            // Add fade in animation
            sb.AddFadeOut(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible only if we are animating
            if (seconds != 0)
                element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));

            // Make element invisible
            if (element.Opacity == 0)
                element.Visibility = Visibility.Hidden;
        }
    }
}