# coding: utf-8

"""
    Workforce Optimisation API

    Solver engine for solving workforce optimisation problems through the Solvice Optimisation API Platform.  # Workforce Optimisation   Creating an optimal roster for a team of employees based on forecasted demand and taking into account extensive labor agreement rules & constraints.   The Solvice Workforce Optimisation API consists of the following RESTful web services:  * [Shift Planning API](#tag/shift)  * [Task Planning API](#tag/task)  ### Getting started  1. To use one of these APIs, you require an API key. Sign up [here](https://www.solvice.io/onshift/register) to get one.  2. Read the documentation of the desired API below.  3. Start using the API.  To use our Workforce Optimisation API commercially, you can subscribe to a paid plan [here](https://www.solvice.io/onshift/api#pricing).  ### Problems or Questions? If you have problems or questions, we offer you the following options:  * [FAQ](https://www.solvice.io/faq)  * [Open ticket]()  * [Contact us](https://www.solvice.io/contact)  ### Keep up-to-date To get informed about the newest features and development follow us at [twitter](https://twitter.com/solvice_io/). Furthermore you can watch [this git repository](https://github.com/solvice/workforce-api-docs) of this documentation, sign up at our [dashboard](https://dashboard.solvice.io/).   # SDKs  For easier integration start by picking a client library in your language of choice:   - [Java SDK]()  - [Javascript SDK]()  - [Csharp SDK ]()  - [PHP SDK]()     # Explore our APIs   #### Insomnia  To explore our APIs with [Insomnia](https://insomnia.rest/), follow these steps: 1. Open Insomnia and Import [our workspace](https://raw.githubusercontent.com/solvice/workforce-api-docs/master/web/restclients/onshift-insomnia.json). 2. Sign up to get an API key and specify it in your workspace: Manage Environments -> Base Environment -> \"JWT token\": your API key 3. Start exploring  #### Postman To explore our APIs with [Postman](https://www.getpostman.com/), follow these steps: 1. Import our [request collections](https://raw.githubusercontent.com/solvice/workforce-api-doc/master/web/restclients/onshift.postman_collection.json) as well as our [environment file](https://raw.githubusercontent.com/solvice/workforce-api-docs/master/web/restclients/onshift-postman.json). 2. Sign up to get an API key and specify it in your environment: \"api_key\": your API key 3. Start exploring   # noqa: E501

    OpenAPI spec version: 1.0.0
    Contact: info@solvice.io
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

import re  # noqa: F401

# python 2 and python 3 compatibility library
import six

from swagger_client.api_client import ApiClient


class ShiftAPIApi(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    Ref: https://github.com/swagger-api/swagger-codegen
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

    def get_solution(self, job_id, **kwargs):  # noqa: E501
        """Get a solution  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.get_solution(job_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str job_id: Job ID (required)
        :return: Object
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.get_solution_with_http_info(job_id, **kwargs)  # noqa: E501
        else:
            (data) = self.get_solution_with_http_info(job_id, **kwargs)  # noqa: E501
            return data

    def get_solution_with_http_info(self, job_id, **kwargs):  # noqa: E501
        """Get a solution  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.get_solution_with_http_info(job_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str job_id: Job ID (required)
        :return: Object
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['job_id']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_solution" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'job_id' is set
        if ('job_id' not in params or
                params['job_id'] is None):
            raise ValueError("Missing the required parameter `job_id` when calling `get_solution`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'job_id' in params:
            path_params['jobId'] = params['job_id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['bearerAuth']  # noqa: E501

        return self.api_client.call_api(
            '/jobs/{jobId}/solution', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Object',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def get_status(self, job_id, **kwargs):  # noqa: E501
        """Get a status  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.get_status(job_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str job_id: Job ID (required)
        :return: StatusJob
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.get_status_with_http_info(job_id, **kwargs)  # noqa: E501
        else:
            (data) = self.get_status_with_http_info(job_id, **kwargs)  # noqa: E501
            return data

    def get_status_with_http_info(self, job_id, **kwargs):  # noqa: E501
        """Get a status  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.get_status_with_http_info(job_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str job_id: Job ID (required)
        :return: StatusJob
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['job_id']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_status" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'job_id' is set
        if ('job_id' not in params or
                params['job_id'] is None):
            raise ValueError("Missing the required parameter `job_id` when calling `get_status`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'job_id' in params:
            path_params['jobId'] = params['job_id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['bearerAuth']  # noqa: E501

        return self.api_client.call_api(
            '/jobs/{jobId}/status', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='StatusJob',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def solve_shift_problem(self, body, **kwargs):  # noqa: E501
        """Solve SHIFT problem  # noqa: E501

        Endpoint for solving shift optimisation problem.   # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.solve_shift_problem(body, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param ShiftRequest body: Payload for all information concerning the shift problem.
This includes:

 - the demand
 - the pool of employees
 - the statutes
 (required)
        :param int seconds: The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides.
        :return: StatusJob
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.solve_shift_problem_with_http_info(body, **kwargs)  # noqa: E501
        else:
            (data) = self.solve_shift_problem_with_http_info(body, **kwargs)  # noqa: E501
            return data

    def solve_shift_problem_with_http_info(self, body, **kwargs):  # noqa: E501
        """Solve SHIFT problem  # noqa: E501

        Endpoint for solving shift optimisation problem.   # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.solve_shift_problem_with_http_info(body, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param ShiftRequest body: Payload for all information concerning the shift problem.
This includes:

 - the demand
 - the pool of employees
 - the statutes
 (required)
        :param int seconds: The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides.
        :return: StatusJob
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['body', 'seconds']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method solve_shift_problem" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'body' is set
        if ('body' not in params or
                params['body'] is None):
            raise ValueError("Missing the required parameter `body` when calling `solve_shift_problem`")  # noqa: E501

        collection_formats = {}

        path_params = {}

        query_params = []
        if 'seconds' in params:
            query_params.append(('seconds', params['seconds']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'body' in params:
            body_params = params['body']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.select_header_content_type(  # noqa: E501
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['bearerAuth']  # noqa: E501

        return self.api_client.call_api(
            '/solve', 'POST',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='StatusJob',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)