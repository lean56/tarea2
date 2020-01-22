using Microsoft.VisualStudio.TestTools.UnitTesting;
using TareaGenero.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using TareaGenero.Entidades;

namespace TareaGenero.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Genero> db = new RepositorioBase<Genero>();


            Genero genero = new Genero()
            {
                Nombre ="Drama"
            };
            Assert.IsTrue(db.Guardar(genero));
        }
        [TestMethod()]
        public void GuardarTest2()
        {
            RepositorioBase<Genero> db = new RepositorioBase<Genero>();


            Genero genero = new Genero()
            {
                Nombre = "Comedia"
            };
            Assert.IsTrue(db.Guardar(genero));
        }

    }
}