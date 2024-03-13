// See https://aka.ms/new-console-template for more information
using FactoryMethodV2;

Console.WriteLine("Hello, World!");



PlanningManagerV2 pm = new PlanningManagerV2();
pm.ExecutePlanning(GetAvailableTime(), new PlannerFactoryNight());


static object GetAvailableTime()
{
    throw new NotImplementedException();
}