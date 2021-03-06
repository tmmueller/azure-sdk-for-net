// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for InvoiceSectionsOperations.
    /// </summary>
    public static partial class InvoiceSectionsOperationsExtensions
    {
            /// <summary>
            /// Lists all invoice sections for a user which he has access to.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            public static InvoiceSectionListResult ListByBillingProfile(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName)
            {
                return operations.ListByBillingProfileAsync(billingAccountName, billingProfileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all invoice sections for a user which he has access to.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InvoiceSectionListResult> ListByBillingProfileAsync(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingProfileWithHttpMessagesAsync(billingAccountName, billingProfileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the InvoiceSection by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            public static InvoiceSection Get(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName)
            {
                return operations.GetAsync(billingAccountName, billingProfileName, invoiceSectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the InvoiceSection by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InvoiceSection> GetAsync(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }
        
            /// <summary>
            /// Elevates the caller's access to match their billing profile access.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            public static void ElevateToBillingProfile(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName)
            {
                operations.ElevateToBillingProfileAsync(billingAccountName, billingProfileName, invoiceSectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Elevates the caller's access to match their billing profile access.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ElevateToBillingProfileAsync(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ElevateToBillingProfileWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }
    }
}
