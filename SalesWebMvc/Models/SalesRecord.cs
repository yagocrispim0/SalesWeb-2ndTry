﻿using SalesWebMvc.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")] // Opção: Deixar horário para que se possa ter esse controle.
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public Double Amount { get; set; }
        public SaleStatus SaleStatus { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus saleStatus, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            SaleStatus = saleStatus;
            Seller = seller;
        }

        public SalesRecord()
        {
        }
    }
}
