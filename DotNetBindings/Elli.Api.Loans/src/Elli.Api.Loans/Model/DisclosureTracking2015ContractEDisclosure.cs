/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.4.1
 * 
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
using SwaggerDateConverter = Elli.Api.Loans.Client.SwaggerDateConverter;

namespace Elli.Api.Loans.Model
{
    /// <summary>
    /// DisclosureTracking2015ContractEDisclosure
    /// </summary>
    [DataContract]
    public partial class DisclosureTracking2015ContractEDisclosure :  IEquatable<DisclosureTracking2015ContractEDisclosure>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets ApplicationPackage
        /// </summary>
        [DataMember(Name="applicationPackage", EmitDefaultValue=false)]
        public bool? ApplicationPackage { get; set; }

        /// <summary>
        /// Gets or Sets ApprovalPackage
        /// </summary>
        [DataMember(Name="approvalPackage", EmitDefaultValue=false)]
        public bool? ApprovalPackage { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerAcceptConsentDate
        /// </summary>
        [DataMember(Name="borrowerAcceptConsentDate", EmitDefaultValue=false)]
        public DateTime? BorrowerAcceptConsentDate { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerESignedDate
        /// </summary>
        [DataMember(Name="borrowerESignedDate", EmitDefaultValue=false)]
        public DateTime? BorrowerESignedDate { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerRejectConsentDate
        /// </summary>
        [DataMember(Name="borrowerRejectConsentDate", EmitDefaultValue=false)]
        public DateTime? BorrowerRejectConsentDate { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerViewConsentDate
        /// </summary>
        [DataMember(Name="borrowerViewConsentDate", EmitDefaultValue=false)]
        public DateTime? BorrowerViewConsentDate { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerViewMessageDate
        /// </summary>
        [DataMember(Name="borrowerViewMessageDate", EmitDefaultValue=false)]
        public DateTime? BorrowerViewMessageDate { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerWetSignedDate
        /// </summary>
        [DataMember(Name="borrowerWetSignedDate", EmitDefaultValue=false)]
        public DateTime? BorrowerWetSignedDate { get; set; }

        /// <summary>
        /// Gets or Sets CoborrowerAcceptConsentDate
        /// </summary>
        [DataMember(Name="coborrowerAcceptConsentDate", EmitDefaultValue=false)]
        public DateTime? CoborrowerAcceptConsentDate { get; set; }

        /// <summary>
        /// Gets or Sets CoborrowerESignedDate
        /// </summary>
        [DataMember(Name="coborrowerESignedDate", EmitDefaultValue=false)]
        public DateTime? CoborrowerESignedDate { get; set; }

        /// <summary>
        /// Gets or Sets CoborrowerRejectConsentDate
        /// </summary>
        [DataMember(Name="coborrowerRejectConsentDate", EmitDefaultValue=false)]
        public DateTime? CoborrowerRejectConsentDate { get; set; }

        /// <summary>
        /// Gets or Sets CoborrowerViewConsentDate
        /// </summary>
        [DataMember(Name="coborrowerViewConsentDate", EmitDefaultValue=false)]
        public DateTime? CoborrowerViewConsentDate { get; set; }

        /// <summary>
        /// Gets or Sets CoborrowerViewMessageDate
        /// </summary>
        [DataMember(Name="coborrowerViewMessageDate", EmitDefaultValue=false)]
        public DateTime? CoborrowerViewMessageDate { get; set; }

        /// <summary>
        /// Gets or Sets CoborrowerWebSignedDate
        /// </summary>
        [DataMember(Name="coborrowerWebSignedDate", EmitDefaultValue=false)]
        public DateTime? CoborrowerWebSignedDate { get; set; }

        /// <summary>
        /// Gets or Sets ConsentPdf
        /// </summary>
        [DataMember(Name="consentPdf", EmitDefaultValue=false)]
        public string ConsentPdf { get; set; }

        /// <summary>
        /// Gets or Sets DisclosedMessage
        /// </summary>
        [DataMember(Name="disclosedMessage", EmitDefaultValue=false)]
        public string DisclosedMessage { get; set; }

        /// <summary>
        /// Gets or Sets LockPackage
        /// </summary>
        [DataMember(Name="lockPackage", EmitDefaultValue=false)]
        public bool? LockPackage { get; set; }

        /// <summary>
        /// Gets or Sets ManualFulfillmentComment
        /// </summary>
        [DataMember(Name="manualFulfillmentComment", EmitDefaultValue=false)]
        public string ManualFulfillmentComment { get; set; }

        /// <summary>
        /// Gets or Sets ManualFulfillmentDate
        /// </summary>
        [DataMember(Name="manualFulfillmentDate", EmitDefaultValue=false)]
        public DateTime? ManualFulfillmentDate { get; set; }

        /// <summary>
        /// Gets or Sets ManualFulfillmentMethod
        /// </summary>
        [DataMember(Name="manualFulfillmentMethod", EmitDefaultValue=false)]
        public string ManualFulfillmentMethod { get; set; }

        /// <summary>
        /// Gets or Sets ManuallyFulfilledBy
        /// </summary>
        [DataMember(Name="manuallyFulfilledBy", EmitDefaultValue=false)]
        public string ManuallyFulfilledBy { get; set; }

        /// <summary>
        /// Gets or Sets PackageCreatedDate
        /// </summary>
        [DataMember(Name="packageCreatedDate", EmitDefaultValue=false)]
        public DateTime? PackageCreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets PackageId
        /// </summary>
        [DataMember(Name="packageId", EmitDefaultValue=false)]
        public string PackageId { get; set; }

        /// <summary>
        /// Gets or Sets PackageViewableFile
        /// </summary>
        [DataMember(Name="packageViewableFile", EmitDefaultValue=false)]
        public string PackageViewableFile { get; set; }

        /// <summary>
        /// Gets or Sets ThreeDayPackage
        /// </summary>
        [DataMember(Name="threeDayPackage", EmitDefaultValue=false)]
        public bool? ThreeDayPackage { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerName
        /// </summary>
        [DataMember(Name="borrowerName", EmitDefaultValue=false)]
        public string BorrowerName { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerEmail
        /// </summary>
        [DataMember(Name="borrowerEmail", EmitDefaultValue=false)]
        public string BorrowerEmail { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerAuthenticatedDate
        /// </summary>
        [DataMember(Name="borrowerAuthenticatedDate", EmitDefaultValue=false)]
        public DateTime? BorrowerAuthenticatedDate { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerAuthenticatedIP
        /// </summary>
        [DataMember(Name="borrowerAuthenticatedIP", EmitDefaultValue=false)]
        public string BorrowerAuthenticatedIP { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerAcceptConsentIP
        /// </summary>
        [DataMember(Name="borrowerAcceptConsentIP", EmitDefaultValue=false)]
        public string BorrowerAcceptConsentIP { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerRejectConsentIP
        /// </summary>
        [DataMember(Name="borrowerRejectConsentIP", EmitDefaultValue=false)]
        public string BorrowerRejectConsentIP { get; set; }

        /// <summary>
        /// Gets or Sets BorrowereSignedIP
        /// </summary>
        [DataMember(Name="borrowereSignedIP", EmitDefaultValue=false)]
        public string BorrowereSignedIP { get; set; }

        /// <summary>
        /// Gets or Sets CoborrowerName
        /// </summary>
        [DataMember(Name="coborrowerName", EmitDefaultValue=false)]
        public string CoborrowerName { get; set; }

        /// <summary>
        /// Gets or Sets CoborrowerEmail
        /// </summary>
        [DataMember(Name="coborrowerEmail", EmitDefaultValue=false)]
        public string CoborrowerEmail { get; set; }

        /// <summary>
        /// Gets or Sets CoborrowerAuthenticatedDate
        /// </summary>
        [DataMember(Name="coborrowerAuthenticatedDate", EmitDefaultValue=false)]
        public DateTime? CoborrowerAuthenticatedDate { get; set; }

        /// <summary>
        /// Gets or Sets CoborrowerAuthenticatedIP
        /// </summary>
        [DataMember(Name="coborrowerAuthenticatedIP", EmitDefaultValue=false)]
        public string CoborrowerAuthenticatedIP { get; set; }

        /// <summary>
        /// Gets or Sets CoborrowerAcceptConsentIP
        /// </summary>
        [DataMember(Name="coborrowerAcceptConsentIP", EmitDefaultValue=false)]
        public string CoborrowerAcceptConsentIP { get; set; }

        /// <summary>
        /// Gets or Sets CoborrowerRejectConsentIP
        /// </summary>
        [DataMember(Name="coborrowerRejectConsentIP", EmitDefaultValue=false)]
        public string CoborrowerRejectConsentIP { get; set; }

        /// <summary>
        /// Gets or Sets CoborrowereSignedIP
        /// </summary>
        [DataMember(Name="coborrowereSignedIP", EmitDefaultValue=false)]
        public string CoborrowereSignedIP { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerLoanLevelConsent
        /// </summary>
        [DataMember(Name="borrowerLoanLevelConsent", EmitDefaultValue=false)]
        public string BorrowerLoanLevelConsent { get; set; }

        /// <summary>
        /// Gets or Sets CoborrowerLoanLevelConsent
        /// </summary>
        [DataMember(Name="coborrowerLoanLevelConsent", EmitDefaultValue=false)]
        public string CoborrowerLoanLevelConsent { get; set; }

        /// <summary>
        /// Gets or Sets LoName
        /// </summary>
        [DataMember(Name="loName", EmitDefaultValue=false)]
        public string LoName { get; set; }

        /// <summary>
        /// Gets or Sets LoViewMessageDate
        /// </summary>
        [DataMember(Name="loViewMessageDate", EmitDefaultValue=false)]
        public DateTime? LoViewMessageDate { get; set; }

        /// <summary>
        /// Gets or Sets LoESignedDate
        /// </summary>
        [DataMember(Name="loESignedDate", EmitDefaultValue=false)]
        public DateTime? LoESignedDate { get; set; }

        /// <summary>
        /// Gets or Sets LoESignedIP
        /// </summary>
        [DataMember(Name="loESignedIP", EmitDefaultValue=false)]
        public string LoESignedIP { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerDocumentViewedDate
        /// </summary>
        [DataMember(Name="borrowerDocumentViewedDate", EmitDefaultValue=false)]
        public DateTime? BorrowerDocumentViewedDate { get; set; }

        /// <summary>
        /// Gets or Sets CoborrowerDocumentViewedDate
        /// </summary>
        [DataMember(Name="coborrowerDocumentViewedDate", EmitDefaultValue=false)]
        public DateTime? CoborrowerDocumentViewedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisclosureTracking2015ContractEDisclosure {\n");
            sb.Append("  ApplicationPackage: ").Append(ApplicationPackage).Append("\n");
            sb.Append("  ApprovalPackage: ").Append(ApprovalPackage).Append("\n");
            sb.Append("  BorrowerAcceptConsentDate: ").Append(BorrowerAcceptConsentDate).Append("\n");
            sb.Append("  BorrowerESignedDate: ").Append(BorrowerESignedDate).Append("\n");
            sb.Append("  BorrowerRejectConsentDate: ").Append(BorrowerRejectConsentDate).Append("\n");
            sb.Append("  BorrowerViewConsentDate: ").Append(BorrowerViewConsentDate).Append("\n");
            sb.Append("  BorrowerViewMessageDate: ").Append(BorrowerViewMessageDate).Append("\n");
            sb.Append("  BorrowerWetSignedDate: ").Append(BorrowerWetSignedDate).Append("\n");
            sb.Append("  CoborrowerAcceptConsentDate: ").Append(CoborrowerAcceptConsentDate).Append("\n");
            sb.Append("  CoborrowerESignedDate: ").Append(CoborrowerESignedDate).Append("\n");
            sb.Append("  CoborrowerRejectConsentDate: ").Append(CoborrowerRejectConsentDate).Append("\n");
            sb.Append("  CoborrowerViewConsentDate: ").Append(CoborrowerViewConsentDate).Append("\n");
            sb.Append("  CoborrowerViewMessageDate: ").Append(CoborrowerViewMessageDate).Append("\n");
            sb.Append("  CoborrowerWebSignedDate: ").Append(CoborrowerWebSignedDate).Append("\n");
            sb.Append("  ConsentPdf: ").Append(ConsentPdf).Append("\n");
            sb.Append("  DisclosedMessage: ").Append(DisclosedMessage).Append("\n");
            sb.Append("  LockPackage: ").Append(LockPackage).Append("\n");
            sb.Append("  ManualFulfillmentComment: ").Append(ManualFulfillmentComment).Append("\n");
            sb.Append("  ManualFulfillmentDate: ").Append(ManualFulfillmentDate).Append("\n");
            sb.Append("  ManualFulfillmentMethod: ").Append(ManualFulfillmentMethod).Append("\n");
            sb.Append("  ManuallyFulfilledBy: ").Append(ManuallyFulfilledBy).Append("\n");
            sb.Append("  PackageCreatedDate: ").Append(PackageCreatedDate).Append("\n");
            sb.Append("  PackageId: ").Append(PackageId).Append("\n");
            sb.Append("  PackageViewableFile: ").Append(PackageViewableFile).Append("\n");
            sb.Append("  ThreeDayPackage: ").Append(ThreeDayPackage).Append("\n");
            sb.Append("  BorrowerName: ").Append(BorrowerName).Append("\n");
            sb.Append("  BorrowerEmail: ").Append(BorrowerEmail).Append("\n");
            sb.Append("  BorrowerAuthenticatedDate: ").Append(BorrowerAuthenticatedDate).Append("\n");
            sb.Append("  BorrowerAuthenticatedIP: ").Append(BorrowerAuthenticatedIP).Append("\n");
            sb.Append("  BorrowerAcceptConsentIP: ").Append(BorrowerAcceptConsentIP).Append("\n");
            sb.Append("  BorrowerRejectConsentIP: ").Append(BorrowerRejectConsentIP).Append("\n");
            sb.Append("  BorrowereSignedIP: ").Append(BorrowereSignedIP).Append("\n");
            sb.Append("  CoborrowerName: ").Append(CoborrowerName).Append("\n");
            sb.Append("  CoborrowerEmail: ").Append(CoborrowerEmail).Append("\n");
            sb.Append("  CoborrowerAuthenticatedDate: ").Append(CoborrowerAuthenticatedDate).Append("\n");
            sb.Append("  CoborrowerAuthenticatedIP: ").Append(CoborrowerAuthenticatedIP).Append("\n");
            sb.Append("  CoborrowerAcceptConsentIP: ").Append(CoborrowerAcceptConsentIP).Append("\n");
            sb.Append("  CoborrowerRejectConsentIP: ").Append(CoborrowerRejectConsentIP).Append("\n");
            sb.Append("  CoborrowereSignedIP: ").Append(CoborrowereSignedIP).Append("\n");
            sb.Append("  BorrowerLoanLevelConsent: ").Append(BorrowerLoanLevelConsent).Append("\n");
            sb.Append("  CoborrowerLoanLevelConsent: ").Append(CoborrowerLoanLevelConsent).Append("\n");
            sb.Append("  LoName: ").Append(LoName).Append("\n");
            sb.Append("  LoViewMessageDate: ").Append(LoViewMessageDate).Append("\n");
            sb.Append("  LoESignedDate: ").Append(LoESignedDate).Append("\n");
            sb.Append("  LoESignedIP: ").Append(LoESignedIP).Append("\n");
            sb.Append("  BorrowerDocumentViewedDate: ").Append(BorrowerDocumentViewedDate).Append("\n");
            sb.Append("  CoborrowerDocumentViewedDate: ").Append(CoborrowerDocumentViewedDate).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisclosureTracking2015ContractEDisclosure);
        }

        /// <summary>
        /// Returns true if DisclosureTracking2015ContractEDisclosure instances are equal
        /// </summary>
        /// <param name="input">Instance of DisclosureTracking2015ContractEDisclosure to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisclosureTracking2015ContractEDisclosure input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationPackage == input.ApplicationPackage ||
                    (this.ApplicationPackage != null &&
                    this.ApplicationPackage.Equals(input.ApplicationPackage))
                ) && 
                (
                    this.ApprovalPackage == input.ApprovalPackage ||
                    (this.ApprovalPackage != null &&
                    this.ApprovalPackage.Equals(input.ApprovalPackage))
                ) && 
                (
                    this.BorrowerAcceptConsentDate == input.BorrowerAcceptConsentDate ||
                    (this.BorrowerAcceptConsentDate != null &&
                    this.BorrowerAcceptConsentDate.Equals(input.BorrowerAcceptConsentDate))
                ) && 
                (
                    this.BorrowerESignedDate == input.BorrowerESignedDate ||
                    (this.BorrowerESignedDate != null &&
                    this.BorrowerESignedDate.Equals(input.BorrowerESignedDate))
                ) && 
                (
                    this.BorrowerRejectConsentDate == input.BorrowerRejectConsentDate ||
                    (this.BorrowerRejectConsentDate != null &&
                    this.BorrowerRejectConsentDate.Equals(input.BorrowerRejectConsentDate))
                ) && 
                (
                    this.BorrowerViewConsentDate == input.BorrowerViewConsentDate ||
                    (this.BorrowerViewConsentDate != null &&
                    this.BorrowerViewConsentDate.Equals(input.BorrowerViewConsentDate))
                ) && 
                (
                    this.BorrowerViewMessageDate == input.BorrowerViewMessageDate ||
                    (this.BorrowerViewMessageDate != null &&
                    this.BorrowerViewMessageDate.Equals(input.BorrowerViewMessageDate))
                ) && 
                (
                    this.BorrowerWetSignedDate == input.BorrowerWetSignedDate ||
                    (this.BorrowerWetSignedDate != null &&
                    this.BorrowerWetSignedDate.Equals(input.BorrowerWetSignedDate))
                ) && 
                (
                    this.CoborrowerAcceptConsentDate == input.CoborrowerAcceptConsentDate ||
                    (this.CoborrowerAcceptConsentDate != null &&
                    this.CoborrowerAcceptConsentDate.Equals(input.CoborrowerAcceptConsentDate))
                ) && 
                (
                    this.CoborrowerESignedDate == input.CoborrowerESignedDate ||
                    (this.CoborrowerESignedDate != null &&
                    this.CoborrowerESignedDate.Equals(input.CoborrowerESignedDate))
                ) && 
                (
                    this.CoborrowerRejectConsentDate == input.CoborrowerRejectConsentDate ||
                    (this.CoborrowerRejectConsentDate != null &&
                    this.CoborrowerRejectConsentDate.Equals(input.CoborrowerRejectConsentDate))
                ) && 
                (
                    this.CoborrowerViewConsentDate == input.CoborrowerViewConsentDate ||
                    (this.CoborrowerViewConsentDate != null &&
                    this.CoborrowerViewConsentDate.Equals(input.CoborrowerViewConsentDate))
                ) && 
                (
                    this.CoborrowerViewMessageDate == input.CoborrowerViewMessageDate ||
                    (this.CoborrowerViewMessageDate != null &&
                    this.CoborrowerViewMessageDate.Equals(input.CoborrowerViewMessageDate))
                ) && 
                (
                    this.CoborrowerWebSignedDate == input.CoborrowerWebSignedDate ||
                    (this.CoborrowerWebSignedDate != null &&
                    this.CoborrowerWebSignedDate.Equals(input.CoborrowerWebSignedDate))
                ) && 
                (
                    this.ConsentPdf == input.ConsentPdf ||
                    (this.ConsentPdf != null &&
                    this.ConsentPdf.Equals(input.ConsentPdf))
                ) && 
                (
                    this.DisclosedMessage == input.DisclosedMessage ||
                    (this.DisclosedMessage != null &&
                    this.DisclosedMessage.Equals(input.DisclosedMessage))
                ) && 
                (
                    this.LockPackage == input.LockPackage ||
                    (this.LockPackage != null &&
                    this.LockPackage.Equals(input.LockPackage))
                ) && 
                (
                    this.ManualFulfillmentComment == input.ManualFulfillmentComment ||
                    (this.ManualFulfillmentComment != null &&
                    this.ManualFulfillmentComment.Equals(input.ManualFulfillmentComment))
                ) && 
                (
                    this.ManualFulfillmentDate == input.ManualFulfillmentDate ||
                    (this.ManualFulfillmentDate != null &&
                    this.ManualFulfillmentDate.Equals(input.ManualFulfillmentDate))
                ) && 
                (
                    this.ManualFulfillmentMethod == input.ManualFulfillmentMethod ||
                    (this.ManualFulfillmentMethod != null &&
                    this.ManualFulfillmentMethod.Equals(input.ManualFulfillmentMethod))
                ) && 
                (
                    this.ManuallyFulfilledBy == input.ManuallyFulfilledBy ||
                    (this.ManuallyFulfilledBy != null &&
                    this.ManuallyFulfilledBy.Equals(input.ManuallyFulfilledBy))
                ) && 
                (
                    this.PackageCreatedDate == input.PackageCreatedDate ||
                    (this.PackageCreatedDate != null &&
                    this.PackageCreatedDate.Equals(input.PackageCreatedDate))
                ) && 
                (
                    this.PackageId == input.PackageId ||
                    (this.PackageId != null &&
                    this.PackageId.Equals(input.PackageId))
                ) && 
                (
                    this.PackageViewableFile == input.PackageViewableFile ||
                    (this.PackageViewableFile != null &&
                    this.PackageViewableFile.Equals(input.PackageViewableFile))
                ) && 
                (
                    this.ThreeDayPackage == input.ThreeDayPackage ||
                    (this.ThreeDayPackage != null &&
                    this.ThreeDayPackage.Equals(input.ThreeDayPackage))
                ) && 
                (
                    this.BorrowerName == input.BorrowerName ||
                    (this.BorrowerName != null &&
                    this.BorrowerName.Equals(input.BorrowerName))
                ) && 
                (
                    this.BorrowerEmail == input.BorrowerEmail ||
                    (this.BorrowerEmail != null &&
                    this.BorrowerEmail.Equals(input.BorrowerEmail))
                ) && 
                (
                    this.BorrowerAuthenticatedDate == input.BorrowerAuthenticatedDate ||
                    (this.BorrowerAuthenticatedDate != null &&
                    this.BorrowerAuthenticatedDate.Equals(input.BorrowerAuthenticatedDate))
                ) && 
                (
                    this.BorrowerAuthenticatedIP == input.BorrowerAuthenticatedIP ||
                    (this.BorrowerAuthenticatedIP != null &&
                    this.BorrowerAuthenticatedIP.Equals(input.BorrowerAuthenticatedIP))
                ) && 
                (
                    this.BorrowerAcceptConsentIP == input.BorrowerAcceptConsentIP ||
                    (this.BorrowerAcceptConsentIP != null &&
                    this.BorrowerAcceptConsentIP.Equals(input.BorrowerAcceptConsentIP))
                ) && 
                (
                    this.BorrowerRejectConsentIP == input.BorrowerRejectConsentIP ||
                    (this.BorrowerRejectConsentIP != null &&
                    this.BorrowerRejectConsentIP.Equals(input.BorrowerRejectConsentIP))
                ) && 
                (
                    this.BorrowereSignedIP == input.BorrowereSignedIP ||
                    (this.BorrowereSignedIP != null &&
                    this.BorrowereSignedIP.Equals(input.BorrowereSignedIP))
                ) && 
                (
                    this.CoborrowerName == input.CoborrowerName ||
                    (this.CoborrowerName != null &&
                    this.CoborrowerName.Equals(input.CoborrowerName))
                ) && 
                (
                    this.CoborrowerEmail == input.CoborrowerEmail ||
                    (this.CoborrowerEmail != null &&
                    this.CoborrowerEmail.Equals(input.CoborrowerEmail))
                ) && 
                (
                    this.CoborrowerAuthenticatedDate == input.CoborrowerAuthenticatedDate ||
                    (this.CoborrowerAuthenticatedDate != null &&
                    this.CoborrowerAuthenticatedDate.Equals(input.CoborrowerAuthenticatedDate))
                ) && 
                (
                    this.CoborrowerAuthenticatedIP == input.CoborrowerAuthenticatedIP ||
                    (this.CoborrowerAuthenticatedIP != null &&
                    this.CoborrowerAuthenticatedIP.Equals(input.CoborrowerAuthenticatedIP))
                ) && 
                (
                    this.CoborrowerAcceptConsentIP == input.CoborrowerAcceptConsentIP ||
                    (this.CoborrowerAcceptConsentIP != null &&
                    this.CoborrowerAcceptConsentIP.Equals(input.CoborrowerAcceptConsentIP))
                ) && 
                (
                    this.CoborrowerRejectConsentIP == input.CoborrowerRejectConsentIP ||
                    (this.CoborrowerRejectConsentIP != null &&
                    this.CoborrowerRejectConsentIP.Equals(input.CoborrowerRejectConsentIP))
                ) && 
                (
                    this.CoborrowereSignedIP == input.CoborrowereSignedIP ||
                    (this.CoborrowereSignedIP != null &&
                    this.CoborrowereSignedIP.Equals(input.CoborrowereSignedIP))
                ) && 
                (
                    this.BorrowerLoanLevelConsent == input.BorrowerLoanLevelConsent ||
                    (this.BorrowerLoanLevelConsent != null &&
                    this.BorrowerLoanLevelConsent.Equals(input.BorrowerLoanLevelConsent))
                ) && 
                (
                    this.CoborrowerLoanLevelConsent == input.CoborrowerLoanLevelConsent ||
                    (this.CoborrowerLoanLevelConsent != null &&
                    this.CoborrowerLoanLevelConsent.Equals(input.CoborrowerLoanLevelConsent))
                ) && 
                (
                    this.LoName == input.LoName ||
                    (this.LoName != null &&
                    this.LoName.Equals(input.LoName))
                ) && 
                (
                    this.LoViewMessageDate == input.LoViewMessageDate ||
                    (this.LoViewMessageDate != null &&
                    this.LoViewMessageDate.Equals(input.LoViewMessageDate))
                ) && 
                (
                    this.LoESignedDate == input.LoESignedDate ||
                    (this.LoESignedDate != null &&
                    this.LoESignedDate.Equals(input.LoESignedDate))
                ) && 
                (
                    this.LoESignedIP == input.LoESignedIP ||
                    (this.LoESignedIP != null &&
                    this.LoESignedIP.Equals(input.LoESignedIP))
                ) && 
                (
                    this.BorrowerDocumentViewedDate == input.BorrowerDocumentViewedDate ||
                    (this.BorrowerDocumentViewedDate != null &&
                    this.BorrowerDocumentViewedDate.Equals(input.BorrowerDocumentViewedDate))
                ) && 
                (
                    this.CoborrowerDocumentViewedDate == input.CoborrowerDocumentViewedDate ||
                    (this.CoborrowerDocumentViewedDate != null &&
                    this.CoborrowerDocumentViewedDate.Equals(input.CoborrowerDocumentViewedDate))
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
                if (this.ApplicationPackage != null)
                    hashCode = hashCode * 59 + this.ApplicationPackage.GetHashCode();
                if (this.ApprovalPackage != null)
                    hashCode = hashCode * 59 + this.ApprovalPackage.GetHashCode();
                if (this.BorrowerAcceptConsentDate != null)
                    hashCode = hashCode * 59 + this.BorrowerAcceptConsentDate.GetHashCode();
                if (this.BorrowerESignedDate != null)
                    hashCode = hashCode * 59 + this.BorrowerESignedDate.GetHashCode();
                if (this.BorrowerRejectConsentDate != null)
                    hashCode = hashCode * 59 + this.BorrowerRejectConsentDate.GetHashCode();
                if (this.BorrowerViewConsentDate != null)
                    hashCode = hashCode * 59 + this.BorrowerViewConsentDate.GetHashCode();
                if (this.BorrowerViewMessageDate != null)
                    hashCode = hashCode * 59 + this.BorrowerViewMessageDate.GetHashCode();
                if (this.BorrowerWetSignedDate != null)
                    hashCode = hashCode * 59 + this.BorrowerWetSignedDate.GetHashCode();
                if (this.CoborrowerAcceptConsentDate != null)
                    hashCode = hashCode * 59 + this.CoborrowerAcceptConsentDate.GetHashCode();
                if (this.CoborrowerESignedDate != null)
                    hashCode = hashCode * 59 + this.CoborrowerESignedDate.GetHashCode();
                if (this.CoborrowerRejectConsentDate != null)
                    hashCode = hashCode * 59 + this.CoborrowerRejectConsentDate.GetHashCode();
                if (this.CoborrowerViewConsentDate != null)
                    hashCode = hashCode * 59 + this.CoborrowerViewConsentDate.GetHashCode();
                if (this.CoborrowerViewMessageDate != null)
                    hashCode = hashCode * 59 + this.CoborrowerViewMessageDate.GetHashCode();
                if (this.CoborrowerWebSignedDate != null)
                    hashCode = hashCode * 59 + this.CoborrowerWebSignedDate.GetHashCode();
                if (this.ConsentPdf != null)
                    hashCode = hashCode * 59 + this.ConsentPdf.GetHashCode();
                if (this.DisclosedMessage != null)
                    hashCode = hashCode * 59 + this.DisclosedMessage.GetHashCode();
                if (this.LockPackage != null)
                    hashCode = hashCode * 59 + this.LockPackage.GetHashCode();
                if (this.ManualFulfillmentComment != null)
                    hashCode = hashCode * 59 + this.ManualFulfillmentComment.GetHashCode();
                if (this.ManualFulfillmentDate != null)
                    hashCode = hashCode * 59 + this.ManualFulfillmentDate.GetHashCode();
                if (this.ManualFulfillmentMethod != null)
                    hashCode = hashCode * 59 + this.ManualFulfillmentMethod.GetHashCode();
                if (this.ManuallyFulfilledBy != null)
                    hashCode = hashCode * 59 + this.ManuallyFulfilledBy.GetHashCode();
                if (this.PackageCreatedDate != null)
                    hashCode = hashCode * 59 + this.PackageCreatedDate.GetHashCode();
                if (this.PackageId != null)
                    hashCode = hashCode * 59 + this.PackageId.GetHashCode();
                if (this.PackageViewableFile != null)
                    hashCode = hashCode * 59 + this.PackageViewableFile.GetHashCode();
                if (this.ThreeDayPackage != null)
                    hashCode = hashCode * 59 + this.ThreeDayPackage.GetHashCode();
                if (this.BorrowerName != null)
                    hashCode = hashCode * 59 + this.BorrowerName.GetHashCode();
                if (this.BorrowerEmail != null)
                    hashCode = hashCode * 59 + this.BorrowerEmail.GetHashCode();
                if (this.BorrowerAuthenticatedDate != null)
                    hashCode = hashCode * 59 + this.BorrowerAuthenticatedDate.GetHashCode();
                if (this.BorrowerAuthenticatedIP != null)
                    hashCode = hashCode * 59 + this.BorrowerAuthenticatedIP.GetHashCode();
                if (this.BorrowerAcceptConsentIP != null)
                    hashCode = hashCode * 59 + this.BorrowerAcceptConsentIP.GetHashCode();
                if (this.BorrowerRejectConsentIP != null)
                    hashCode = hashCode * 59 + this.BorrowerRejectConsentIP.GetHashCode();
                if (this.BorrowereSignedIP != null)
                    hashCode = hashCode * 59 + this.BorrowereSignedIP.GetHashCode();
                if (this.CoborrowerName != null)
                    hashCode = hashCode * 59 + this.CoborrowerName.GetHashCode();
                if (this.CoborrowerEmail != null)
                    hashCode = hashCode * 59 + this.CoborrowerEmail.GetHashCode();
                if (this.CoborrowerAuthenticatedDate != null)
                    hashCode = hashCode * 59 + this.CoborrowerAuthenticatedDate.GetHashCode();
                if (this.CoborrowerAuthenticatedIP != null)
                    hashCode = hashCode * 59 + this.CoborrowerAuthenticatedIP.GetHashCode();
                if (this.CoborrowerAcceptConsentIP != null)
                    hashCode = hashCode * 59 + this.CoborrowerAcceptConsentIP.GetHashCode();
                if (this.CoborrowerRejectConsentIP != null)
                    hashCode = hashCode * 59 + this.CoborrowerRejectConsentIP.GetHashCode();
                if (this.CoborrowereSignedIP != null)
                    hashCode = hashCode * 59 + this.CoborrowereSignedIP.GetHashCode();
                if (this.BorrowerLoanLevelConsent != null)
                    hashCode = hashCode * 59 + this.BorrowerLoanLevelConsent.GetHashCode();
                if (this.CoborrowerLoanLevelConsent != null)
                    hashCode = hashCode * 59 + this.CoborrowerLoanLevelConsent.GetHashCode();
                if (this.LoName != null)
                    hashCode = hashCode * 59 + this.LoName.GetHashCode();
                if (this.LoViewMessageDate != null)
                    hashCode = hashCode * 59 + this.LoViewMessageDate.GetHashCode();
                if (this.LoESignedDate != null)
                    hashCode = hashCode * 59 + this.LoESignedDate.GetHashCode();
                if (this.LoESignedIP != null)
                    hashCode = hashCode * 59 + this.LoESignedIP.GetHashCode();
                if (this.BorrowerDocumentViewedDate != null)
                    hashCode = hashCode * 59 + this.BorrowerDocumentViewedDate.GetHashCode();
                if (this.CoborrowerDocumentViewedDate != null)
                    hashCode = hashCode * 59 + this.CoborrowerDocumentViewedDate.GetHashCode();
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
