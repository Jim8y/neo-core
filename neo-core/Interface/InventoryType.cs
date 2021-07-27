namespace Neo.Interface
{
    /// <summary>
    /// Represents the type of an inventory.
    /// </summary>
    public enum InventoryType : byte
    {
        /// <summary>
        /// Indicates that the inventory is a <see cref="Transaction"/>.
        /// </summary>
        TX = 0x2b,//MessageCommand.Transaction,

        /// <summary>
        /// Indicates that the inventory is a <see cref="Block"/>.
        /// </summary>
        Block = 0x2c,// MessageCommand.Block,

        /// <summary>
        /// Indicates that the inventory is an <see cref="ExtensiblePayload"/>.
        /// </summary>
        Extensible = 0x2e,// MessageCommand.Extensible
    }
}
