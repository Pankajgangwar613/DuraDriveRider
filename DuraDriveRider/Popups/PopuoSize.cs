﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DuraDriveRider.Popups
{
  public static class PopuoSize
    {
		//100,100
		public static Size Small => new Size(100, 100);
		
		//260,100
		public static Size Size260By100 => new Size(260, 100);

		public static Size Default => new Size(300, 300);

		// examples for relative to screen sizes
		public static Size Medium => new Size(0.7 * (DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density), 0.6 * (DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density));

		public static Size Large => new Size(0.9 * (DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density), 0.8 * (DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density));

	}
}
