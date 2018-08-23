/*
 * NPS op RaadpleegIngeschrevenPersoonNAW
 *
 * Specificatie RSGB 3.0 Json opvragen NPS
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class AdresbuitenlandLandcode : IEquatable<AdresbuitenlandLandcode>
    { 
        /// <summary>
        /// Gets or Sets AdresBuiteland3
        /// </summary>
        [DataMember(Name="adresBuiteland3")]
        public string AdresBuiteland3 { get; set; }

        /// <summary>
        /// Gets or Sets AdresBuiteland1
        /// </summary>
        [DataMember(Name="adresBuiteland1")]
        public string AdresBuiteland1 { get; set; }

        /// <summary>
        /// Gets or Sets AdresBuiteland2
        /// </summary>
        [DataMember(Name="adresBuiteland2")]
        public string AdresBuiteland2 { get; set; }

        /// <summary>
        /// Gets or Sets Landnaam
        /// </summary>
        [DataMember(Name="landnaam")]
        public string Landnaam { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdresbuitenlandLandcode {\n");
            sb.Append("  AdresBuiteland3: ").Append(AdresBuiteland3).Append("\n");
            sb.Append("  AdresBuiteland1: ").Append(AdresBuiteland1).Append("\n");
            sb.Append("  AdresBuiteland2: ").Append(AdresBuiteland2).Append("\n");
            sb.Append("  Landnaam: ").Append(Landnaam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((AdresbuitenlandLandcode)obj);
        }

        /// <summary>
        /// Returns true if AdresbuitenlandLandcode instances are equal
        /// </summary>
        /// <param name="other">Instance of AdresbuitenlandLandcode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdresbuitenlandLandcode other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AdresBuiteland3 == other.AdresBuiteland3 ||
                    AdresBuiteland3 != null &&
                    AdresBuiteland3.Equals(other.AdresBuiteland3)
                ) && 
                (
                    AdresBuiteland1 == other.AdresBuiteland1 ||
                    AdresBuiteland1 != null &&
                    AdresBuiteland1.Equals(other.AdresBuiteland1)
                ) && 
                (
                    AdresBuiteland2 == other.AdresBuiteland2 ||
                    AdresBuiteland2 != null &&
                    AdresBuiteland2.Equals(other.AdresBuiteland2)
                ) && 
                (
                    Landnaam == other.Landnaam ||
                    Landnaam != null &&
                    Landnaam.Equals(other.Landnaam)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (AdresBuiteland3 != null)
                    hashCode = hashCode * 59 + AdresBuiteland3.GetHashCode();
                    if (AdresBuiteland1 != null)
                    hashCode = hashCode * 59 + AdresBuiteland1.GetHashCode();
                    if (AdresBuiteland2 != null)
                    hashCode = hashCode * 59 + AdresBuiteland2.GetHashCode();
                    if (Landnaam != null)
                    hashCode = hashCode * 59 + Landnaam.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AdresbuitenlandLandcode left, AdresbuitenlandLandcode right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AdresbuitenlandLandcode left, AdresbuitenlandLandcode right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}