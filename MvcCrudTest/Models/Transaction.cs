using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCrudTest.Models
{
    public class Transaction
    {

        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "varchar(12)")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string BankName { get; set; }

        [Column(TypeName = "varchar(11)")]
        public string SWIFTCode { get; set; }


        public int Amount { get; set; }


        public DateTime Date { get; set; }
    }
}
