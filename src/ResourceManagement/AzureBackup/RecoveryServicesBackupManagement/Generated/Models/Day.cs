// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    /// <summary>
    /// The definition of a Day object.
    /// </summary>
    public partial class Day
    {
        private int _date;
        
        /// <summary>
        /// Optional. Date for the day of month.
        /// </summary>
        public int Date
        {
            get { return this._date; }
            set { this._date = value; }
        }
        
        private bool _isLast;
        
        /// <summary>
        /// Optional. IsLast.
        /// </summary>
        public bool IsLast
        {
            get { return this._isLast; }
            set { this._isLast = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Day class.
        /// </summary>
        public Day()
        {
        }
    }
}
