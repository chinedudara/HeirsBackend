namespace HeirsBackend.Domain.DataObjects
{
    public class CourseUploadDTO
    {
        public List<CourseObj> courses { get; set; }
    }

    public class CourseObj
    {
        public string id { get; set; }
        public string name { get; set; }
    }
}
