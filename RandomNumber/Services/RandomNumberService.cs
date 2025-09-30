namespace RandomNumber.Services
{
    public class RandomNumberService: IRandomService
    {
        private readonly int _randomNumberService;
        public RandomNumberService()
        {
            _randomNumberService = new Random().Next(1, 100);   
        }

        public int GetNumber() => _randomNumberService;
    }
}
