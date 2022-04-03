namespace HeirsBackend.Domain.DataObjects
{
    public class PersonUploadDTO
    {
        public List<PersonObj> persons { get; set; }
    }

    public class PersonObj
    {
        public string person_id { get; set; }
        public string course_id { get; set; }
        public string name { get; set; }
        public int? score { get; set; }
    }
}
