// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> Type of connection monitor. </summary>
    public readonly partial struct ConnectionMonitorType : IEquatable<ConnectionMonitorType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ConnectionMonitorType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectionMonitorType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MultiEndpointValue = "MultiEndpoint";
        private const string SingleSourceDestinationValue = "SingleSourceDestination";

        /// <summary> MultiEndpoint. </summary>
        public static ConnectionMonitorType MultiEndpoint { get; } = new ConnectionMonitorType(MultiEndpointValue);
        /// <summary> SingleSourceDestination. </summary>
        public static ConnectionMonitorType SingleSourceDestination { get; } = new ConnectionMonitorType(SingleSourceDestinationValue);
        /// <summary> Determines if two <see cref="ConnectionMonitorType"/> values are the same. </summary>
        public static bool operator ==(ConnectionMonitorType left, ConnectionMonitorType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectionMonitorType"/> values are not the same. </summary>
        public static bool operator !=(ConnectionMonitorType left, ConnectionMonitorType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConnectionMonitorType"/>. </summary>
        public static implicit operator ConnectionMonitorType(string value) => new ConnectionMonitorType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectionMonitorType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectionMonitorType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}