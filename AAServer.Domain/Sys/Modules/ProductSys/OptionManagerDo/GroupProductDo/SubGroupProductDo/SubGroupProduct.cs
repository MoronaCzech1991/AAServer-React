namespace AAServer.Domain.Sys.Modules.ProductSys.OptionManagerDo.GroupProductDo.SubGroupProductDo
{
    public class SubGroupProduct
    {
        public SubGroupProduct()
        {
            GroupProductFather = new GroupProduct();
        }

        public int Id { get; set; }
        public int IdGroupProduct { get; set; }
        public string Name { get; set; }

        public GroupProduct GroupProductFather { get; set; }
    }
}
