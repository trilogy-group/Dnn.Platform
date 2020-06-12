﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

#region Usings

using System.Collections;

#endregion

namespace DotNetNuke.Services.EventQueue
{
    public class EventMessageCollection : CollectionBase
    {
        public virtual EventMessage this[int index]
        {
            get
            {
                return (EventMessage)this.List[index];
            }
            set
            {
                this.List[index] = value;
            }
        }

        public void Add(EventMessage message)
        {
            this.InnerList.Add(message);
        }
    }
}
