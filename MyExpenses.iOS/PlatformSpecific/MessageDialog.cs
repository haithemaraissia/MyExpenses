//
//  Copyright 2014  Xamarin Inc.
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.using System;
using MonoTouch.UIKit;
using MyExpenses.iOS.Helpers;
using MyExpenses.Portable.Interfaces;

namespace MyExpenses.PlatformSpecific
{
  public class MessageDialog : IMessageDialog
  {
    public void SendMessage(string message, string title = null)
    {
      UIHelpers.EnsureInvokedOnMainThread(() =>
      {
        var alertView = new UIAlertView(title ?? string.Empty, message, null, "OK", null);
        alertView.Show();
      });
    }
  }
}