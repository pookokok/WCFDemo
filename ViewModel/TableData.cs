namespace ViewModel
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class TableData<T> where T : class
    {
        [DataMember]
        public int Count { get; set; }

        [DataMember]
        public IList<T> RecordList { get; set; }
    }
}
