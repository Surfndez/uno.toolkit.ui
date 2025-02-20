﻿#if __IOS__
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

namespace Uno.Toolkit.UI.Extensions
{
	internal static class UIBarButtonItemExtensions
	{
		/// <summary>
		/// In some narrow circumstances (eg when the page is unloaded, but not always) setting CustomView to null can trigger a native exception,
		/// even if it's already null. To avoid this, skip redundantly setting it to null.
		/// </summary>
		public static void ClearCustomView(this UIBarButtonItem barButtonItem)
		{
			if (barButtonItem?.CustomView != null)
			{
				barButtonItem.CustomView = null;
			}
		}
	}
}
#endif