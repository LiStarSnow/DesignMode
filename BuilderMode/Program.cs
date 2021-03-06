﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMode
{
    using Structural;
    using Practical;

    class Program
    {
        static void Main(string[] args)
        {

            /**
             * 将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示
             */

            Director director = new Director();

            Builder builder1 = new ConcreteBuilder1();
            director.Construct(builder1);
            Product p1 = builder1.GetResult();
            p1.Show();

            Builder builder2 = new ConcreteBuilder2();
            director.Construct(builder2);
            Product p2 = builder2.GetResult();
            p2.Show();


            Shop shop = new Shop();
            VehicleBuilder vehichleBuilder;
            vehichleBuilder = new CarBuilder();

            shop.Construct(vehichleBuilder);
            Vehicle vehicle = vehichleBuilder.Vehicle;
            vehicle.Show();

            vehichleBuilder = new MotorCycleBuilder();

            shop.Construct(vehichleBuilder);
            vehicle = vehichleBuilder.Vehicle;
            vehicle.Show();

            vehichleBuilder = new ScooterBuilder();

            shop.Construct(vehichleBuilder);
            vehicle = vehichleBuilder.Vehicle;
            vehicle.Show();

            Console.ReadKey();
        }
    }
}
