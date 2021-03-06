// Copyright 2018, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Newtonsoft.Json;

namespace FirebaseAdmin.Messaging
{
    /// <summary>
    /// Represents the notification parameters that can be included in a <see cref="Message"/>.
    /// </summary>
    public sealed class Notification
    {
        /// <summary>
        /// Gets or sets the title of the notification.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the body of the notification.
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// Copies this notification. There is nothing to be validated in this class, but we use
        /// the same method name as in other classes in this namespace.
        /// </summary>
        internal Notification CopyAndValidate()
        {
            return new Notification()
            {
                Title = this.Title,
                Body = this.Body,
            };
        }
    }
}
