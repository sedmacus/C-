

namespace HomeworkClass05
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }  
         
        public Car()
        {
        }

        public Car(string model, int speed)
        {
            Model = model;  
            Speed = speed;
        }

        public int CalculateSpeed(Driver driver)
        {
            int res = driver.Skill * Speed;
            return res;
        }
    }
}
