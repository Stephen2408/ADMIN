namespace CarManagement.Model
{
    public class Car
    {
        public int car_id;
        public required string car_model;
        public required string car_description;
        public required string car_type;
        public required string car_status;
        public decimal car_price;
        public DateTime car_sell_date;
    }
}
