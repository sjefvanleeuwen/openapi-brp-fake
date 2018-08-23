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
    public partial class Persoon : IEquatable<Persoon>
    { 
        /// <summary>
        /// Gets or Sets PeriodeGeldigheid
        /// </summary>
        [DataMember(Name="periodeGeldigheid")]
        public PersoonPeriodeGeldigheid PeriodeGeldigheid { get; set; }

        /// <summary>
        /// Gets or Sets VoorlettersAanschrijving
        /// </summary>
        [DataMember(Name="voorlettersAanschrijving")]
        public string VoorlettersAanschrijving { get; set; }

        /// <summary>
        /// Gets or Sets Voornamen
        /// </summary>
        [DataMember(Name="voornamen")]
        public string Voornamen { get; set; }

        /// <summary>
        /// Gets or Sets VoorvoegselGeslachtsnaam
        /// </summary>
        [DataMember(Name="voorvoegselGeslachtsnaam")]
        public string VoorvoegselGeslachtsnaam { get; set; }

        /// <summary>
        /// Gets or Sets Geslachtsnaam
        /// </summary>
        [DataMember(Name="geslachtsnaam")]
        public string Geslachtsnaam { get; set; }

        /// <summary>
        /// Gets or Sets Geslachtsaanduiding
        /// </summary>
        [DataMember(Name="geslachtsaanduiding")]
        public string Geslachtsaanduiding { get; set; }

        /// <summary>
        /// Gets or Sets Aanschrijfwijze
        /// </summary>
        [DataMember(Name="aanschrijfwijze")]
        public string Aanschrijfwijze { get; set; }

        /// <summary>
        /// Gets or Sets Geboortedatum
        /// </summary>
        [DataMember(Name="geboortedatum")]
        public DateTime? Geboortedatum { get; set; }

        /// <summary>
        /// Gets or Sets Verblijfsadres
        /// </summary>
        [DataMember(Name="Verblijfsadres")]
        public Verblijfsadres Verblijfsadres { get; set; }

        /// <summary>
        /// Gets or Sets Adresbuitenland
        /// </summary>
        [DataMember(Name="Adresbuitenland")]
        public Adresbuitenland Adresbuitenland { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Persoon {\n");
            sb.Append("  PeriodeGeldigheid: ").Append(PeriodeGeldigheid).Append("\n");
            sb.Append("  VoorlettersAanschrijving: ").Append(VoorlettersAanschrijving).Append("\n");
            sb.Append("  Voornamen: ").Append(Voornamen).Append("\n");
            sb.Append("  VoorvoegselGeslachtsnaam: ").Append(VoorvoegselGeslachtsnaam).Append("\n");
            sb.Append("  Geslachtsnaam: ").Append(Geslachtsnaam).Append("\n");
            sb.Append("  Geslachtsaanduiding: ").Append(Geslachtsaanduiding).Append("\n");
            sb.Append("  Aanschrijfwijze: ").Append(Aanschrijfwijze).Append("\n");
            sb.Append("  Geboortedatum: ").Append(Geboortedatum).Append("\n");
            sb.Append("  Verblijfsadres: ").Append(Verblijfsadres).Append("\n");
            sb.Append("  Adresbuitenland: ").Append(Adresbuitenland).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Persoon)obj);
        }

        /// <summary>
        /// Returns true if Persoon instances are equal
        /// </summary>
        /// <param name="other">Instance of Persoon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Persoon other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PeriodeGeldigheid == other.PeriodeGeldigheid ||
                    PeriodeGeldigheid != null &&
                    PeriodeGeldigheid.Equals(other.PeriodeGeldigheid)
                ) && 
                (
                    VoorlettersAanschrijving == other.VoorlettersAanschrijving ||
                    VoorlettersAanschrijving != null &&
                    VoorlettersAanschrijving.Equals(other.VoorlettersAanschrijving)
                ) && 
                (
                    Voornamen == other.Voornamen ||
                    Voornamen != null &&
                    Voornamen.Equals(other.Voornamen)
                ) && 
                (
                    VoorvoegselGeslachtsnaam == other.VoorvoegselGeslachtsnaam ||
                    VoorvoegselGeslachtsnaam != null &&
                    VoorvoegselGeslachtsnaam.Equals(other.VoorvoegselGeslachtsnaam)
                ) && 
                (
                    Geslachtsnaam == other.Geslachtsnaam ||
                    Geslachtsnaam != null &&
                    Geslachtsnaam.Equals(other.Geslachtsnaam)
                ) && 
                (
                    Geslachtsaanduiding == other.Geslachtsaanduiding ||
                    Geslachtsaanduiding != null &&
                    Geslachtsaanduiding.Equals(other.Geslachtsaanduiding)
                ) && 
                (
                    Aanschrijfwijze == other.Aanschrijfwijze ||
                    Aanschrijfwijze != null &&
                    Aanschrijfwijze.Equals(other.Aanschrijfwijze)
                ) && 
                (
                    Geboortedatum == other.Geboortedatum ||
                    Geboortedatum != null &&
                    Geboortedatum.Equals(other.Geboortedatum)
                ) && 
                (
                    Verblijfsadres == other.Verblijfsadres ||
                    Verblijfsadres != null &&
                    Verblijfsadres.Equals(other.Verblijfsadres)
                ) && 
                (
                    Adresbuitenland == other.Adresbuitenland ||
                    Adresbuitenland != null &&
                    Adresbuitenland.Equals(other.Adresbuitenland)
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
                    if (PeriodeGeldigheid != null)
                    hashCode = hashCode * 59 + PeriodeGeldigheid.GetHashCode();
                    if (VoorlettersAanschrijving != null)
                    hashCode = hashCode * 59 + VoorlettersAanschrijving.GetHashCode();
                    if (Voornamen != null)
                    hashCode = hashCode * 59 + Voornamen.GetHashCode();
                    if (VoorvoegselGeslachtsnaam != null)
                    hashCode = hashCode * 59 + VoorvoegselGeslachtsnaam.GetHashCode();
                    if (Geslachtsnaam != null)
                    hashCode = hashCode * 59 + Geslachtsnaam.GetHashCode();
                    if (Geslachtsaanduiding != null)
                    hashCode = hashCode * 59 + Geslachtsaanduiding.GetHashCode();
                    if (Aanschrijfwijze != null)
                    hashCode = hashCode * 59 + Aanschrijfwijze.GetHashCode();
                    if (Geboortedatum != null)
                    hashCode = hashCode * 59 + Geboortedatum.GetHashCode();
                    if (Verblijfsadres != null)
                    hashCode = hashCode * 59 + Verblijfsadres.GetHashCode();
                    if (Adresbuitenland != null)
                    hashCode = hashCode * 59 + Adresbuitenland.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Persoon left, Persoon right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Persoon left, Persoon right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}