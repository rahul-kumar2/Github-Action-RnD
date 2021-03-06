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
	
	public partial class totalStuffedWeightWeightUnit : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""totalStuffedWeightWeightUnit"",""namespace"":""com.maersk.orderhandling.containermain"",""fields"":[{""name"":""unitOfMeasurementCode"",""doc"":""The measurement code - E.g.: KGS, Metric Ton, US LBS."",""type"":""string""},{""name"":""unitOfMeasurementName"",""doc"":""The full name of the measurement unit."",""type"":""string""},{""name"":""measurementSystem"",""doc"":""Indicator for the measurement system used."",""type"":{""type"":""record"",""name"":""measurementSystem"",""namespace"":""com.maersk.orderhandling.containermain"",""fields"":[{""name"":""measurementSystemCode"",""doc"":""The abbreviated measure system name. - E.g.: S.I. (Metric), Imperial, US Customary Units, Time, Industry Standard."",""type"":""string""},{""name"":""measurementSystemName"",""doc"":""The full measure system name."",""type"":""string""}]}}]}");
		/// <summary>
		/// The measurement code - E.g.: KGS, Metric Ton, US LBS.
		/// </summary>
		private string _unitOfMeasurementCode;
		/// <summary>
		/// The full name of the measurement unit.
		/// </summary>
		private string _unitOfMeasurementName;
		/// <summary>
		/// Indicator for the measurement system used.
		/// </summary>
		private com.maersk.orderhandling.containermain.measurementSystem _measurementSystem;
		public virtual Schema Schema
		{
			get
			{
				return totalStuffedWeightWeightUnit._SCHEMA;
			}
		}
		/// <summary>
		/// The measurement code - E.g.: KGS, Metric Ton, US LBS.
		/// </summary>
		public string unitOfMeasurementCode
		{
			get
			{
				return this._unitOfMeasurementCode;
			}
			set
			{
				this._unitOfMeasurementCode = value;
			}
		}
		/// <summary>
		/// The full name of the measurement unit.
		/// </summary>
		public string unitOfMeasurementName
		{
			get
			{
				return this._unitOfMeasurementName;
			}
			set
			{
				this._unitOfMeasurementName = value;
			}
		}
		/// <summary>
		/// Indicator for the measurement system used.
		/// </summary>
		public com.maersk.orderhandling.containermain.measurementSystem measurementSystem
		{
			get
			{
				return this._measurementSystem;
			}
			set
			{
				this._measurementSystem = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.unitOfMeasurementCode;
			case 1: return this.unitOfMeasurementName;
			case 2: return this.measurementSystem;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.unitOfMeasurementCode = (System.String)fieldValue; break;
			case 1: this.unitOfMeasurementName = (System.String)fieldValue; break;
			case 2: this.measurementSystem = (com.maersk.orderhandling.containermain.measurementSystem)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
