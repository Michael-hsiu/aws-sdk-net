/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AWSMarketplaceMetering.Model;

namespace Amazon.AWSMarketplaceMetering
{
    /// <summary>
    /// Interface for accessing AWSMarketplaceMetering
    ///
    /// AWS Marketplace Metering Service 
    /// <para>
    /// This reference provides descriptions of the low-level AWS Marketplace Metering Service
    /// API.
    /// </para>
    ///  
    /// <para>
    /// AWS Marketplace sellers can use this API to submit usage data for custom usage dimensions.
    /// </para>
    ///  
    /// <para>
    ///  <b>Submitting Metering Records</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>MeterUsage</i>- Submits the metering record for a Marketplace product. MeterUsage
    /// is called from an EC2 instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>BatchMeterUsage</i>- Submits the metering record for a set of customers. BatchMeterUsage
    /// is called from a software-as-a-service (SaaS) application.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Accepting New Customers</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>ResolveCustomer</i>- Called by a SaaS application during the registration process.
    /// When a buyer visits your website during the registration process, the buyer submits
    /// a Registration Token through the browser. The Registration Token is resolved through
    /// this API to obtain a CustomerIdentifier and Product Code.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonAWSMarketplaceMetering : IAmazonService, IDisposable
    {

        
        #region  BatchMeterUsage


        /// <summary>
        /// BatchMeterUsage is called from a SaaS application listed on the AWS Marketplace to
        /// post metering records for a set of customers.
        /// 
        ///  
        /// <para>
        /// For identical requests, the API is idempotent; requests can be retried with the same
        /// records or a subset of the input records.
        /// </para>
        ///  
        /// <para>
        /// Every request to BatchMeterUsage is for one product. If you need to meter usage for
        /// multiple products, you must make multiple calls to BatchMeterUsage.
        /// </para>
        ///  
        /// <para>
        /// BatchMeterUsage can process up to 25 UsageRecords at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchMeterUsage service method.</param>
        /// 
        /// <returns>The response from the BatchMeterUsage service method, as returned by AWSMarketplaceMetering.</returns>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InternalServiceErrorException">
        /// An internal error has occurred. Retry your request. If the problem persists, post
        /// a message with details on the AWS forums.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidCustomerIdentifierException">
        /// You have metered usage for a CustomerIdentifier that does not exist.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidProductCodeException">
        /// The product code passed does not match the product code used for publishing the product.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidUsageDimensionException">
        /// The usage dimension does not match one of the UsageDimensions associated with products.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ThrottlingException">
        /// The calls to the MeterUsage API are throttled.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.TimestampOutOfBoundsException">
        /// The timestamp value passed in the meterUsage() is out of allowed range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/BatchMeterUsage">REST API Reference for BatchMeterUsage Operation</seealso>
        BatchMeterUsageResponse BatchMeterUsage(BatchMeterUsageRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the BatchMeterUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchMeterUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/BatchMeterUsage">REST API Reference for BatchMeterUsage Operation</seealso>
        Task<BatchMeterUsageResponse> BatchMeterUsageAsync(BatchMeterUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  MeterUsage


        /// <summary>
        /// API to emit metering records. For identical requests, the API is idempotent. It simply
        /// returns the metering record ID.
        /// 
        ///  
        /// <para>
        /// MeterUsage is authenticated on the buyer's AWS account, generally when running from
        /// an EC2 instance on the AWS Marketplace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MeterUsage service method.</param>
        /// 
        /// <returns>The response from the MeterUsage service method, as returned by AWSMarketplaceMetering.</returns>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.DuplicateRequestException">
        /// A metering record has already been emitted by the same EC2 instance for the given
        /// {usageDimension, timestamp} with a different usageQuantity.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InternalServiceErrorException">
        /// An internal error has occurred. Retry your request. If the problem persists, post
        /// a message with details on the AWS forums.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidEndpointRegionException">
        /// The endpoint being called is in a region different from your EC2 instance. The region
        /// of the Metering service endpoint and the region of the EC2 instance must match.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidProductCodeException">
        /// The product code passed does not match the product code used for publishing the product.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidUsageDimensionException">
        /// The usage dimension does not match one of the UsageDimensions associated with products.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ThrottlingException">
        /// The calls to the MeterUsage API are throttled.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.TimestampOutOfBoundsException">
        /// The timestamp value passed in the meterUsage() is out of allowed range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/MeterUsage">REST API Reference for MeterUsage Operation</seealso>
        MeterUsageResponse MeterUsage(MeterUsageRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the MeterUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MeterUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/MeterUsage">REST API Reference for MeterUsage Operation</seealso>
        Task<MeterUsageResponse> MeterUsageAsync(MeterUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResolveCustomer


        /// <summary>
        /// ResolveCustomer is called by a SaaS application during the registration process. When
        /// a buyer visits your website during the registration process, the buyer submits a registration
        /// token through their browser. The registration token is resolved through this API to
        /// obtain a CustomerIdentifier and product code.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveCustomer service method.</param>
        /// 
        /// <returns>The response from the ResolveCustomer service method, as returned by AWSMarketplaceMetering.</returns>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ExpiredTokenException">
        /// The submitted registration token has expired. This can happen if the buyer's browser
        /// takes too long to redirect to your page, the buyer has resubmitted the registration
        /// token, or your application has held on to the registration token for too long. Your
        /// SaaS registration website should redeem this token as soon as it is submitted by the
        /// buyer's browser.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InternalServiceErrorException">
        /// An internal error has occurred. Retry your request. If the problem persists, post
        /// a message with details on the AWS forums.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ThrottlingException">
        /// The calls to the MeterUsage API are throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/ResolveCustomer">REST API Reference for ResolveCustomer Operation</seealso>
        ResolveCustomerResponse ResolveCustomer(ResolveCustomerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ResolveCustomer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveCustomer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/ResolveCustomer">REST API Reference for ResolveCustomer Operation</seealso>
        Task<ResolveCustomerResponse> ResolveCustomerAsync(ResolveCustomerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}