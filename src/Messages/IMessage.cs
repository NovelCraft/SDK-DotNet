using System.Text.Json.Nodes;

namespace NovelCraft.Sdk.Messages;

/// <summary>
/// Represents common interfaces for all messages.
/// </summary>
public interface IMessage {
  /// <summary>
  /// Represents the transmission direction of the message.
  /// </summary>
  public enum BoundToKind {
    /// <summary>
    /// The message is sent from the client to the server.
    /// </summary>
    ServerBound,

    /// <summary>
    /// The message is sent from the server to the client.
    /// </summary>
    ClientBound
  }

  /// <summary>
  /// Represents the type of the message.
  /// </summary>
  public enum MessageKind {
    AfterBlockChange = 100,
    AfterEntityAttack,
    AfterEntityCreate,
    AfterEntityDespawn,
    AfterEntityHurt,
    AfterEntityOrientationChange,
    AfterEntityPositionChange,
    AfterEntityRemove,
    AfterEntitySpawn,
    AfterPlayerInventoryChange,

    Error = 200,

    GetBlocksAndEntities = 300,
    GetPlayerInfo,
    GetTick,

    Ping = 400,

    PerformAttack = 500,
    PerformCraft,
    PerformDropItem,
    PerformJump,
    PerformMergeSlots,
    PerformMove,
    PerformRotate,
    PerformSwapSlots,
    PerformSwitchMainHandSlot,
    PerformUse,
  }


  /// <summary>
  /// Gets the JSON representation of the message.
  /// </summary>
  public JsonNode Json { get; }

  /// <summary>
  /// Gets the transmission direction of the message.
  /// </summary>
  public BoundToKind BoundTo { get; }

  /// <summary>
  /// Gets the type of the message.
  /// </summary>
  public MessageKind Type { get; }
}