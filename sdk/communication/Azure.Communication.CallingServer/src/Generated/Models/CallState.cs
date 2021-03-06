// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallingServer
{
    /// <summary> The call state. </summary>
    public readonly partial struct CallState : IEquatable<CallState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CallState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CallState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "unknown";
        private const string IdleValue = "idle";
        private const string IncomingValue = "incoming";
        private const string EstablishingValue = "establishing";
        private const string EstablishedValue = "established";
        private const string HoldValue = "hold";
        private const string UnholdValue = "unhold";
        private const string TransferringValue = "transferring";
        private const string RedirectingValue = "redirecting";
        private const string TerminatingValue = "terminating";
        private const string TerminatedValue = "terminated";

        /// <summary> unknown. </summary>
        public static CallState Unknown { get; } = new CallState(UnknownValue);
        /// <summary> idle. </summary>
        public static CallState Idle { get; } = new CallState(IdleValue);
        /// <summary> incoming. </summary>
        public static CallState Incoming { get; } = new CallState(IncomingValue);
        /// <summary> establishing. </summary>
        public static CallState Establishing { get; } = new CallState(EstablishingValue);
        /// <summary> established. </summary>
        public static CallState Established { get; } = new CallState(EstablishedValue);
        /// <summary> hold. </summary>
        public static CallState Hold { get; } = new CallState(HoldValue);
        /// <summary> unhold. </summary>
        public static CallState Unhold { get; } = new CallState(UnholdValue);
        /// <summary> transferring. </summary>
        public static CallState Transferring { get; } = new CallState(TransferringValue);
        /// <summary> redirecting. </summary>
        public static CallState Redirecting { get; } = new CallState(RedirectingValue);
        /// <summary> terminating. </summary>
        public static CallState Terminating { get; } = new CallState(TerminatingValue);
        /// <summary> terminated. </summary>
        public static CallState Terminated { get; } = new CallState(TerminatedValue);
        /// <summary> Determines if two <see cref="CallState"/> values are the same. </summary>
        public static bool operator ==(CallState left, CallState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CallState"/> values are not the same. </summary>
        public static bool operator !=(CallState left, CallState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CallState"/>. </summary>
        public static implicit operator CallState(string value) => new CallState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CallState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CallState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
