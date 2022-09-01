using System.ComponentModel.DataAnnotations;

namespace OCPI.Tokens
{
    public class EnergyContract
    {
        [Required]
        [StringLength(64)]
        public string SupplierName { get; set; }
        [StringLength(64)]
        public string? ContractId { get; set; }

        public EnergyContract() { }
    }
}