﻿using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Segment.Model
{
    public abstract class BaseAction
    {

		public Options Options;

		[JsonProperty(PropertyName="timestamp")]
		public string Timestamp { get; private set; }

		public BaseAction(DateTime? timestamp, Options options)
		{
			if (timestamp.HasValue) this.Timestamp = timestamp.Value.ToString("o");
			this.Options = options == null ? new Options() : options;
        }

        /// <summary>
        /// Returns the string name representing this action based on the Segment.io REST API.
        /// A track returns "track", etc..
        /// </summary>
        /// <returns></returns>
        public abstract string GetAction();
    }
}
