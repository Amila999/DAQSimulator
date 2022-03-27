using System;

namespace SensorApplication
{
    class Sensor
    {
        double dVal;
        int sId;
        Random rSenVal;

        public Sensor(int id)
        {
            sId = id;
            rSenVal = new Random(id);
            dVal = 0.0F;
        }

        public double GetValue()
        {
            dVal += rSenVal.NextDouble();
            return dVal;
        }

        public int GetSensId()
        {
            return sId;
        }
    }
}
