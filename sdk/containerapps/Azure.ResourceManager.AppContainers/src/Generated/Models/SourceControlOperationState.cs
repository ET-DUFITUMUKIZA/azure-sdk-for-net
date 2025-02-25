// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Current provisioning State of the operation. </summary>
    public readonly partial struct SourceControlOperationState : IEquatable<SourceControlOperationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SourceControlOperationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SourceControlOperationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> InProgress. </summary>
        public static SourceControlOperationState InProgress { get; } = new SourceControlOperationState(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static SourceControlOperationState Succeeded { get; } = new SourceControlOperationState(SucceededValue);
        /// <summary> Failed. </summary>
        public static SourceControlOperationState Failed { get; } = new SourceControlOperationState(FailedValue);
        /// <summary> Canceled. </summary>
        public static SourceControlOperationState Canceled { get; } = new SourceControlOperationState(CanceledValue);
        /// <summary> Determines if two <see cref="SourceControlOperationState"/> values are the same. </summary>
        public static bool operator ==(SourceControlOperationState left, SourceControlOperationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SourceControlOperationState"/> values are not the same. </summary>
        public static bool operator !=(SourceControlOperationState left, SourceControlOperationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SourceControlOperationState"/>. </summary>
        public static implicit operator SourceControlOperationState(string value) => new SourceControlOperationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SourceControlOperationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SourceControlOperationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
