namespace AAServer.Domain.Sys.Modules.ServiceSys.ServiceDo
{
    public class Service
    {
        public Service()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string InternalCode { get; set; }
        public EnumService Type { get; set; }
        public double SellValue { get; set; }
        public double CostValue { get; set; }
        public double Commission { get; set; }
        public bool Active { get; set; }
    }
}
