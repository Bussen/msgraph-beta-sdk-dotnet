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
    /// The type GroupPolicyUploadedDefinitionFileRequest.
    /// </summary>
    public partial class GroupPolicyUploadedDefinitionFileRequest : BaseRequest, IGroupPolicyUploadedDefinitionFileRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyUploadedDefinitionFileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyUploadedDefinitionFileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GroupPolicyUploadedDefinitionFile using POST.
        /// </summary>
        /// <param name="groupPolicyUploadedDefinitionFileToCreate">The GroupPolicyUploadedDefinitionFile to create.</param>
        /// <returns>The created GroupPolicyUploadedDefinitionFile.</returns>
        public System.Threading.Tasks.Task<GroupPolicyUploadedDefinitionFile> CreateAsync(GroupPolicyUploadedDefinitionFile groupPolicyUploadedDefinitionFileToCreate)
        {
            return this.CreateAsync(groupPolicyUploadedDefinitionFileToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified GroupPolicyUploadedDefinitionFile using POST.
        /// </summary>
        /// <param name="groupPolicyUploadedDefinitionFileToCreate">The GroupPolicyUploadedDefinitionFile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyUploadedDefinitionFile.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyUploadedDefinitionFile> CreateAsync(GroupPolicyUploadedDefinitionFile groupPolicyUploadedDefinitionFileToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<GroupPolicyUploadedDefinitionFile>(groupPolicyUploadedDefinitionFileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified GroupPolicyUploadedDefinitionFile.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyUploadedDefinitionFile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<GroupPolicyUploadedDefinitionFile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified GroupPolicyUploadedDefinitionFile.
        /// </summary>
        /// <returns>The GroupPolicyUploadedDefinitionFile.</returns>
        public System.Threading.Tasks.Task<GroupPolicyUploadedDefinitionFile> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified GroupPolicyUploadedDefinitionFile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyUploadedDefinitionFile.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyUploadedDefinitionFile> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<GroupPolicyUploadedDefinitionFile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyUploadedDefinitionFile using PATCH.
        /// </summary>
        /// <param name="groupPolicyUploadedDefinitionFileToUpdate">The GroupPolicyUploadedDefinitionFile to update.</param>
        /// <returns>The updated GroupPolicyUploadedDefinitionFile.</returns>
        public System.Threading.Tasks.Task<GroupPolicyUploadedDefinitionFile> UpdateAsync(GroupPolicyUploadedDefinitionFile groupPolicyUploadedDefinitionFileToUpdate)
        {
            return this.UpdateAsync(groupPolicyUploadedDefinitionFileToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified GroupPolicyUploadedDefinitionFile using PATCH.
        /// </summary>
        /// <param name="groupPolicyUploadedDefinitionFileToUpdate">The GroupPolicyUploadedDefinitionFile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyUploadedDefinitionFile.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyUploadedDefinitionFile> UpdateAsync(GroupPolicyUploadedDefinitionFile groupPolicyUploadedDefinitionFileToUpdate, CancellationToken cancellationToken)
        {
			if (groupPolicyUploadedDefinitionFileToUpdate.AdditionalData != null)
			{
				if (groupPolicyUploadedDefinitionFileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					groupPolicyUploadedDefinitionFileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, groupPolicyUploadedDefinitionFileToUpdate.GetType().Name)
						});
				}
			}
            if (groupPolicyUploadedDefinitionFileToUpdate.AdditionalData != null)
            {
                if (groupPolicyUploadedDefinitionFileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    groupPolicyUploadedDefinitionFileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, groupPolicyUploadedDefinitionFileToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<GroupPolicyUploadedDefinitionFile>(groupPolicyUploadedDefinitionFileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyUploadedDefinitionFileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyUploadedDefinitionFileRequest Expand(Expression<Func<GroupPolicyUploadedDefinitionFile, object>> expandExpression)
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
        public IGroupPolicyUploadedDefinitionFileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyUploadedDefinitionFileRequest Select(Expression<Func<GroupPolicyUploadedDefinitionFile, object>> selectExpression)
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
        /// <param name="groupPolicyUploadedDefinitionFileToInitialize">The <see cref="GroupPolicyUploadedDefinitionFile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GroupPolicyUploadedDefinitionFile groupPolicyUploadedDefinitionFileToInitialize)
        {

            if (groupPolicyUploadedDefinitionFileToInitialize != null && groupPolicyUploadedDefinitionFileToInitialize.AdditionalData != null)
            {

                if (groupPolicyUploadedDefinitionFileToInitialize.GroupPolicyOperations != null && groupPolicyUploadedDefinitionFileToInitialize.GroupPolicyOperations.CurrentPage != null)
                {
                    groupPolicyUploadedDefinitionFileToInitialize.GroupPolicyOperations.AdditionalData = groupPolicyUploadedDefinitionFileToInitialize.AdditionalData;

                    object nextPageLink;
                    groupPolicyUploadedDefinitionFileToInitialize.AdditionalData.TryGetValue("groupPolicyOperations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupPolicyUploadedDefinitionFileToInitialize.GroupPolicyOperations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
