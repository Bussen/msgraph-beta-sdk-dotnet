// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type BusinessFlowTemplateRequest.
    /// </summary>
    public partial class BusinessFlowTemplateRequest : BaseRequest, IBusinessFlowTemplateRequest
    {
        /// <summary>
        /// Constructs a new BusinessFlowTemplateRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public BusinessFlowTemplateRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified BusinessFlowTemplate using POST.
        /// </summary>
        /// <param name="businessFlowTemplateToCreate">The BusinessFlowTemplate to create.</param>
        /// <returns>The created BusinessFlowTemplate.</returns>
        public System.Threading.Tasks.Task<BusinessFlowTemplate> CreateAsync(BusinessFlowTemplate businessFlowTemplateToCreate)
        {
            return this.CreateAsync(businessFlowTemplateToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified BusinessFlowTemplate using POST.
        /// </summary>
        /// <param name="businessFlowTemplateToCreate">The BusinessFlowTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BusinessFlowTemplate.</returns>
        public async System.Threading.Tasks.Task<BusinessFlowTemplate> CreateAsync(BusinessFlowTemplate businessFlowTemplateToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<BusinessFlowTemplate>(businessFlowTemplateToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified BusinessFlowTemplate.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified BusinessFlowTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<BusinessFlowTemplate>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified BusinessFlowTemplate.
        /// </summary>
        /// <returns>The BusinessFlowTemplate.</returns>
        public System.Threading.Tasks.Task<BusinessFlowTemplate> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified BusinessFlowTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BusinessFlowTemplate.</returns>
        public async System.Threading.Tasks.Task<BusinessFlowTemplate> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<BusinessFlowTemplate>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified BusinessFlowTemplate using PATCH.
        /// </summary>
        /// <param name="businessFlowTemplateToUpdate">The BusinessFlowTemplate to update.</param>
        /// <returns>The updated BusinessFlowTemplate.</returns>
        public System.Threading.Tasks.Task<BusinessFlowTemplate> UpdateAsync(BusinessFlowTemplate businessFlowTemplateToUpdate)
        {
            return this.UpdateAsync(businessFlowTemplateToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified BusinessFlowTemplate using PATCH.
        /// </summary>
        /// <param name="businessFlowTemplateToUpdate">The BusinessFlowTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated BusinessFlowTemplate.</returns>
        public async System.Threading.Tasks.Task<BusinessFlowTemplate> UpdateAsync(BusinessFlowTemplate businessFlowTemplateToUpdate, CancellationToken cancellationToken)
        {
			if (businessFlowTemplateToUpdate.AdditionalData != null)
			{
				if (businessFlowTemplateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					businessFlowTemplateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, businessFlowTemplateToUpdate.GetType().Name)
						});
				}
			}
            if (businessFlowTemplateToUpdate.AdditionalData != null)
            {
                if (businessFlowTemplateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    businessFlowTemplateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, businessFlowTemplateToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<BusinessFlowTemplate>(businessFlowTemplateToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IBusinessFlowTemplateRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IBusinessFlowTemplateRequest Expand(Expression<Func<BusinessFlowTemplate, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IBusinessFlowTemplateRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IBusinessFlowTemplateRequest Select(Expression<Func<BusinessFlowTemplate, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="businessFlowTemplateToInitialize">The <see cref="BusinessFlowTemplate"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(BusinessFlowTemplate businessFlowTemplateToInitialize)
        {

        }
    }
}
