﻿using System;
using System.Net;

namespace NuGet
{
    public class WebRequestEventArgs : EventArgs
    {
        public WebRequestEventArgs(WebRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            Request = request;
        }

        public WebRequest Request { get; private set; }
    }
}