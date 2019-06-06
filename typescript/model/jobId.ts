/**
 * Workforce Optimisation API
 * Solver engine for solving workforce optimisation problems through the Solvice Optimisation API Platform.  # Workforce Optimisation   Creating an optimal roster for a team of employees based on forecasted demand and taking into account extensive labor agreement rules & constraints.   The Solvice Workforce Optimisation API consists of the following RESTful web services:  * [Shift Planning API](#tag/shift)  * [Task Planning API](#tag/task)  ### Getting started  1. To use one of these APIs, you require an API key. Sign up [here](https://www.solvice.io/onshift/register) to get one.  2. Read the documentation of the desired API below.  3. Start using the API.  To use our Workforce Optimisation API commercially, you can subscribe to a paid plan [here](https://www.solvice.io/onshift/api#pricing).  ### Problems or Questions? If you have problems or questions, we offer you the following options:  * [FAQ](https://www.solvice.io/faq)  * [Open ticket]()  * [Contact us](https://www.solvice.io/contact)  ### Keep up-to-date To get informed about the newest features and development follow us at [twitter](https://twitter.com/solvice_io/). Furthermore you can watch [this git repository](https://github.com/solvice/workforce-api-docs) of this documentation, sign up at our [dashboard](https://dashboard.solvice.io/).   # SDKs  For easier integration start by picking a client library in your language of choice:   - [Java SDK]()  - [Javascript SDK]()  - [Csharp SDK ]()  - [PHP SDK]()     # Explore our APIs   #### Insomnia  To explore our APIs with [Insomnia](https://insomnia.rest/), follow these steps: 1. Open Insomnia and Import [our workspace](https://raw.githubusercontent.com/solvice/workforce-api-docs/master/web/restclients/onshift-insomnia.json). 2. Sign up to get an API key and specify it in your workspace: Manage Environments -> Base Environment -> \"JWT token\": your API key 3. Start exploring  #### Postman To explore our APIs with [Postman](https://www.getpostman.com/), follow these steps: 1. Import our [request collections](https://raw.githubusercontent.com/solvice/workforce-api-doc/master/web/restclients/onshift.postman_collection.json) as well as our [environment file](https://raw.githubusercontent.com/solvice/workforce-api-docs/master/web/restclients/onshift-postman.json). 2. Sign up to get an API key and specify it in your environment: \"api_key\": your API key 3. Start exploring 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: info@solvice.io
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

/**
 * Job ID
 */
export type JobId = string;