﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnterpriseWarehouse.Model;

/// <summary>
///     InvoicesContent - is the class that links the quantity of goods purchased to the invoice
/// </summary>
[Table("invoice_content")]
public class InvoiceContent
{
    /// <summary>
    ///     Id - number of the invoice content
    /// </summary>
    [Key]
    [Column("id")]
    public int Id { get; set; }

    /// <summary>
    ///     InvoiceId - number of the invoice
    /// </summary>
    public int InvoiceId { get; set; }
    [ForeignKey("InvoiceId")]
    [Column("invoice_id")]
    public Invoice Invoices { get; set; }

    /// <summary>
    ///     ProductID - item number of the product
    /// </summary>
    public int ProductID { get; set; }
    [ForeignKey("ProductID")]
    [Column("product_id")]
    public Product Product { get; set; }

    /// <summary>
    ///     Quantity - quantity of goods purchased
    /// </summary>
    [Column("quantity")]
    public int Quantity { get; set; }

    public InvoiceContent(int id, Invoice invoice, Product product, int quantity)
    {
        Id = id;
        Invoices = invoice;
        Product = product;
        Quantity = quantity;
    }

    public InvoiceContent() { }
}
