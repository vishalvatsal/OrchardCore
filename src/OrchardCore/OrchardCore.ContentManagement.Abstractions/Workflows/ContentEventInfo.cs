namespace OrchardCore.ContentManagement.Workflows
{
    public class ContentEventInfo
    {
        public string Name { get; set; }
        public string ContentType { get; set; }
        public string ContentItemId { get; set; }
        public bool IsStart { get; set; }
    }
}