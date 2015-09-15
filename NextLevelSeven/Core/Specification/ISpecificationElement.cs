﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextLevelSeven.Core.Specification
{
    /// <summary>
    ///     Base interface for HL7 specification interfaces.
    /// </summary>
    public interface ISpecificationElement
    {
        /// <summary>
        ///     True, if the values in the data type are valid and all required fields are populated.
        /// </summary>
        bool IsValid { get; }

        /// <summary>
        ///     Validate each field in the data type. This method throws exceptions on missing required data or invalid data.
        /// </summary>
        void Validate();
    }
}