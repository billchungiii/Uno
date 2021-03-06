﻿using System;
using System.Collections.Generic;
using System.Text;

using Windows.UI.Xaml;

namespace XamlGenerationTests.Core
{
    public static class TestAttachedPropertyOwner
    {
		public static Style GetCustomStyle(DependencyObject obj)
		{
			return (Style)obj.GetValue(CustomStyleProperty);
		}

		public static void SetCustomStyle(DependencyObject obj, Style value)
		{
			obj.SetValue(CustomStyleProperty, value);
		}

		public static readonly DependencyProperty CustomStyleProperty =
			DependencyProperty.RegisterAttached("CustomStyle", typeof(Style), typeof(TestAttachedPropertyOwner), new PropertyMetadata(null));

		public static bool GetHasStuff(DependencyObject obj)
		{
			return (bool)obj.GetValue(HasStuffProperty);
		}

		public static void SetHasStuff(DependencyObject obj, bool value)
		{
			obj.SetValue(HasStuffProperty, value);
		}

		public static readonly DependencyProperty HasStuffProperty =
			DependencyProperty.RegisterAttached("HasStuff", typeof(bool), typeof(TestAttachedPropertyOwner), new PropertyMetadata(false));

		public static object GetExtraContent(DependencyObject obj)
		{
			return (object)obj.GetValue(ExtraContentProperty);
		}

		public static void SetExtraContent(DependencyObject obj, object value)
		{
			obj.SetValue(ExtraContentProperty, value);
		}

		public static readonly DependencyProperty ExtraContentProperty =
			DependencyProperty.RegisterAttached("ExtraContent", typeof(object), typeof(TestAttachedPropertyOwner), new PropertyMetadata(null));

		public static object GetMoreContent(DependencyObject obj)
		{
			return (object)obj.GetValue(MoreContentProperty);
		}

		public static void SetMoreContent(DependencyObject obj, object value)
		{
			obj.SetValue(MoreContentProperty, value);
		}

		public static readonly DependencyProperty MoreContentProperty =
			DependencyProperty.RegisterAttached("MoreContent", typeof(object), typeof(TestAttachedPropertyOwner), new PropertyMetadata(null));



	}
}
