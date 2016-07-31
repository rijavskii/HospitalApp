using EntityDb.Context;

namespace HospitalApp
{
    /// <summary>
    /// Class which allow us to export medicine
    /// </summary>
    public class Medicine
    {
        public string Name { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerCountry { get; set; }
        public MedicineType Type { get; set; }
    }
}