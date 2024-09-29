namespace PatrickT_Assignment_1.Models
{
    public class Repository
    {
        public static List<EquipmentRequest> requests = new();
        public static IEnumerable<EquipmentRequest> Requests => requests;

        public static void AddRequest(EquipmentRequest request)
        {
            Console.WriteLine(request);
            requests.Add(request);
        }
    }
}