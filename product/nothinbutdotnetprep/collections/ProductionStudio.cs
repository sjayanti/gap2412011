namespace nothinbutdotnetprep.collections
{
    using System.Collections.Generic;


    public class ProductionStudio 
    {
        public string Name { get; set; }

        public static readonly ProductionStudio MGM = new ProductionStudio("MGM");
        public static readonly ProductionStudio Paramount = new ProductionStudio("Paramount");
        public static readonly ProductionStudio Universal = new ProductionStudio("Universal");
        public static readonly ProductionStudio Pixar = new ProductionStudio("Pixar");
        public static readonly ProductionStudio Disney = new ProductionStudio("Disney");
        public static readonly ProductionStudio Dreamworks = new ProductionStudio("Dreamworks");

        public ProductionStudio(string name)
        {
            this.Name = name;
        }

    }
}