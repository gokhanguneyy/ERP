
using ERPServer.Domain.Abstractions;

namespace ERPServer.Domain.Entities
{
    public sealed class Customer : Entity
    {
        // string.Empty = "" => boş bir string anlamına geliyor
        // Eğer string.Empty kullanmasaydık model ilk başta null değeri ile hayatına başlardı ve nullException hatası
        // yiyebilirdi. Fakat şuan da örn Name değişkeni bir değere sahip ve o da => "" yani boş string'dir.

        public string Name {  get; set; } = string.Empty;
        public string TaxDepartment { get; set; } = string.Empty;
        public string TaxNumber {  get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Town { get; set; } = string.Empty;    
        public string FullAddress {  get; set; } = string.Empty;    

    }
}
