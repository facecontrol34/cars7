using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_7
{
    abstract class Transport
    {
        public abstract double Speed { get; }
        public abstract double CarryingCapacity { get; }
        public abstract double Range { get; }

        public abstract string GetTransportInfo();
    }

    abstract class Automobile : Transport
    {
        public string mark { get; set; }
        public override string GetTransportInfo()
        {
            return $"{mark} грузоподъемностью {CarryingCapacity} кг может проехать {Range} км";
        }
    }

    abstract class Airplane : Transport
    {
        public string mark { get; set; }
        public override string GetTransportInfo()
        {
            return $"{mark} грузоподъемностью {CarryingCapacity} кг может пролететь {Range} км";
        }
    }

    abstract class Ship : Transport
    {
        public string mark { get; set; }
        public override string GetTransportInfo()
        {
            return $"{mark} грузоподъемностью {CarryingCapacity} кг может пройти {Range} км по воде";
        }
    }

    class Lada : Automobile
    {
        public override double Speed => 60;
        public override double CarryingCapacity => 250;
        public override double Range => 400;

        public Lada()
        {
            mark = "Lada";
        }
    }

    class TopGun : Airplane
    {
        public override double Speed => 1200;
        public override double CarryingCapacity => 4000;
        public override double Range => 30000;

        public TopGun()
        {
            mark = "TopGun";
        }
    }

    class CargoShip : Ship
    {
        public override double Speed => 40;
        public override double CarryingCapacity => 1000;
        public override double Range => 2500;

        public CargoShip()
        {
            mark = "CargoShip";
        }
    }

    class Program
    {
        static void Main()
        {
            Lada lada = new Lada();
            Console.WriteLine(lada.GetTransportInfo());

            TopGun topGun = new TopGun();
            Console.WriteLine(topGun.GetTransportInfo());

            CargoShip cargoShip = new CargoShip();
            Console.WriteLine(cargoShip.GetTransportInfo());
        }
    }
}
