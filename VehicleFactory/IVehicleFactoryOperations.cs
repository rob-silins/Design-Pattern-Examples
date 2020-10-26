namespace DesignPatternExamples
{
    public interface IVehicleFactoryOperations
    {
        public  IVehicleMaker Validation(string carType);

        public string MakeAnotherVehicle();
    }
}
