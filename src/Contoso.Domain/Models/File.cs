namespace Contoso.Domain.Models
{
    public class File
    {
        public string Name { get; set; }
        public string ContentType { get; set; }
        public long Length { get; set; }
        public Organization Owner { get; set; }
        public User Curator { get; set; }
    }
}