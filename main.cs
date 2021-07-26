using System;

class Building
{
    private int height;
    private int floorsAmount;

    public Building(int height, int floorsAmount)
    {
        this.height = height;
        this.floorsAmount = floorsAmount;
    }

    public Building(int floorsAmount)
    {
        this.floorsAmount = floorsAmount;
        this.height = 3 * floorsAmount;
    }

    public float GetFloorMaxSize()
    {
        return (float)this.height / (float)this.floorsAmount;
    }

    public int GetFloorCount()
    {
        return this.floorsAmount;
    }

    public int GetSize()
    {
        return this.height;
    }


    public static void Main(string[] args)
    {
        Console.WriteLine("How high would the building be ? ");
        int buildingHeight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many floors would there be ? ");
        int floorsAmount = Convert.ToInt32(Console.ReadLine());
        Building firstBuilding = new Building(buildingHeight, floorsAmount);
        Console.WriteLine("With these elements, each floor would be: " + firstBuilding.GetFloorMaxSize() + " meters");
        Console.WriteLine("If you prefer, please provide the number of floors you want on the building ");
        int floorsNumber = Convert.ToInt32(Console.ReadLine());
        Building secondBuilding = new Building(floorsNumber);
        Console.WriteLine("A building with " + secondBuilding.GetFloorCount() + " floors would be " + secondBuilding.GetSize() + " meters high.");
    }

}