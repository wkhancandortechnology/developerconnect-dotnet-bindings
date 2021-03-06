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
 * Tools
 *
 * Represents calculations applied on a loan
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
using SwaggerDateConverter = Elli.Api.Tools.Client.SwaggerDateConverter;

namespace Elli.Api.Tools.Model
{
    /// <summary>
    /// LoanContractMilestoneTemplateLogs
    /// </summary>
    [DataContract]
    public partial class LoanContractMilestoneTemplateLogs :  IEquatable<LoanContractMilestoneTemplateLogs>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ElliLogRecordId
        /// </summary>
        [DataMember(Name="elliLogRecordId", EmitDefaultValue=false)]
        public int? ElliLogRecordId { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneTemplateID
        /// </summary>
        [DataMember(Name="milestoneTemplateID", EmitDefaultValue=false)]
        public string MilestoneTemplateID { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneTemplateName
        /// </summary>
        [DataMember(Name="milestoneTemplateName", EmitDefaultValue=false)]
        public string MilestoneTemplateName { get; set; }

        /// <summary>
        /// Gets or Sets IsTemplateLocked
        /// </summary>
        [DataMember(Name="isTemplateLocked", EmitDefaultValue=false)]
        public bool? IsTemplateLocked { get; set; }

        /// <summary>
        /// Gets or Sets IsTemplateDatesLocked
        /// </summary>
        [DataMember(Name="isTemplateDatesLocked", EmitDefaultValue=false)]
        public bool? IsTemplateDatesLocked { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedDateUtc
        /// </summary>
        [DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUtc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractMilestoneTemplateLogs {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ElliLogRecordId: ").Append(ElliLogRecordId).Append("\n");
            sb.Append("  MilestoneTemplateID: ").Append(MilestoneTemplateID).Append("\n");
            sb.Append("  MilestoneTemplateName: ").Append(MilestoneTemplateName).Append("\n");
            sb.Append("  IsTemplateLocked: ").Append(IsTemplateLocked).Append("\n");
            sb.Append("  IsTemplateDatesLocked: ").Append(IsTemplateDatesLocked).Append("\n");
            sb.Append("  UpdatedDateUtc: ").Append(UpdatedDateUtc).Append("\n");
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
            return this.Equals(input as LoanContractMilestoneTemplateLogs);
        }

        /// <summary>
        /// Returns true if LoanContractMilestoneTemplateLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractMilestoneTemplateLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractMilestoneTemplateLogs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ElliLogRecordId == input.ElliLogRecordId ||
                    (this.ElliLogRecordId != null &&
                    this.ElliLogRecordId.Equals(input.ElliLogRecordId))
                ) && 
                (
                    this.MilestoneTemplateID == input.MilestoneTemplateID ||
                    (this.MilestoneTemplateID != null &&
                    this.MilestoneTemplateID.Equals(input.MilestoneTemplateID))
                ) && 
                (
                    this.MilestoneTemplateName == input.MilestoneTemplateName ||
                    (this.MilestoneTemplateName != null &&
                    this.MilestoneTemplateName.Equals(input.MilestoneTemplateName))
                ) && 
                (
                    this.IsTemplateLocked == input.IsTemplateLocked ||
                    (this.IsTemplateLocked != null &&
                    this.IsTemplateLocked.Equals(input.IsTemplateLocked))
                ) && 
                (
                    this.IsTemplateDatesLocked == input.IsTemplateDatesLocked ||
                    (this.IsTemplateDatesLocked != null &&
                    this.IsTemplateDatesLocked.Equals(input.IsTemplateDatesLocked))
                ) && 
                (
                    this.UpdatedDateUtc == input.UpdatedDateUtc ||
                    (this.UpdatedDateUtc != null &&
                    this.UpdatedDateUtc.Equals(input.UpdatedDateUtc))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ElliLogRecordId != null)
                    hashCode = hashCode * 59 + this.ElliLogRecordId.GetHashCode();
                if (this.MilestoneTemplateID != null)
                    hashCode = hashCode * 59 + this.MilestoneTemplateID.GetHashCode();
                if (this.MilestoneTemplateName != null)
                    hashCode = hashCode * 59 + this.MilestoneTemplateName.GetHashCode();
                if (this.IsTemplateLocked != null)
                    hashCode = hashCode * 59 + this.IsTemplateLocked.GetHashCode();
                if (this.IsTemplateDatesLocked != null)
                    hashCode = hashCode * 59 + this.IsTemplateDatesLocked.GetHashCode();
                if (this.UpdatedDateUtc != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUtc.GetHashCode();
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
