﻿// *******************************************************************************
// <copyright file="ApiException.cs" company="Intuit">
// Copyright (c) 2019 Intuit
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
// *******************************************************************************

namespace Intuit.TSheets.Model.Exceptions
{
    using System;
    using System.Runtime.Serialization;
    using System.Security.Permissions;
    
    /// <summary>
    /// Common base exception class for errors from the API calls
    /// </summary>
    [Serializable]
    public abstract class ApiException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        protected ApiException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="message">
        /// The error message that explains the reason for the exception.
        /// </param>
        protected ApiException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="message">
        /// The error message that explains the reason for the exception.
        /// </param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception.
        /// </param>
        protected ApiException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="errorCode">
        /// The error code value.
        /// </param> 
        /// <param name="errorText">
        /// Short error text returned from the API call.
        /// </param> 
        /// <param name="message">
        /// The error message that explains the reason for the exception.
        /// </param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception.
        /// </param>
        protected ApiException(int errorCode, string errorText, string message, Exception innerException)
            : base(message, innerException)
        {
            ErrorCode = errorCode;
            ErrorText = errorText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="info">
        /// The <see cref="SerializationInfo"/> that holds the serialized
        /// object data about the exception being thrown.
        /// </param>
        /// <param name="context">
        /// The <see cref="StreamingContext"/> that contains contextual
        /// information about the source or destination.
        /// </param>
        protected ApiException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            ErrorCode = info.GetInt32("ErrorCode");
            ErrorText = info.GetString("ErrorText");
        }

        /// <summary>
        /// Gets or sets the HTTP error code (if any)
        /// </summary>
        public int? ErrorCode { get; protected set; }

        /// <summary>
        /// Gets or sets the error text returned from the API call (only available on certain end points)
        /// </summary>
        public string ErrorText { get; protected set; }

        /// <summary>
        /// Sets the <see cref="SerializationInfo"/> with information about the exception.
        /// </summary>
        /// <param name="info">
        /// The <see cref="SerializationInfo"/> that holds the serialized
        /// object data about the exception being thrown.
        /// </param>
        /// <param name="context">
        /// The <see cref="StreamingContext"/> that contains contextual
        /// information about the source or destination.
        /// </param>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            info.AddValue("ErrorCode", ErrorCode);
            info.AddValue("ErrorText", ErrorText);
            base.GetObjectData(info, context);
        }
    }
}
