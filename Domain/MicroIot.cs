namespace Domain
{
    public class MicroDevice
    {
        public int DeviceId { get; set; }
        
        public int DeviceOwnerId { get; set; }
        public int DeviceNumericValue { get; set; }
        public bool DeviceAnalogicValue { get; set; }

        public int DeviceCategoryId { get; set; }

        public string DeviceName { get; set; } = string.Empty;


    }
}
