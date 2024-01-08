using System.Reflection;

namespace Vsite.CSharp.DogađajiDelegati.Testovi
{
    [TestClass]
    public class DefiniranjaDogađaja
    {
        class Slušatelj
        {
            public void ObradaDogađaja(object sender, AlarmEventArgs a)
            {
                GeneratorAlarma? ga = sender as GeneratorAlarma;
                if (ga != null)
                    DogađajSeDogodio = true;

                Type t = a.GetType();
                if (t.Name == "AlarmEventArgs")
                {
                    var fields = t.GetFields();
                    var v = fields.FirstOrDefault(p => string.Compare(p.Name, "Vrijeme", true) == 0);
                    if (v != null)
                        Vrijeme = (DateTime?)v.GetValue(a);
                    var m = fields.FirstOrDefault(p => string.Compare(p.Name, "Mjesto", true) == 0);
                    if (m != null)
                        Mjesto = (string?)m.GetValue(a);
                    var r = fields.FirstOrDefault(p => string.Compare(p.Name, "Razina", true) == 0);
                    if (r != null)
                        Razina = (int?)r.GetValue(a);
                    var o = fields.FirstOrDefault(p => string.Compare(p.Name, "Opis", true) == 0);
                    if (o != null)
                        Opis = (string?)o.GetValue(a);
                }
            }

            public bool DogađajSeDogodio { get; private set; }

            public DateTime? Vrijeme { get; private set; }
            public string? Mjesto { get; private set; }
            public int? Razina { get; private set; }
            public string? Opis { get; private set; }
        }

        [TestMethod]
        public void PozivMetodeDižiAlarmObavještavaPredbilježeneSlušateljeODogađaju()
        {
            Assert.IsTrue(typeof(GeneratorAlarma).GetEvent("Alarm") != null);

            GeneratorAlarma generatorAlarma = new GeneratorAlarma();
            Slušatelj slušatelj = new Slušatelj();

            EventInfo? eInfo = generatorAlarma.GetType().GetEvent("Alarm");
            Assert.IsNotNull(eInfo);
            if (eInfo == null)
                return;

            Type? handlerType = eInfo.EventHandlerType;
            Assert.IsNotNull(handlerType);
            Delegate del = Delegate.CreateDelegate(handlerType, slušatelj, "ObradaDogađaja", false);
            eInfo.AddEventHandler(generatorAlarma, del);

            Assert.IsFalse(slušatelj.DogađajSeDogodio);

            generatorAlarma.DižiAlarm("mjesto", 3, "potres");

            Assert.IsTrue(slušatelj.DogađajSeDogodio);
        }

        [TestMethod]
        public void PozivMetodeDižiAlarmProsljeđujePredbilježenimSlušateljimaVrijemeAlarma()
        {
            Assert.IsTrue(typeof(GeneratorAlarma).GetEvent("Alarm") != null);

            GeneratorAlarma generatorAlarma = new GeneratorAlarma();
            Slušatelj slušatelj = new Slušatelj();

            EventInfo? eInfo = generatorAlarma.GetType().GetEvent("Alarm");
            Assert.IsNotNull(eInfo);
            if (eInfo == null)
                return;

            Type? handlerType = eInfo.EventHandlerType;
            Assert.IsNotNull(handlerType);
            Delegate del = Delegate.CreateDelegate(handlerType, slušatelj, "ObradaDogađaja", false);
            eInfo.AddEventHandler(generatorAlarma, del);

            DateTime trenutakPrije = DateTime.Now;

            generatorAlarma.DižiAlarm("mjesto", 3, "potres");

            Assert.IsTrue(slušatelj.Vrijeme >= trenutakPrije && slušatelj.Vrijeme <= DateTime.Now);
        }

        [TestMethod]
        public void PozivMetodeDižiAlarmProsljeđujePredbilježenimSlušateljimaMjestoAlarma()
        {
            Assert.IsTrue(typeof(GeneratorAlarma).GetEvent("Alarm") != null);

            GeneratorAlarma generatorAlarma = new GeneratorAlarma();
            Slušatelj slušatelj = new Slušatelj();

            EventInfo? eInfo = generatorAlarma.GetType().GetEvent("Alarm");
            Assert.IsNotNull(eInfo);
            if (eInfo == null)
                return;

            Type? handlerType = eInfo.EventHandlerType;
            Assert.IsNotNull(handlerType);
            Delegate del = Delegate.CreateDelegate(handlerType, slušatelj, "ObradaDogađaja", false);
            eInfo.AddEventHandler(generatorAlarma, del);

            generatorAlarma.DižiAlarm("mjesto", 3, "potres");

            Assert.AreEqual("mjesto", slušatelj.Mjesto);
        }

        [TestMethod]
        public void PozivMetodeDižiAlarmProsljeđujePredbilježenimSlušateljimaRazinuAlarma()
        {
            Assert.IsTrue(typeof(GeneratorAlarma).GetEvent("Alarm") != null);

            GeneratorAlarma generatorAlarma = new GeneratorAlarma();
            Slušatelj slušatelj = new Slušatelj();

            EventInfo? eInfo = generatorAlarma.GetType().GetEvent("Alarm");
            Assert.IsNotNull(eInfo);
            if (eInfo == null)
                return;

            Type? handlerType = eInfo.EventHandlerType;
            Assert.IsNotNull(handlerType);
            Delegate del = Delegate.CreateDelegate(handlerType, slušatelj, "ObradaDogađaja", false);
            eInfo.AddEventHandler(generatorAlarma, del);

            generatorAlarma.DižiAlarm("mjesto", 3, "potres");

            Assert.AreEqual(3, slušatelj.Razina);
        }

        [TestMethod]
        public void PozivMetodeDižiAlarmProsljeđujePredbilježenimSlušateljimaOpisAlarma()
        {
            Assert.IsTrue(typeof(GeneratorAlarma).GetEvent("Alarm") != null);

            GeneratorAlarma generatorAlarma = new GeneratorAlarma();
            Slušatelj slušatelj = new Slušatelj();

            EventInfo? eInfo = generatorAlarma.GetType().GetEvent("Alarm");
            Assert.IsNotNull(eInfo);
            if (eInfo == null)
                return;

            Type? handlerType = eInfo.EventHandlerType;
            Assert.IsNotNull(handlerType);
            Delegate del = Delegate.CreateDelegate(handlerType, slušatelj, "ObradaDogađaja", false);
            eInfo.AddEventHandler(generatorAlarma, del);

            generatorAlarma.DižiAlarm("mjesto", 3, "potres");

            Assert.AreEqual("potres", slušatelj.Opis);
        }
    }
}
