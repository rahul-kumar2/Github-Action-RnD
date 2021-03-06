// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.11.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace com.maersk.orderhandling.containermain
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	/// <summary>
	/// An alternative cargo package type code.
	/// </summary>
	public partial class alternativeCode : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""alternativeCode"",""doc"":""An alternative cargo package type code."",""namespace"":""com.maersk.orderhandling.containermain"",""fields"":[{""name"":""alternativeCode"",""doc"":""Alternative code type code."",""type"":""string""},{""name"":""unPackageType"",""doc"":""The United Nations standardised code for a package type. If any alternative package type code exists - this should be always be specified."",""default"":null,""type"":[""null"",{""type"":""record"",""name"":""unPackageType"",""namespace"":""com.maersk.orderhandling.containermain"",""fields"":[{""name"":""unPackageTypeCode"",""doc"":""The United Nations standardized cargo package type code."",""type"":""string""},{""name"":""unPackageTypeName"",""doc"":""The name of the United Nations standardized cargo package type."",""type"":""string""},{""name"":""unPackageTypeDescription"",""doc"":""A description of the United Nations standardized cargo package type."",""default"":null,""type"":[""null"",""string""]}]}]},{""name"":""imDgPackageType"",""doc"":""Package types specifically described for hazardous cargo."",""default"":null,""type"":[""null"",{""type"":""record"",""name"":""imDgPackageType"",""namespace"":""com.maersk.orderhandling.containermain"",""fields"":[{""name"":""imDgPackageTypeCode"",""doc"":""The International Maritime Dangerous Goods code (Up to 5 characters). E.g.: 11HA2, 1A1."",""type"":""string""},{""name"":""imDgPackageTypeName"",""doc"":""The packaging type name."",""type"":""string""},{""name"":""imDgPackageTypeDescription"",""doc"":""A text describing the package type."",""default"":null,""type"":[""null"",""string""]}]}]}]}");
		/// <summary>
		/// Alternative code type code.
		/// </summary>
		private string _alternativeCode;
		/// <summary>
		/// The United Nations standardised code for a package type. If any alternative package type code exists - this should be always be specified.
		/// </summary>
		private com.maersk.orderhandling.containermain.unPackageType _unPackageType;
		/// <summary>
		/// Package types specifically described for hazardous cargo.
		/// </summary>
		private com.maersk.orderhandling.containermain.imDgPackageType _imDgPackageType;
		public virtual Schema Schema
		{
			get
			{
				return alternativeCode._SCHEMA;
			}
		}
		/// <summary>
		/// Alternative code type code.
		/// </summary>
		public string alternativeCode
		{
			get
			{
				return this._alternativeCode;
			}
			set
			{
				this._alternativeCode = value;
			}
		}
		/// <summary>
		/// The United Nations standardised code for a package type. If any alternative package type code exists - this should be always be specified.
		/// </summary>
		public com.maersk.orderhandling.containermain.unPackageType unPackageType
		{
			get
			{
				return this._unPackageType;
			}
			set
			{
				this._unPackageType = value;
			}
		}
		/// <summary>
		/// Package types specifically described for hazardous cargo.
		/// </summary>
		public com.maersk.orderhandling.containermain.imDgPackageType imDgPackageType
		{
			get
			{
				return this._imDgPackageType;
			}
			set
			{
				this._imDgPackageType = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.alternativeCode;
			case 1: return this.unPackageType;
			case 2: return this.imDgPackageType;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.alternativeCode = (System.String)fieldValue; break;
			case 1: this.unPackageType = (com.maersk.orderhandling.containermain.unPackageType)fieldValue; break;
			case 2: this.imDgPackageType = (com.maersk.orderhandling.containermain.imDgPackageType)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
