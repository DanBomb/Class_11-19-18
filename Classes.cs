namespace ThatOneThing {


    public class Missile : ITrackable {


        public double rate;
        public double missileDistance;

        public Missile (double rate) {
            this.rate = rate;
        }
        public double MathCalculator (int time, double rate) {
            return time * rate;
        }

        public double DistanceTravelledInMeters (double rate, int time) {
            missileDistance = MathCalculator (time, rate);
            return missileDistance;

    
        }
        
    }

    public class RaceCar : ITrackable
    {

        public double rate;
        public double raceCarDistance;

        public RaceCar(double rate) {

            this.rate = rate;
        }
        public double MathCalculator (int time, double rate) {

            return time * rate;
        }

        public double DistanceTravelledInMeters(double rate, int time)
        {
            raceCarDistance = MathCalculator (time, rate);
            return raceCarDistance;
        }
    }
}      

