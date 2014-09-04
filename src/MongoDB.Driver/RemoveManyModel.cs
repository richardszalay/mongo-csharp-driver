﻿/* Copyright 2010-2014 MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Core.Misc;
using MongoDB.Driver.Core.Operations;

namespace MongoDB.Driver
{
    /// <summary>
    /// Model for removing many documents.
    /// </summary>
    public sealed class RemoveManyModel<T> : WriteModel<T>
    {
        // fields
        private readonly object _criteria;

        // constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveManyModel{T}"/> class.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        public RemoveManyModel(object criteria)
        {
            _criteria = Ensure.IsNotNull(criteria, "criteria");
        }

        // properties
        /// <summary>
        /// Gets the document.
        /// </summary>
        public object Criteria
        {
            get { return _criteria; }
        }

        /// <summary>
        /// Gets the type of the model.
        /// </summary>
        public override WriteModelType ModelType
        {
            get { return WriteModelType.RemoveMany; }
        }
    }
}
