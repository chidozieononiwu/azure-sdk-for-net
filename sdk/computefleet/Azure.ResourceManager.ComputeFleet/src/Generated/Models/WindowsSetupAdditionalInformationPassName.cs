// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> The WindowsSetupAdditionalInformationPassName. </summary>
    public readonly partial struct WindowsSetupAdditionalInformationPassName : IEquatable<WindowsSetupAdditionalInformationPassName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WindowsSetupAdditionalInformationPassName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WindowsSetupAdditionalInformationPassName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OobeSystemValue = "OobeSystem";

        /// <summary> OobeSystem. </summary>
        public static WindowsSetupAdditionalInformationPassName OobeSystem { get; } = new WindowsSetupAdditionalInformationPassName(OobeSystemValue);
        /// <summary> Determines if two <see cref="WindowsSetupAdditionalInformationPassName"/> values are the same. </summary>
        public static bool operator ==(WindowsSetupAdditionalInformationPassName left, WindowsSetupAdditionalInformationPassName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WindowsSetupAdditionalInformationPassName"/> values are not the same. </summary>
        public static bool operator !=(WindowsSetupAdditionalInformationPassName left, WindowsSetupAdditionalInformationPassName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="WindowsSetupAdditionalInformationPassName"/>. </summary>
        public static implicit operator WindowsSetupAdditionalInformationPassName(string value) => new WindowsSetupAdditionalInformationPassName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WindowsSetupAdditionalInformationPassName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WindowsSetupAdditionalInformationPassName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
