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

namespace IO.Swagger.Client
{
    /// <summary>
    /// API Exception
    /// </summary>
        public class ApiException : Exception
    {
        /// <summary>
        /// Gets or sets the error code (HTTP status code)
        /// </summary>
        /// <value>The error code (HTTP status code).</value>
        public int ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the error content (body json object)
        /// </summary>
        /// <value>The error content (Http response body).</value>
        public dynamic ErrorContent { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        public ApiException() {}

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        public ApiException(int errorCode, string message) : base(message)
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="errorContent">Error content.</param>
        public ApiException(int errorCode, string message, dynamic errorContent = null) : base(message)
        {
            this.ErrorCode = errorCode;
            this.ErrorContent = errorContent;
        }
    }

}
