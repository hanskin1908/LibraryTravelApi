using Core.Services;
using Infrastructure.Data;
using Infrastructure.Interface;
using Infrastructure.Repositories;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestLibraryTravel
{
    public class Libros
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAllLibros()
        {

            Mock<ILibrosRepository> librorepository = new Mock<ILibrosRepository>();
            Mock<LibrosService> propertyrepo = new Mock<LibrosService>();
            Libro prop = new Libro
            {
                Isbn = 1,
                Titulo = "prueba",
                Sinopsis = "avenida",
                NPaginas = "1"

            };

            List<Libro> lstLibros = new List<Libro>();
            IEnumerable<Libro> enumerable = lstLibros;
            LibrosService servicio = new LibrosService(librorepository.Object);
            librorepository.Setup(t => t.GetLibros()).Returns(enumerable);
            var Libro = servicio.GetLibros();
            Assert.IsNotNull(Libro);
        }


        [Test]
        public void GetAllLibrosNull()
        {

            Mock<ILibrosRepository> librorepository = new Mock<ILibrosRepository>();
            Mock<LibrosService> propertyrepo = new Mock<LibrosService>();
            Libro prop = null;

            List<Libro> lstLibros = null;
            IEnumerable<Libro> enumerable = lstLibros;
            LibrosService servicio = new LibrosService(librorepository.Object);
            librorepository.Setup(t => t.GetLibros()).Returns(enumerable);
            var Libro = servicio.GetLibros();
            Assert.IsNull(Libro);
        }


        [Test]
        public void GetAllLibrobyid()
        {

            Mock<ILibrosRepository> librorepository = new Mock<ILibrosRepository>();
            Mock<LibrosService> propertyrepo = new Mock<LibrosService>();
            Libro lib = new Libro
            {
                Isbn = 3,
                Titulo = "prueba",
                Sinopsis = "avenida",
                NPaginas = "1"

            };

           
            LibrosService servicio = new LibrosService(librorepository.Object);
            librorepository.Setup(t => t.GetLibro(3)).Returns(lib);
            var Libro = servicio.GetLibro(3);
            Assert.IsNotNull(Libro);
        }



        [Test]
        public void GetAllLibrobyidnull()
        {

            Mock<ILibrosRepository> librorepository = new Mock<ILibrosRepository>();
            Mock<LibrosService> propertyrepo = new Mock<LibrosService>();
            Libro lib = null;


            LibrosService servicio = new LibrosService(librorepository.Object);
            librorepository.Setup(t => t.GetLibro(1)).Returns(lib);
            var Libro = servicio.GetLibro(1);
            Assert.Null(Libro);
        }

    }
}