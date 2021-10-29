using System;
using System.ComponentModel.DataAnnotations;
using VendasWeb.Models.Enums;

namespace VendasWeb.Models
{
    public class SalesRecord
    {
        [Display(Name ="ID")]
        public int Id { get; set; }

        [Display(Name ="Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Display(Name ="Valor")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }

        
        public SaleStatus Status { get; set; }

        [Display(Name ="Vendedor")]
        public Seller Seller { get; set; }

        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
