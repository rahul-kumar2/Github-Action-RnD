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
	
	public partial class equipmentHeight : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""equipmentHeight"",""namespace"":""com.maersk.orderhandling.containermain"",""fields"":[{""name"":""equipmentHeightCode"",""doc"":""The Maersk code for container height."",""type"":""string""},{""name"":""equipmentHeightName"",""doc"":""The Maersk container height."",""type"":""string""}]}");
		/// <summary>
		/// The Maersk code for container height.
		/// </summary>
		private string _equipmentHeightCode;
		/// <summary>
		/// The Maersk container height.
		/// </summary>
		private string _equipmentHeightName;
		public virtual Schema Schema
		{
			get
			{
				return equipmentHeight._SCHEMA;
			}
		}
		/// <summary>
		/// The Maersk code for container height.
		/// </summary>
		public string equipmentHeightCode
		{
			get
			{
				return this._equipmentHeightCode;
			}
			set
			{
				this._equipmentHeightCode = value;
			}
		}
		/// <summary>
		/// The Maersk container height.
		/// </summary>
		public string equipmentHeightName
		{
			get
			{
				return this._equipmentHeightName;
			}
			set
			{
				this._equipmentHeightName = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.equipmentHeightCode;
			case 1: return this.equipmentHeightName;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.equipmentHeightCode = (System.String)fieldValue; break;
			case 1: this.equipmentHeightName = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}