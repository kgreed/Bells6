using DevExpress.Persistent.Base;
namespace Bells6.Module.BusinessObjects
{
    [NavigationItem("Default")]
    public class Bell
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Tone { get; set; }
    }
}