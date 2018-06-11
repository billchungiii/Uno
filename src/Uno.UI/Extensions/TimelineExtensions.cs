﻿using Windows.UI.Xaml.Media.Animation;
using System;
using System.Collections.Generic;
using System.Text;
using Uno.Extensions;
using Uno.Logging;

namespace Windows.UI.Xaml.Media.Animation
{
	public static partial class TimelineExtensions
	{
		internal static string GetTimelineTargetFullName(this Timeline t)
		{
			return Storyboard.GetTargetName(t) + "." + Storyboard.GetTargetProperty(t);
		}

		internal static bool GetIsDurationZero(this Timeline timeline)
		{
			return timeline.Duration.TimeSpan == TimeSpan.Zero;
		}

		/// <summary>
		/// Gets a value indicating whether this instance is a dependant animation.
		/// 
		/// https://msdn.microsoft.com/en-uS/office/office365/jj819807.aspx#dependent
		/// </summary>
		/// <value><c>true</c> if this instance is dependant animation; otherwise, <c>false</c>.</value>
		internal static bool GetIsDependantAnimation(this Timeline timeline)
		{
			if (timeline.GetIsDurationZero() || !timeline.IsTargetPropertyDependant())
			{
				//is not dependant if the target is a transform or duration is zero
				return false;
			}

			if (timeline.Log().IsEnabled(Microsoft.Extensions.Logging.LogLevel.Debug))
			{
				timeline.Log().Debug("This Dependant animation will not run, EnableDependentAnimation is set to false");
			}

			return true;//is dependant
		}

		/// <summary>
		/// Animation should be hardware-bound if it is neither dependent, nor zero-duration.
		/// </summary>
		internal static bool GetIsHardwareAnimated(this Timeline timeline) => !timeline.GetIsDependantAnimation() && !timeline.GetIsDurationZero();
	}
}