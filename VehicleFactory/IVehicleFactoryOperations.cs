namespace DesignPatternExamples
{
    public interface IVehicleFactoryOperations
    {
        public  IVehicleMaker Validation(string carType);

        public char MakeAnotherVehicle();
    }
}
