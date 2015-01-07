﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated on Wed, Dec 24, 2014 16:02+0100 for FHIR v0.4.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A response to an order
    /// </summary>
    [FhirType("OrderResponse", IsResource=true)]
    [DataContract]
    public partial class OrderResponse : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.OrderResponse; } }
        [NotMapped]
        public override string TypeName { get { return "OrderResponse"; } }
        
        /// <summary>
        /// The status of the response to an order
        /// </summary>
        [FhirEnumeration("OrderOutcomeStatus")]
        public enum OrderOutcomeStatus
        {
            /// <summary>
            /// The order is known, but no processing has occurred at this time.
            /// </summary>
            [EnumLiteral("pending")]
            Pending,
            /// <summary>
            /// The order is undergoing initial processing to determine whether it will be accepted (usually this involves human review).
            /// </summary>
            [EnumLiteral("review")]
            Review,
            /// <summary>
            /// The order was rejected because of a workflow/business logic reason.
            /// </summary>
            [EnumLiteral("rejected")]
            Rejected,
            /// <summary>
            /// The order was unable to be processed because of a technical error (i.e. unexpected error).
            /// </summary>
            [EnumLiteral("error")]
            Error,
            /// <summary>
            /// The order has been accepted, and work is in progress.
            /// </summary>
            [EnumLiteral("accepted")]
            Accepted,
            /// <summary>
            /// Processing the order was halted at the initiators request.
            /// </summary>
            [EnumLiteral("cancelled")]
            Cancelled,
            /// <summary>
            /// The order has been cancelled and replaced by another.
            /// </summary>
            [EnumLiteral("replaced")]
            Replaced,
            /// <summary>
            /// Processing the order was stopped because of some workflow/business logic reason.
            /// </summary>
            [EnumLiteral("aborted")]
            Aborted,
            /// <summary>
            /// The order has been completed.
            /// </summary>
            [EnumLiteral("complete")]
            Complete,
        }
        
        /// <summary>
        /// Identifiers assigned to this order by the orderer or by the receiver
        /// </summary>
        [FhirElement("identifier", Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// The order that this is a response to
        /// </summary>
        [FhirElement("request", Order=100)]
        [References("Order")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Request
        {
            get { return _Request; }
            set { _Request = value; OnPropertyChanged("Request"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Request;
        
        /// <summary>
        /// When the response was made
        /// </summary>
        [FhirElement("date", Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// When the response was made
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if(value == null)
                  DateElement = null; 
                else
                  DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Who made the response
        /// </summary>
        [FhirElement("who", Order=120)]
        [References("Practitioner","Organization","Device")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Who
        {
            get { return _Who; }
            set { _Who = value; OnPropertyChanged("Who"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Who;
        
        /// <summary>
        /// If required by policy
        /// </summary>
        [FhirElement("authority", Order=130, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
        [DataMember]
        public Hl7.Fhir.Model.Element Authority
        {
            get { return _Authority; }
            set { _Authority = value; OnPropertyChanged("Authority"); }
        }
        
        private Hl7.Fhir.Model.Element _Authority;
        
        /// <summary>
        /// pending | review | rejected | error | accepted | cancelled | replaced | aborted | complete
        /// </summary>
        [FhirElement("code", Order=140)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.OrderResponse.OrderOutcomeStatus> CodeElement
        {
            get { return _CodeElement; }
            set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
        }
        
        private Code<Hl7.Fhir.Model.OrderResponse.OrderOutcomeStatus> _CodeElement;
        
        /// <summary>
        /// pending | review | rejected | error | accepted | cancelled | replaced | aborted | complete
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.OrderResponse.OrderOutcomeStatus? Code
        {
            get { return CodeElement != null ? CodeElement.Value : null; }
            set
            {
                if(value == null)
                  CodeElement = null; 
                else
                  CodeElement = new Code<Hl7.Fhir.Model.OrderResponse.OrderOutcomeStatus>(value);
                OnPropertyChanged("Code");
            }
        }
        
        /// <summary>
        /// Additional description of the response
        /// </summary>
        [FhirElement("description", Order=150)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _DescriptionElement;
        
        /// <summary>
        /// Additional description of the response
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if(value == null)
                  DescriptionElement = null; 
                else
                  DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Description");
            }
        }
        
        /// <summary>
        /// Details of the outcome of performing the order
        /// </summary>
        [FhirElement("fulfillment", Order=160)]
        [References()]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Fulfillment
        {
            get { if(_Fulfillment==null) _Fulfillment = new List<Hl7.Fhir.Model.ResourceReference>(); return _Fulfillment; }
            set { _Fulfillment = value; OnPropertyChanged("Fulfillment"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Fulfillment;
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as OrderResponse;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(Request != null) dest.Request = (Hl7.Fhir.Model.ResourceReference)Request.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                if(Who != null) dest.Who = (Hl7.Fhir.Model.ResourceReference)Who.DeepCopy();
                if(Authority != null) dest.Authority = (Hl7.Fhir.Model.Element)Authority.DeepCopy();
                if(CodeElement != null) dest.CodeElement = (Code<Hl7.Fhir.Model.OrderResponse.OrderOutcomeStatus>)CodeElement.DeepCopy();
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                if(Fulfillment != null) dest.Fulfillment = new List<Hl7.Fhir.Model.ResourceReference>(Fulfillment.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new OrderResponse());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as OrderResponse;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Request, otherT.Request)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(Who, otherT.Who)) return false;
            if( !DeepComparable.Matches(Authority, otherT.Authority)) return false;
            if( !DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
            if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.Matches(Fulfillment, otherT.Fulfillment)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as OrderResponse;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Request, otherT.Request)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(Who, otherT.Who)) return false;
            if( !DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
            if( !DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
            if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.IsExactly(Fulfillment, otherT.Fulfillment)) return false;
            
            return true;
        }
        
    }
    
}
