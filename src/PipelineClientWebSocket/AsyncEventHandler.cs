﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientWebSocket.Pipeline
{
    /// <summary>
    /// An asynchronous event handler.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="args">Event arguments.</param>
    /// <returns>A task whose completion signals handling is finished.</returns>
    public delegate ValueTask AsyncEventHandler(object sender, EventArgs args);

    /// <summary>
    /// An asynchronous event handler.
    /// </summary>
    /// <typeparam name="TEventArgs">The type of event arguments.</typeparam>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="args">Event arguments.</param>
    /// <returns>A task whose completion signals handling is finished.</returns>
    public delegate ValueTask AsyncEventHandler<TEventArgs>(object sender, TEventArgs args);
}
