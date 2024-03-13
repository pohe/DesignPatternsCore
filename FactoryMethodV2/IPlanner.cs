namespace FactoryMethodV2
{
    public interface IPlanner
    {
        PlanningResult CreatePlan(PlanningData data);
    }
}