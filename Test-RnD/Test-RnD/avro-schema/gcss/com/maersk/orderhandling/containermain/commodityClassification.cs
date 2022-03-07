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
	
	public partial class commodityClassification : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"commodityClassification\",\"namespace\":\"com.maersk.orderha" +
				"ndling.containermain\",\"fields\":[{\"name\":\"commodityGroup\",\"doc\":\"The commodity ca" +
				"tegory type.\",\"default\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"commodityGr" +
				"oup\",\"namespace\":\"com.maersk.orderhandling.containermain\",\"fields\":[{\"name\":\"com" +
				"modityGroupCode\",\"doc\":\"The identifying code for the commodity category.\",\"type\"" +
				":\"string\"},{\"name\":\"commodityGroupName\",\"doc\":\"The full name of the commodity ca" +
				"tegory.\",\"type\":\"string\"}]}]},{\"name\":\"commodityCode\",\"doc\":\"The HS code for the" +
				" commodity.\",\"type\":\"string\"},{\"name\":\"commodityName\",\"doc\":\"A textual descripti" +
				"on of the commodity.\",\"type\":\"string\"},{\"name\":\"commodityClassificationChild\",\"d" +
				"oc\":\"A sub category commodity description. This is the top level of the recursio" +
				"n level 0 not written out here to keep the Avro schema backward and forward comp" +
				"atible.\",\"default\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"commodityClassif" +
				"icationChild\",\"namespace\":\"com.maersk.orderhandling.containermain\",\"fields\":[{\"n" +
				"ame\":\"commodityGroup\",\"doc\":\"The commodity category type.\",\"default\":null,\"type\"" +
				":[\"null\",\"commodityGroup\"]},{\"name\":\"commodityCode\",\"doc\":\"The HS code for the c" +
				"ommodity.\",\"type\":\"string\"},{\"name\":\"commodityName\",\"doc\":\"A textual description" +
				" of the commodity.\",\"type\":\"string\"},{\"name\":\"commodityClassificationChildL1\",\"d" +
				"oc\":\"A sub category commodity description. The lower level of the recursion.\",\"d" +
				"efault\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"commodityClassificationChil" +
				"dL1\",\"namespace\":\"com.maersk.orderhandling.containermain\",\"fields\":[{\"name\":\"com" +
				"modityGroup\",\"doc\":\"The commodity category type.\",\"default\":null,\"type\":[\"null\"," +
				"\"commodityGroup\"]},{\"name\":\"commodityCode\",\"doc\":\"The HS code for the commodity." +
				"\",\"type\":\"string\"},{\"name\":\"commodityName\",\"doc\":\"A textual description of the c" +
				"ommodity.\",\"type\":\"string\"},{\"name\":\"commodityCodingSystem\",\"doc\":\"The system th" +
				"at defines the commodity codes: E.g.: Harmonized System, MARS Commodity codes, ." +
				"..\",\"type\":{\"type\":\"record\",\"name\":\"commodityCodingSystem\",\"namespace\":\"com.maer" +
				"sk.orderhandling.containermain\",\"fields\":[{\"name\":\"commodityCodingSystemCode\",\"d" +
				"oc\":\"The uniquely identifying code for the commodity coding system.\",\"type\":\"str" +
				"ing\"},{\"name\":\"commodityCodingSystemName\",\"doc\":\"The full name of the commodity " +
				"coding system.\",\"type\":\"string\"}]}}]}]},{\"name\":\"commodityCodingSystem\",\"doc\":\"T" +
				"he system that defines the commodity codes: E.g.: Harmonized System, MARS Commod" +
				"ity codes, ...\",\"type\":\"commodityCodingSystem\"}]}]},{\"name\":\"commodityCodingSyst" +
				"em\",\"doc\":\"The system that defines the commodity codes: E.g.: Harmonized System," +
				" MARS Commodity codes, ...\",\"type\":\"commodityCodingSystem\"}]}");
		/// <summary>
		/// The commodity category type.
		/// </summary>
		private com.maersk.orderhandling.containermain.commodityGroup _commodityGroup;
		/// <summary>
		/// The HS code for the commodity.
		/// </summary>
		private string _commodityCode;
		/// <summary>
		/// A textual description of the commodity.
		/// </summary>
		private string _commodityName;
		/// <summary>
		/// A sub category commodity description. This is the top level of the recursion level 0 not written out here to keep the Avro schema backward and forward compatible.
		/// </summary>
		private com.maersk.orderhandling.containermain.commodityClassificationChild _commodityClassificationChild;
		/// <summary>
		/// The system that defines the commodity codes: E.g.: Harmonized System, MARS Commodity codes, ...
		/// </summary>
		private com.maersk.orderhandling.containermain.commodityCodingSystem _commodityCodingSystem;
		public virtual Schema Schema
		{
			get
			{
				return commodityClassification._SCHEMA;
			}
		}
		/// <summary>
		/// The commodity category type.
		/// </summary>
		public com.maersk.orderhandling.containermain.commodityGroup commodityGroup
		{
			get
			{
				return this._commodityGroup;
			}
			set
			{
				this._commodityGroup = value;
			}
		}
		/// <summary>
		/// The HS code for the commodity.
		/// </summary>
		public string commodityCode
		{
			get
			{
				return this._commodityCode;
			}
			set
			{
				this._commodityCode = value;
			}
		}
		/// <summary>
		/// A textual description of the commodity.
		/// </summary>
		public string commodityName
		{
			get
			{
				return this._commodityName;
			}
			set
			{
				this._commodityName = value;
			}
		}
		/// <summary>
		/// A sub category commodity description. This is the top level of the recursion level 0 not written out here to keep the Avro schema backward and forward compatible.
		/// </summary>
		public com.maersk.orderhandling.containermain.commodityClassificationChild commodityClassificationChild
		{
			get
			{
				return this._commodityClassificationChild;
			}
			set
			{
				this._commodityClassificationChild = value;
			}
		}
		/// <summary>
		/// The system that defines the commodity codes: E.g.: Harmonized System, MARS Commodity codes, ...
		/// </summary>
		public com.maersk.orderhandling.containermain.commodityCodingSystem commodityCodingSystem
		{
			get
			{
				return this._commodityCodingSystem;
			}
			set
			{
				this._commodityCodingSystem = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.commodityGroup;
			case 1: return this.commodityCode;
			case 2: return this.commodityName;
			case 3: return this.commodityClassificationChild;
			case 4: return this.commodityCodingSystem;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.commodityGroup = (com.maersk.orderhandling.containermain.commodityGroup)fieldValue; break;
			case 1: this.commodityCode = (System.String)fieldValue; break;
			case 2: this.commodityName = (System.String)fieldValue; break;
			case 3: this.commodityClassificationChild = (com.maersk.orderhandling.containermain.commodityClassificationChild)fieldValue; break;
			case 4: this.commodityCodingSystem = (com.maersk.orderhandling.containermain.commodityCodingSystem)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}