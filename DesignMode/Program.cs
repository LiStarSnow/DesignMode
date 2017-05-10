using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorMode;
using ProxyMode;
using FactoryMethodMode;
using PrototypeMode;
using TemplateMethodMode;
using FacadeMode;
using AdapterMode;

namespace DesignMode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //#region 装扮模式
            //Console.WriteLine("*******************************装扮模式*******************************");
            ///*   
            // * Persion persion = new Persion("周杰伦");

            //            TShirts ts = new TShirts();
            //            BigTrouser bt = new BigTrouser();

            //            Console.WriteLine("第一种装扮：");

            //            ts.Decorate(persion);
            //            bt.Decorate(ts);

            //            bt.Show();

            //            //TShirts ts2 = new TShirts();
            //            BigTrouser bt2 = new BigTrouser();

            //            Console.WriteLine("第二种装扮：");
            //            //ts2.Decorate(persion);
            //            bt2.Decorate(persion);

            //            bt2.Show();

            // **/
            //#endregion 装扮模式

            //#region 代理模式
            //Console.WriteLine("*******************************代理模式*******************************");
            //Proxy proxy = new Proxy();
            //proxy.Request();

            //#endregion 代理模式

            //#region 工厂方法模式
            //Console.WriteLine("*******************************工厂方法模式*******************************");
            ///**
            // *
            // 工厂方法模式实现时，客户端需要决定实例化哪个工厂来实现运算，选择判断的问题还是存在，
            // 也就是说工厂方法把简单工厂的内部逻辑判断移到了客户端来进行。
            // 你想要添加功能，本来是改工厂类的，而现在是修改客户端的。
            // */

            //IFactory factory = new OperationAddFactory();
            //Operation operation = factory.CreateOperation();
            //operation.NumberA = 100;
            //operation.NumberB = 200;
            //double res = operation.GetResult();

            //Console.WriteLine("工厂方法模式获得Operation抽象对象，获得结果：{0}", res);

            //#endregion 工厂方法模式

            //#region 原型模式
            //Console.WriteLine("*******************************原型模式*******************************");
            ///**
            // * 一般在初始化信息不发生变化的情况下，克隆是最好的办法。
            // * 这既隐藏了对象的创建细节，又对性能是大大的提高。
            // * 需要注意的是引用类型的克隆，只可能引用不可能对象本身。
            // * 
            // */

            //Resume resume = new Resume("LJS");
            //resume.SetPersonalInfo("男", 11);
            //resume.SetWorkExperience("海虹", "2011~2022");

            //Resume resumeb = resume.Clone() as Resume;
            //resume.SetWorkExperience("中公网", "2011~2024");

            //resume.Display();
            //resumeb.Display();

            //#endregion 原型模式

            //#region 模板方法模式
            //Console.WriteLine("*******************************模板方法模式*******************************");
            ///**
            // * 模板方法模式是通过把不变的行为搬移到超类， 去除子类中的重复代码来实现它的优势。
            // * 很好的实现代码复用
            // *  
            // */

            //AbstractClass concreteClassA = new ConcreteClassA();
            //concreteClassA.TemplateMethod();

            //AbstractClass concreteClassB = new ConcreteClassB();
            //concreteClassB.TemplateMethod();

            //#endregion 模板方法模式

            //#region 外观模式

            //Console.WriteLine("*******************************外观模式*******************************");

            ///**
            // * 外观模式：为子系统中的一组接口提供一个一致的界面。此模式定义了一个高层接口。
            // * 这个接口使得这一子系统更加容易使用
            // * 
            // */

            //Facade facade = new Facade();
            //facade.MedthodA();

            //#endregion 外观模式

            //#region 建造者模式

            //Console.WriteLine("*******************************建造者模式*******************************");

            ///**
            // * 将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示
            // */

            //BygherrerMode.Director director = new BygherrerMode.Director();

            //BygherrerMode.Builder builder1 = new BygherrerMode.ConcreteBuilder1();
            //director.Construct(builder1);

            //var product = builder1.GetResult();

            //product.Show();

            //#endregion 建造者模式

            //#region 观察者模式

            //Console.WriteLine("*******************************观察者模式*******************************");
            ///**
            // * 观察者模式动机：将一个系统分割成一系列相互协作的类有一个不好的副作用，那就是需要维护相关对象的一致性。
            // * 我们不希望为了维持一致性而使各类紧密耦合，这样会给维护、扩展和重用都带来不便。 
            // * 
            // * 当一个对象的改变，需要同时改变其他对象，而且不知道具体有多少对象有待改变。
            // * 
            // * 
            // */

            //ObserverMode.ConcreteSubject concreteSubject = new ObserverMode.ConcreteSubject();

            //ObserverMode.Observer concreteObserver1 = new ObserverMode.ConcreteObserver(concreteSubject, "观察者1");
            //ObserverMode.Observer concreteObserver2 = new ObserverMode.ConcreteObserver(concreteSubject, "观察者2");
            //ObserverMode.Observer concreteObserver3 = new ObserverMode.ConcreteObserver(concreteSubject, "观察者3");

            //concreteSubject.Attach(concreteObserver1);
            //concreteSubject.Attach(concreteObserver2);
            //concreteSubject.Attach(concreteObserver3);
            //concreteSubject.Detach(concreteObserver2);

            //concreteSubject.SubjectState = "新状态";

            //concreteSubject.Notify();

            //Console.WriteLine("*******************************观察者委托模式*******************************");

            //ObserverMode_观察者委托.Boss boss = new ObserverMode_观察者委托.Boss();
            //boss.SubjectState = "回来啦。";
            //ObserverMode_观察者委托.StockObserver stockObserver1 = new ObserverMode_观察者委托.StockObserver(boss, "周杰伦");
            //boss.u += stockObserver1.CloseStockMarket;
            //ObserverMode_观察者委托.NBAObserver stockObserver2 = new ObserverMode_观察者委托.NBAObserver(boss, "chenxi");
            //boss.u += stockObserver2.CloseNBAMarket;

            //boss.Notify();

            //ObserverMode_观察者委托.Secretary secretary = new ObserverMode_观察者委托.Secretary();
            //secretary.SubjectState = "老板回来了";
            //secretary.u += stockObserver1.CloseStockMarket;
            //secretary.u += stockObserver2.CloseNBAMarket;

            //secretary.Notify();

            //#endregion 观察者模式

            //#region 抽象工厂模式

            //Console.WriteLine("*******************************抽象工厂模式*******************************");

            //AbstractFactoryMode.User user = new AbstractFactoryMode.User();

            ////AbstractFactoryMode.IFactory affactory = new AbstractFactoryMode.SqlServerFactory();
            ////AbstractFactoryMode.IUser iu = affactory.CreateUser();
            ////iu.InsertUser(user);
            ////iu.GetUser("");

            //#region IOC注入

            //AbstractFactoryMode.IUser iu = AbstractFactoryMode.DataAccess.CreateUser();
            //iu.InsertUser(user);
            //iu.GetUser("");

            //#endregion IOC注入


            //#endregion 抽象工厂模式

            //#region 状态模式

            ///*
            // * 当一个对象的内在状态改变时允许改变其行为，这个对象看起来像是改变其类。
            // * 
            // * 状态模式主要解决的是当控制一个对象状态转换的条件表达式过于复杂的情况。
            // * 把状态的判断逻辑转移到表示不同的状态的一系列类中，可以把复杂的判断逻辑简化。
            // * 
            // * 把特定的状态相关的行为都放入一个对象中，由于所有与状态相关的代码都存在于某个ConcreteState中，
            // * 所以通过定义新的子类可以很容易地增加新的状态和装换
            // */
            //Console.WriteLine("*******************************状态模式*******************************");

            //Context context = new Context(new ConcreteStateA());

            //context.Request();
            //context.Request();


            //#endregion 状态模式

            //#region 适配器模式

            ///*
            // * 将一个类的接口转换成客户希望的另一个接口。Adapter 模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作。
            // * 
            // */
            //Console.WriteLine("*******************************适配器模式*******************************");

            //Player forwards = new Forwards("麦迪");
            //forwards.Attack();

            //Player guards = new Guards("买买提");
            //guards.Defense();

            //Translator foreignCenter = new Translator("姚明");
            //foreignCenter.Attack();
            //foreignCenter.Defense();


            //#endregion 适配器模式

            //#region 备忘录模式

            ///*
            // * 在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。
            // * 这样以后就可将该对象恢复到原先保存的状态。
            // * 
            // */
            //Console.WriteLine("*******************************备忘录模式*******************************");

            //Originator o = new Originator();
            //o.State = "On";

            //Caretaker c = new Caretaker();
            //c.Memento = o.CreateMemento();

            //o.State = "Off ";
            //o.Show();

            //o.SetMemento(c.Memento);
            //o.Show();

            //#endregion 备忘录模式


            Console.ReadLine();
        }
    }
}
