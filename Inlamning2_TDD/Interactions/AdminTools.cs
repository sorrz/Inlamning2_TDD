using Inlamning2_TDD.Repository;

internal class AdminTools
{

    private CampaignRepository campaignRepository;
    private ProductRepository productRepository;
    
    public AdminTools(CampaignRepository campaignRepository, ProductRepository productRepository)
    {
        this.campaignRepository = campaignRepository;
        this.productRepository = productRepository;
    }
    
    internal void AdminMenu()
    {
        
        
        Console.Clear();
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"1. Lägg till Produkt\n" +
                              $"2. Ändra på Produkt\n" +
                              $"3. Lägg till Kampanj\n" +
                              $"4. Ändra på Kampanj\n" +
                              $"5. Ta Bort en Kampanj\n" +
                              $"6. Gå Tillbaka...");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    var result = Interactions.GetProductInput();
                    productRepository.AddProduct(result);
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    var id = Interactions.GetProductID();
                    productRepository.UpdateProduct(id);
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    campaignRepository.CreateCampaign();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    // TODO: FINISH THIS
                    var campID = Interactions.GetCampaignID();
                    campaignRepository.EditCampaign(campID);
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    // TODO: FINISH THIS
                    var caID = Interactions.GetCampaignID();
                    campaignRepository.DeleteCampaign(caID);
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    return;
            }
        }
    }
}