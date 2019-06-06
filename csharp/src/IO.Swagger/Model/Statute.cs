/* 
 * Workforce Optimisation API
 *
 * Solver engine for solving workforce optimisation problems through the Solvice Optimisation API Platform.  # Workforce Optimisation   Creating an optimal roster for a team of employees based on forecasted demand and taking into account extensive labor agreement rules & constraints.   The Solvice Workforce Optimisation API consists of the following RESTful web services:  * [Shift Planning API](#tag/shift)  * [Task Planning API](#tag/task)  ### Getting started  1. To use one of these APIs, you require an API key. Sign up [here](https://www.solvice.io/onshift/register) to get one.  2. Read the documentation of the desired API below.  3. Start using the API.  To use our Workforce Optimisation API commercially, you can subscribe to a paid plan [here](https://www.solvice.io/onshift/api#pricing).  ### Problems or Questions? If you have problems or questions, we offer you the following options:  * [FAQ](https://www.solvice.io/faq)  * [Open ticket]()  * [Contact us](https://www.solvice.io/contact)  ### Keep up-to-date To get informed about the newest features and development follow us at [twitter](https://twitter.com/solvice_io/). Furthermore you can watch [this git repository](https://github.com/solvice/workforce-api-docs) of this documentation, sign up at our [dashboard](https://dashboard.solvice.io/).   # SDKs  For easier integration start by picking a client library in your language of choice:   - [Java SDK]()  - [Javascript SDK]()  - [Csharp SDK ]()  - [PHP SDK]()     # Explore our APIs   #### Insomnia  To explore our APIs with [Insomnia](https://insomnia.rest/), follow these steps: 1. Open Insomnia and Import [our workspace](https://raw.githubusercontent.com/solvice/workforce-api-docs/master/web/restclients/onshift-insomnia.json). 2. Sign up to get an API key and specify it in your workspace: Manage Environments -> Base Environment -> \"JWT token\": your API key 3. Start exploring  #### Postman To explore our APIs with [Postman](https://www.getpostman.com/), follow these steps: 1. Import our [request collections](https://raw.githubusercontent.com/solvice/workforce-api-doc/master/web/restclients/onshift.postman_collection.json) as well as our [environment file](https://raw.githubusercontent.com/solvice/workforce-api-docs/master/web/restclients/onshift-postman.json). 2. Sign up to get an API key and specify it in your environment: \"api_key\": your API key 3. Start exploring 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: info@solvice.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Statute
    /// </summary>
    [DataContract]
        public partial class Statute :  IEquatable<Statute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Statute" /> class.
        /// </summary>
        /// <param name="">Unique name for a definition of a statute. (required).</param>
        /// <param name="">The minimum number of hours in a shift for an employee.</param>
        /// <param name="">The maximum number of hours in a shift for an employee.</param>
        /// <param name="">The minimum duration (in hours) of a rest period between two shifts for this employee.</param>
        /// <param name="">The maximum days consecutive that this employee can be working.</param>
        /// <param name="">The maximum number of hours this employee can be working in a week.</param>
        /// <param name="">The minimum number of hours this employee should be working in a week.</param>
        /// <param name="">The earliest this employee can start working (expressed as decimal in 24 hour-format).</param>
        /// <param name="">The latest this employee can start working (expressed as decimal in 24 hour-format).</param>
        /// <param name="">The latest this employee can work on a day (expressed as decimal in 24 hour-format).</param>
        /// <param name="">The minimum hours per month this employee should be working.</param>
        /// <param name="">The maximum hours per month this employee should be working.</param>
        /// <param name="">The first time threshold for overtime (expressed as decimal in 24 hour-format).</param>
        /// <param name="">The raise after the first time threshold for overtime (e.q. 1.2 means a 20% raise per hour).</param>
        /// <param name="">The second time threshold for overtime (expressed as decimal in 24 hour-format).</param>
        /// <param name="">The raise after the second time threshold for overtime (e.q. 1.2 means a 20% raise per hour).</param>
        /// <param name="">The number of hours per week after which a \&quot;weekly overtime\&quot; raise should be given.</param>
        /// <param name="">The weekly overtime raise (e.q. 1.2 means a 20% raise per hour).</param>
        /// <param name="">The time threshold to be considered for a night raise (expressed as decimal in 24 hour-format).</param>
        /// <param name="">The raise after the first time threshold for overtime (e.q. 1.2 means a 20% raise per hour).</param>
        public Statute(string  = default(string), int?  = default(int?), int?  = default(int?), int?  = default(int?), int?  = default(int?), int?  = default(int?), int?  = default(int?), BigDecimal  = default(BigDecimal), BigDecimal  = default(BigDecimal), BigDecimal  = default(BigDecimal), int?  = default(int?), int?  = default(int?), BigDecimal  = default(BigDecimal), BigDecimal  = default(BigDecimal), BigDecimal  = default(BigDecimal), BigDecimal  = default(BigDecimal), BigDecimal  = default(BigDecimal), BigDecimal  = default(BigDecimal), BigDecimal  = default(BigDecimal), BigDecimal  = default(BigDecimal))
        {
            // to ensure "" is required (not null)
            if ( == null)
            {
                throw new InvalidDataException(" is a required property for Statute and cannot be null");
            }
            else
            {
                this.Name = ;
            }
            this.MinShiftLength = ;
            this.MaxShiftLength = ;
            this.MinRestBetweenShifts = ;
            this.MaxConsecutiveWorkDays = ;
            this.MaxHrsPerWeek = ;
            this.MinHrsPerWeek = ;
            this.ShiftStart = ;
            this.LatestShiftStart = ;
            this.ShiftEnd = ;
            this.MinHoursMonth = ;
            this.MaxHoursMonth = ;
            this.OverTimeThreshold1 = ;
            this.OverTimeRaise1 = ;
            this.OverTimeThreshold2 = ;
            this.OverTimeRaise2 = ;
            this.OverTimeWeeklyThreshold1 = ;
            this.OverTimeWeeklyRaise1 = ;
            this.NightlyThreshold1 = ;
            this.NightlyRaise = ;
        }
        
        /// <summary>
        /// Unique name for a definition of a statute.
        /// </summary>
        /// <value>Unique name for a definition of a statute.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The minimum number of hours in a shift for an employee
        /// </summary>
        /// <value>The minimum number of hours in a shift for an employee</value>
        [DataMember(Name="minShiftLength", EmitDefaultValue=false)]
        public int? MinShiftLength { get; set; }

        /// <summary>
        /// The maximum number of hours in a shift for an employee
        /// </summary>
        /// <value>The maximum number of hours in a shift for an employee</value>
        [DataMember(Name="maxShiftLength", EmitDefaultValue=false)]
        public int? MaxShiftLength { get; set; }

        /// <summary>
        /// The minimum duration (in hours) of a rest period between two shifts for this employee
        /// </summary>
        /// <value>The minimum duration (in hours) of a rest period between two shifts for this employee</value>
        [DataMember(Name="minRestBetweenShifts", EmitDefaultValue=false)]
        public int? MinRestBetweenShifts { get; set; }

        /// <summary>
        /// The maximum days consecutive that this employee can be working
        /// </summary>
        /// <value>The maximum days consecutive that this employee can be working</value>
        [DataMember(Name="maxConsecutiveWorkDays", EmitDefaultValue=false)]
        public int? MaxConsecutiveWorkDays { get; set; }

        /// <summary>
        /// The maximum number of hours this employee can be working in a week
        /// </summary>
        /// <value>The maximum number of hours this employee can be working in a week</value>
        [DataMember(Name="maxHrsPerWeek", EmitDefaultValue=false)]
        public int? MaxHrsPerWeek { get; set; }

        /// <summary>
        /// The minimum number of hours this employee should be working in a week
        /// </summary>
        /// <value>The minimum number of hours this employee should be working in a week</value>
        [DataMember(Name="minHrsPerWeek", EmitDefaultValue=false)]
        public int? MinHrsPerWeek { get; set; }

        /// <summary>
        /// The earliest this employee can start working (expressed as decimal in 24 hour-format)
        /// </summary>
        /// <value>The earliest this employee can start working (expressed as decimal in 24 hour-format)</value>
        [DataMember(Name="shiftStart", EmitDefaultValue=false)]
        public BigDecimal ShiftStart { get; set; }

        /// <summary>
        /// The latest this employee can start working (expressed as decimal in 24 hour-format)
        /// </summary>
        /// <value>The latest this employee can start working (expressed as decimal in 24 hour-format)</value>
        [DataMember(Name="latestShiftStart", EmitDefaultValue=false)]
        public BigDecimal LatestShiftStart { get; set; }

        /// <summary>
        /// The latest this employee can work on a day (expressed as decimal in 24 hour-format)
        /// </summary>
        /// <value>The latest this employee can work on a day (expressed as decimal in 24 hour-format)</value>
        [DataMember(Name="shiftEnd", EmitDefaultValue=false)]
        public BigDecimal ShiftEnd { get; set; }

        /// <summary>
        /// The minimum hours per month this employee should be working
        /// </summary>
        /// <value>The minimum hours per month this employee should be working</value>
        [DataMember(Name="minHoursMonth", EmitDefaultValue=false)]
        public int? MinHoursMonth { get; set; }

        /// <summary>
        /// The maximum hours per month this employee should be working
        /// </summary>
        /// <value>The maximum hours per month this employee should be working</value>
        [DataMember(Name="maxHoursMonth", EmitDefaultValue=false)]
        public int? MaxHoursMonth { get; set; }

        /// <summary>
        /// The first time threshold for overtime (expressed as decimal in 24 hour-format)
        /// </summary>
        /// <value>The first time threshold for overtime (expressed as decimal in 24 hour-format)</value>
        [DataMember(Name="overTimeThreshold1", EmitDefaultValue=false)]
        public BigDecimal OverTimeThreshold1 { get; set; }

        /// <summary>
        /// The raise after the first time threshold for overtime (e.q. 1.2 means a 20% raise per hour)
        /// </summary>
        /// <value>The raise after the first time threshold for overtime (e.q. 1.2 means a 20% raise per hour)</value>
        [DataMember(Name="overTimeRaise1", EmitDefaultValue=false)]
        public BigDecimal OverTimeRaise1 { get; set; }

        /// <summary>
        /// The second time threshold for overtime (expressed as decimal in 24 hour-format)
        /// </summary>
        /// <value>The second time threshold for overtime (expressed as decimal in 24 hour-format)</value>
        [DataMember(Name="overTimeThreshold2", EmitDefaultValue=false)]
        public BigDecimal OverTimeThreshold2 { get; set; }

        /// <summary>
        /// The raise after the second time threshold for overtime (e.q. 1.2 means a 20% raise per hour)
        /// </summary>
        /// <value>The raise after the second time threshold for overtime (e.q. 1.2 means a 20% raise per hour)</value>
        [DataMember(Name="overTimeRaise2", EmitDefaultValue=false)]
        public BigDecimal OverTimeRaise2 { get; set; }

        /// <summary>
        /// The number of hours per week after which a \&quot;weekly overtime\&quot; raise should be given
        /// </summary>
        /// <value>The number of hours per week after which a \&quot;weekly overtime\&quot; raise should be given</value>
        [DataMember(Name="overTimeWeeklyThreshold1", EmitDefaultValue=false)]
        public BigDecimal OverTimeWeeklyThreshold1 { get; set; }

        /// <summary>
        /// The weekly overtime raise (e.q. 1.2 means a 20% raise per hour)
        /// </summary>
        /// <value>The weekly overtime raise (e.q. 1.2 means a 20% raise per hour)</value>
        [DataMember(Name="overTimeWeeklyRaise1", EmitDefaultValue=false)]
        public BigDecimal OverTimeWeeklyRaise1 { get; set; }

        /// <summary>
        /// The time threshold to be considered for a night raise (expressed as decimal in 24 hour-format)
        /// </summary>
        /// <value>The time threshold to be considered for a night raise (expressed as decimal in 24 hour-format)</value>
        [DataMember(Name="nightlyThreshold1", EmitDefaultValue=false)]
        public BigDecimal NightlyThreshold1 { get; set; }

        /// <summary>
        /// The raise after the first time threshold for overtime (e.q. 1.2 means a 20% raise per hour)
        /// </summary>
        /// <value>The raise after the first time threshold for overtime (e.q. 1.2 means a 20% raise per hour)</value>
        [DataMember(Name="nightlyRaise", EmitDefaultValue=false)]
        public BigDecimal NightlyRaise { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Statute {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MinShiftLength: ").Append(MinShiftLength).Append("\n");
            sb.Append("  MaxShiftLength: ").Append(MaxShiftLength).Append("\n");
            sb.Append("  MinRestBetweenShifts: ").Append(MinRestBetweenShifts).Append("\n");
            sb.Append("  MaxConsecutiveWorkDays: ").Append(MaxConsecutiveWorkDays).Append("\n");
            sb.Append("  MaxHrsPerWeek: ").Append(MaxHrsPerWeek).Append("\n");
            sb.Append("  MinHrsPerWeek: ").Append(MinHrsPerWeek).Append("\n");
            sb.Append("  ShiftStart: ").Append(ShiftStart).Append("\n");
            sb.Append("  LatestShiftStart: ").Append(LatestShiftStart).Append("\n");
            sb.Append("  ShiftEnd: ").Append(ShiftEnd).Append("\n");
            sb.Append("  MinHoursMonth: ").Append(MinHoursMonth).Append("\n");
            sb.Append("  MaxHoursMonth: ").Append(MaxHoursMonth).Append("\n");
            sb.Append("  OverTimeThreshold1: ").Append(OverTimeThreshold1).Append("\n");
            sb.Append("  OverTimeRaise1: ").Append(OverTimeRaise1).Append("\n");
            sb.Append("  OverTimeThreshold2: ").Append(OverTimeThreshold2).Append("\n");
            sb.Append("  OverTimeRaise2: ").Append(OverTimeRaise2).Append("\n");
            sb.Append("  OverTimeWeeklyThreshold1: ").Append(OverTimeWeeklyThreshold1).Append("\n");
            sb.Append("  OverTimeWeeklyRaise1: ").Append(OverTimeWeeklyRaise1).Append("\n");
            sb.Append("  NightlyThreshold1: ").Append(NightlyThreshold1).Append("\n");
            sb.Append("  NightlyRaise: ").Append(NightlyRaise).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Statute);
        }

        /// <summary>
        /// Returns true if Statute instances are equal
        /// </summary>
        /// <param name="input">Instance of Statute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Statute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MinShiftLength == input.MinShiftLength ||
                    (this.MinShiftLength != null &&
                    this.MinShiftLength.Equals(input.MinShiftLength))
                ) && 
                (
                    this.MaxShiftLength == input.MaxShiftLength ||
                    (this.MaxShiftLength != null &&
                    this.MaxShiftLength.Equals(input.MaxShiftLength))
                ) && 
                (
                    this.MinRestBetweenShifts == input.MinRestBetweenShifts ||
                    (this.MinRestBetweenShifts != null &&
                    this.MinRestBetweenShifts.Equals(input.MinRestBetweenShifts))
                ) && 
                (
                    this.MaxConsecutiveWorkDays == input.MaxConsecutiveWorkDays ||
                    (this.MaxConsecutiveWorkDays != null &&
                    this.MaxConsecutiveWorkDays.Equals(input.MaxConsecutiveWorkDays))
                ) && 
                (
                    this.MaxHrsPerWeek == input.MaxHrsPerWeek ||
                    (this.MaxHrsPerWeek != null &&
                    this.MaxHrsPerWeek.Equals(input.MaxHrsPerWeek))
                ) && 
                (
                    this.MinHrsPerWeek == input.MinHrsPerWeek ||
                    (this.MinHrsPerWeek != null &&
                    this.MinHrsPerWeek.Equals(input.MinHrsPerWeek))
                ) && 
                (
                    this.ShiftStart == input.ShiftStart ||
                    (this.ShiftStart != null &&
                    this.ShiftStart.Equals(input.ShiftStart))
                ) && 
                (
                    this.LatestShiftStart == input.LatestShiftStart ||
                    (this.LatestShiftStart != null &&
                    this.LatestShiftStart.Equals(input.LatestShiftStart))
                ) && 
                (
                    this.ShiftEnd == input.ShiftEnd ||
                    (this.ShiftEnd != null &&
                    this.ShiftEnd.Equals(input.ShiftEnd))
                ) && 
                (
                    this.MinHoursMonth == input.MinHoursMonth ||
                    (this.MinHoursMonth != null &&
                    this.MinHoursMonth.Equals(input.MinHoursMonth))
                ) && 
                (
                    this.MaxHoursMonth == input.MaxHoursMonth ||
                    (this.MaxHoursMonth != null &&
                    this.MaxHoursMonth.Equals(input.MaxHoursMonth))
                ) && 
                (
                    this.OverTimeThreshold1 == input.OverTimeThreshold1 ||
                    (this.OverTimeThreshold1 != null &&
                    this.OverTimeThreshold1.Equals(input.OverTimeThreshold1))
                ) && 
                (
                    this.OverTimeRaise1 == input.OverTimeRaise1 ||
                    (this.OverTimeRaise1 != null &&
                    this.OverTimeRaise1.Equals(input.OverTimeRaise1))
                ) && 
                (
                    this.OverTimeThreshold2 == input.OverTimeThreshold2 ||
                    (this.OverTimeThreshold2 != null &&
                    this.OverTimeThreshold2.Equals(input.OverTimeThreshold2))
                ) && 
                (
                    this.OverTimeRaise2 == input.OverTimeRaise2 ||
                    (this.OverTimeRaise2 != null &&
                    this.OverTimeRaise2.Equals(input.OverTimeRaise2))
                ) && 
                (
                    this.OverTimeWeeklyThreshold1 == input.OverTimeWeeklyThreshold1 ||
                    (this.OverTimeWeeklyThreshold1 != null &&
                    this.OverTimeWeeklyThreshold1.Equals(input.OverTimeWeeklyThreshold1))
                ) && 
                (
                    this.OverTimeWeeklyRaise1 == input.OverTimeWeeklyRaise1 ||
                    (this.OverTimeWeeklyRaise1 != null &&
                    this.OverTimeWeeklyRaise1.Equals(input.OverTimeWeeklyRaise1))
                ) && 
                (
                    this.NightlyThreshold1 == input.NightlyThreshold1 ||
                    (this.NightlyThreshold1 != null &&
                    this.NightlyThreshold1.Equals(input.NightlyThreshold1))
                ) && 
                (
                    this.NightlyRaise == input.NightlyRaise ||
                    (this.NightlyRaise != null &&
                    this.NightlyRaise.Equals(input.NightlyRaise))
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
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MinShiftLength != null)
                    hashCode = hashCode * 59 + this.MinShiftLength.GetHashCode();
                if (this.MaxShiftLength != null)
                    hashCode = hashCode * 59 + this.MaxShiftLength.GetHashCode();
                if (this.MinRestBetweenShifts != null)
                    hashCode = hashCode * 59 + this.MinRestBetweenShifts.GetHashCode();
                if (this.MaxConsecutiveWorkDays != null)
                    hashCode = hashCode * 59 + this.MaxConsecutiveWorkDays.GetHashCode();
                if (this.MaxHrsPerWeek != null)
                    hashCode = hashCode * 59 + this.MaxHrsPerWeek.GetHashCode();
                if (this.MinHrsPerWeek != null)
                    hashCode = hashCode * 59 + this.MinHrsPerWeek.GetHashCode();
                if (this.ShiftStart != null)
                    hashCode = hashCode * 59 + this.ShiftStart.GetHashCode();
                if (this.LatestShiftStart != null)
                    hashCode = hashCode * 59 + this.LatestShiftStart.GetHashCode();
                if (this.ShiftEnd != null)
                    hashCode = hashCode * 59 + this.ShiftEnd.GetHashCode();
                if (this.MinHoursMonth != null)
                    hashCode = hashCode * 59 + this.MinHoursMonth.GetHashCode();
                if (this.MaxHoursMonth != null)
                    hashCode = hashCode * 59 + this.MaxHoursMonth.GetHashCode();
                if (this.OverTimeThreshold1 != null)
                    hashCode = hashCode * 59 + this.OverTimeThreshold1.GetHashCode();
                if (this.OverTimeRaise1 != null)
                    hashCode = hashCode * 59 + this.OverTimeRaise1.GetHashCode();
                if (this.OverTimeThreshold2 != null)
                    hashCode = hashCode * 59 + this.OverTimeThreshold2.GetHashCode();
                if (this.OverTimeRaise2 != null)
                    hashCode = hashCode * 59 + this.OverTimeRaise2.GetHashCode();
                if (this.OverTimeWeeklyThreshold1 != null)
                    hashCode = hashCode * 59 + this.OverTimeWeeklyThreshold1.GetHashCode();
                if (this.OverTimeWeeklyRaise1 != null)
                    hashCode = hashCode * 59 + this.OverTimeWeeklyRaise1.GetHashCode();
                if (this.NightlyThreshold1 != null)
                    hashCode = hashCode * 59 + this.NightlyThreshold1.GetHashCode();
                if (this.NightlyRaise != null)
                    hashCode = hashCode * 59 + this.NightlyRaise.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}