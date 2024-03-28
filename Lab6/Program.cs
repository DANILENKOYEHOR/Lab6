using Lab6;

internal class Program
{
    static void Main(string[] args)
    {
        // Создаем наш список
        ProductManager manager = new ProductManager();

        // Добавляем продукты
        manager.AddProduct(new OrganicProduct("Яблоко", 1000, "Свежие золотые яблоки"));
        manager.AddProduct(new OrganicProduct("Банан", 60, "Спелые африканские бананы"));

        // Выводим информацию
        manager.DisplayProducts();

        // Редактируем продукт
        manager.EditProduct(0, new OrganicProduct("Яблоко", 100, "Свежие медные яблоки"));
        manager.EditProduct(1, new OrganicProduct("Банан", 10, "Не свежие африканские бананы"));

        // Выводим обновленный список
        Console.WriteLine("\nПосле редактирования:");
        manager.DisplayProducts();

        // Удаляем продукт
        manager.RemoveProduct(new OrganicProduct("Банан", 10, "Не свежие африканские бананы"));

        // Выводим обновленный список
        Console.WriteLine("\nСписок после удаления:");
        manager.DisplayProducts();
    }
}