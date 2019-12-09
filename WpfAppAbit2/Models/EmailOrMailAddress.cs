namespace WpfAppAbit2.Models
{

    /// <summary>
    /// адрес по которому уведмоляем о поступлении/непрохождении конкурса/возврате документов и т.д.
    /// </summary>
    public class EmailOrMailAddress
    {


        public string Email { get; set; }
        public Address Address { get; set; }
        public void Edit(string Email, Address Address)
        {
            this.Email = Email;
            this.Address.Edit(Address.ID, Address.Town, Address.Street, Address.House);
        }
        public EmailOrMailAddress(string email, Address address)
        {

        }
    }
}