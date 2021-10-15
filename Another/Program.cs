using System;

namespace Another
{
    interface IStrategy
    {
        void BuildRoute();
    }

    class RoadStrategy : IStrategy
    {
        public void BuildRoute()=> Console.WriteLine("Road Route Worked");
    }

    class WalkingStrategy : IStrategy
    {
        public void BuildRoute() => Console.WriteLine("Walk Route Worked");
    }
    class TransportStrategy : IStrategy
    {
        public void BuildRoute() => Console.WriteLine("Transport Route Worked");
    }
    class Navigator
    {
        public IStrategy Strategy { get; set; }
        public Navigator(IStrategy strategy)=>Strategy = strategy;
        public void BuildRoute()=>Strategy.BuildRoute();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WalkingStrategy walkingStrategy= new WalkingStrategy();
            TransportStrategy transportStrategy = new TransportStrategy();
            RoadStrategy roadStrategy= new RoadStrategy();

            Navigator navigator = new Navigator(transportStrategy);
            //Navigator navigator = new Navigator(walkingStrategy);
            //Navigator navigator = new Navigator(roadStrategy);

            navigator.BuildRoute();
        }
    }
}
