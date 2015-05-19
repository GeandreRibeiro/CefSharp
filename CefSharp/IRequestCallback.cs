﻿// Copyright © 2010-2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

namespace CefSharp
{
    public interface IRequestCallback
    {
        /// <summary>
        /// Continue the url request. 
        /// </summary>
        /// <param name="allow">If is true the request will be continued, otherwise, the request will be canceled.</param>
        void Continue(bool allow);
        
        /// <summary>
        /// Cancel the url request.
        /// </summary>
        void Cancel();
    }
}