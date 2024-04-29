namespace InterfaceExercise
{
    internal interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        string Year { get; set; }
        bool CanDrive { get; set; }

        void Drive();
       
    }
}