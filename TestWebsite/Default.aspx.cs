﻿/*
 * BitlyDotNet
 * 
 * Copyright (c) 2009 Mike Gleason jr Couturier (http://blog.mikecouturier.com/search/label/bitly-dot-net)
 * 
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the
 * "Software"), to deal in the Software without restriction, including
 * without limitation the rights to use, copy, modify, merge, publish,
 * distribute, sublicense, and/or sell copies of the Software, and to
 * permit persons to whom the Software is furnished to do so, subject to
 * the following conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
 * LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
 * OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
 * WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 */
using System;

using BitlyDotNET.Interfaces;
using BitlyDotNET.Implementations;
using System.Collections.Generic;

namespace TestWebsite
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            BitlyService s = new BitlyService("bitlyapidemo", "R_0da49e0a9118ff35f52f629d2d71bf07");
			string shortened;
			StatusCode status = s.Shorten("http://cnn.com", out shortened);
            IBitlyResponse[] shortUrls = s.Shorten(new string[] { "http://cnn.com", "http://google.com" }, out status);
		}
	}
}
