namespace EnterpriseData;

/// <summary>
///     StorageCell - is a class linking the cell number and the product stored in it
/// </summary>
public class StorageCell
{
    /// <summary>
    ///     Number - cell number
    /// </summary>
    public uint Number { get; set; }

    /// <summary>
    ///     ItemNumberProduct - unique identifier of the product 
    /// </summary>
	public uint ItemNumberProduct { get; set; }

	public StorageCell(uint number, uint itemNumberProduct)
    {
        Number = number;
        ItemNumberProduct = itemNumberProduct;
    }
}