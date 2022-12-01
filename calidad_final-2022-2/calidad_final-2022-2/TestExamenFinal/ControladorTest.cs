using Calidad20222.web.Controllers;
using Calidad20222.web.Helper;
using Calidad20222.web.Models;
using Calidad20222.web.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExamenFinal
{
    public class ControladorTest
    {
        PokerService pokerService;

        //Testing para carta Mayor
        [Test]
        public void CartaMayorTest01()
        {
            List<Carta> lista = new List<Carta>() { 
                new Carta{
                    Numero=10,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=13,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=1,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=9,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=4,
                    Palo ="COCO"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("CARTA MAYOR",result);
        }

        [Test]
        public void CartaMayorTest01_1()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=3,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=1,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=10,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=9,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=5,
                    Palo ="COCO"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("CARTA MAYOR", result);
        }


        //Testing para carta doble

        [Test]
        public void CartaDobleTest02()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=13,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=13,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=2,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=6,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=8,
                    Palo ="COCO"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("DOBLE", result);
        }

        [Test]
        public void CartaDobleTest02_1()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=2,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=13,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=2,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=12,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=8,
                    Palo ="COCO"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("DOBLE", result);
        }


        //Testing para carta doble

        [Test]
        public void CartaDobleParejaTest03()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=4,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=4,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=8,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=8,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=1,
                    Palo ="COCO"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("DOBLE PAREJA", result);
        }

        [Test]
        public void CartaDobleParejaTest03_1()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=1,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=1,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=13,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=8,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=13,
                    Palo ="COCO"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("DOBLE PAREJA", result);
        }


        //Testing para carta TRIO

        [Test]
        public void CartaTrioTest04()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=13,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=13,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=13,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=8,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=1,
                    Palo ="CORAZON"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("TRIO", result);
        }

        [Test]
        public void CartaTrioTest04_1()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=2,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=2,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=13,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=8,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=2,
                    Palo ="CORAZON"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("TRIO", result);
        }


        //Testing para carta Escalera

        [Test]
        public void CartaEscaleraTest05()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=3,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=4,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=5,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=6,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=7,
                    Palo ="CORAZON"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA", result);
        }


        [Test]
        public void CartaEscaleraTest05_1()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=8,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=9,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=10,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=11,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=12,
                    Palo ="CORAZON"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA", result);
        }


        //Testing para carta Color
        [Test]
        public void CartaColorTest06()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=13,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=4,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=2,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=6,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=1,
                    Palo ="CORAZON"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("COLOR", result);
        }

        [Test]
        public void CartaColorTest06_1()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=5,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=2,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=1,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=6,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=10,
                    Palo ="TREBOL"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("COLOR", result);
        }


        //Testing para carta Full
        [Test]
        public void CartaFullTest07()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=1,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=1,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=1,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=6,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=6,
                    Palo ="COCO"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("FULL", result);
        }

        [Test]
        public void CartaFullTest07_1()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=5,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=5,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=13,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=13,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=13,
                    Palo ="COCO"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("FULL", result);
        }



        //Testing para carta POKER

        [Test]
        public void CartaPokerTest08()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=2,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=2,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=2,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=2,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=6,
                    Palo ="COCO"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("POKER", result);
        }

        [Test]
        public void CartaPokerTest08_1()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=2,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=6,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=6,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=6,
                    Palo ="TREBOL"
                },
                new Carta{
                    Numero=6,
                    Palo ="COCO"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("POKER", result);
        }



        //Testing para carta EscaleraColor
        [Test]
        public void CartaEscaleraColorTest09()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=7,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=8,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=9,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=10,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=11,
                    Palo ="ESPADA"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA DE COLOR", result);
        }

        [Test]
        public void CartaEscaleraColorTest09_1()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=3,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=4,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=5,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=6,
                    Palo ="COCO"
                },
                new Carta{
                    Numero=7,
                    Palo ="COCO"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA DE COLOR", result);
        }


        //Testing para carta EscaleraReal

        [Test]
        public void CartaEscaleraRealTest10()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=1,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=13,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=12,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=11,
                    Palo ="ESPADA"
                },
                new Carta{
                    Numero=10,
                    Palo ="ESPADA"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA REAL", result);
        }


        [Test]
        public void CartaEscaleraRealTest10_1()
        {
            List<Carta> lista = new List<Carta>() {
                new Carta{
                    Numero=1,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=13,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=12,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=11,
                    Palo ="CORAZON"
                },
                new Carta{
                    Numero=10,
                    Palo ="CORAZON"
                },
            };
            pokerService = new PokerService();
            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA REAL", result);
        }






    }
}
