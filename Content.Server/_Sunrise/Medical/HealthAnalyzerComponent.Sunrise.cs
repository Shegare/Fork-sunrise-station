using Content.Shared.Damage.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype.List;

// ReSharper disable once CheckNamespace
namespace Content.Server.Medical.Components;

public sealed partial class HealthAnalyzerComponent
{
    [DataField(customTypeSerializer: typeof(PrototypeIdListSerializer<DamageContainerPrototype>))]
    public List<string>? DamageContainers;
}
