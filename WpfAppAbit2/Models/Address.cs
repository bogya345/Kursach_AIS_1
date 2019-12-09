namespace WpfAppAbit2.Models
{
    //адресс
    public class Address
    {
        public int ID { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public void Edit(int ID, string Town, string Street, string House)
        {
            this.ID = ID;
            this.Town = Town;
            this.Street = Street;
            this.House = House;
        }
    }
}