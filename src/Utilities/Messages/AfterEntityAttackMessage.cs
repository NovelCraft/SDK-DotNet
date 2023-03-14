using System.Text.Json.Serialization;

namespace NovelCraft.Utilities.Messages {


  internal record ServerAfterEntityAttackMessage : MessageBase {
    public record AttackType {
      public enum AttackKind { Click, HoldStart, HoldEnd }


      [JsonPropertyName("attacker_unique_id")]
      public int AttackerUniqueId { get; init; }

      [JsonPropertyName("kind")]
      public AttackKind Kind { get; init; }
    }


    [JsonPropertyName("bound_to")]
    public override IMessage.BoundToKind BoundTo => IMessage.BoundToKind.ClientBound;

    [JsonPropertyName("type")]
    public override IMessage.MessageKind Type => IMessage.MessageKind.AfterEntityAttack;

    [JsonPropertyName("attack_list")]
    public List<AttackType> AttackList { get; init; } = new();
  }
}