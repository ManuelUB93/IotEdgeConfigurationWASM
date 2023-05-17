namespace IotEdgeConfigurationWASM.Models
{
    public class BrowseName
    {
        public int NamespaceIndex { get; set; }
        public string? Name { get; set; }
    }
    public class DisplayName
    {
        public object? Locale { get; set; }
        public string? Text { get; set; }
    }
    public class NodeId
    {
        public string? Identifier { get; set; }
    }
    public class ReferenceTypeId
    {
        public string? Identifier { get; set; }
    }
    public class NodeTreeView
    {
        public ReferenceTypeId? ReferenceTypeId { get; set; }
        public bool IsForward { get; set; }
        public NodeId? NodeId { get; set; }
        public BrowseName? BrowseName { get; set; }
        public DisplayName? DisplayName { get; set; }
        public int NodeClass { get; set; }
        public TypeDefinition? TypeDefinition { get; set; }
        public HashSet<NodeTreeView> children { get; set; } = new();
    }
    public class TypeDefinition
    {
        public string? Identifier { get; set; }
    }
}
