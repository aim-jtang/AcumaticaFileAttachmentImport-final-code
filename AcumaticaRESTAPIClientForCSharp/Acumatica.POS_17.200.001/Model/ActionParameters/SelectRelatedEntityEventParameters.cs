using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class SelectRelatedEntityEventParameters
	{
		public SelectRelatedEntityEventParameters() { }

		[DataMember(Name="RelatedEntity", EmitDefaultValue=false)]
		public StringValue RelatedEntity { get; set; }
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}