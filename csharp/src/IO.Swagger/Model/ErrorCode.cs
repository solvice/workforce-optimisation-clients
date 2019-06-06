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
    /// ErrorCode
    /// </summary>
    [DataContract]
        public partial class ErrorCode :  IEquatable<ErrorCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorCode" /> class.
        /// </summary>
        /// <param name="">.</param>
        /// <param name="">.</param>
        /// <param name="">.</param>
        /// <param name="">.</param>
        public ErrorCode(string  = default(string), string  = default(string), int?  = default(int?), int?  = default(int?))
        {
            this._ErrorCode = ;
            this.Explanation = ;
            this.Line = ;
            this.Column = ;
        }
        
        /// <summary>
        /// Gets or Sets _ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string _ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets Explanation
        /// </summary>
        [DataMember(Name="explanation", EmitDefaultValue=false)]
        public string Explanation { get; set; }

        /// <summary>
        /// Gets or Sets Line
        /// </summary>
        [DataMember(Name="line", EmitDefaultValue=false)]
        public int? Line { get; set; }

        /// <summary>
        /// Gets or Sets Column
        /// </summary>
        [DataMember(Name="column", EmitDefaultValue=false)]
        public int? Column { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorCode {\n");
            sb.Append("  _ErrorCode: ").Append(_ErrorCode).Append("\n");
            sb.Append("  Explanation: ").Append(Explanation).Append("\n");
            sb.Append("  Line: ").Append(Line).Append("\n");
            sb.Append("  Column: ").Append(Column).Append("\n");
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
            return this.Equals(input as ErrorCode);
        }

        /// <summary>
        /// Returns true if ErrorCode instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorCode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._ErrorCode == input._ErrorCode ||
                    (this._ErrorCode != null &&
                    this._ErrorCode.Equals(input._ErrorCode))
                ) && 
                (
                    this.Explanation == input.Explanation ||
                    (this.Explanation != null &&
                    this.Explanation.Equals(input.Explanation))
                ) && 
                (
                    this.Line == input.Line ||
                    (this.Line != null &&
                    this.Line.Equals(input.Line))
                ) && 
                (
                    this.Column == input.Column ||
                    (this.Column != null &&
                    this.Column.Equals(input.Column))
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
                if (this._ErrorCode != null)
                    hashCode = hashCode * 59 + this._ErrorCode.GetHashCode();
                if (this.Explanation != null)
                    hashCode = hashCode * 59 + this.Explanation.GetHashCode();
                if (this.Line != null)
                    hashCode = hashCode * 59 + this.Line.GetHashCode();
                if (this.Column != null)
                    hashCode = hashCode * 59 + this.Column.GetHashCode();
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
