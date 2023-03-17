using Inlamning2_TDD.Interface;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inlamning2_TDD.Repository;
using Inlamning2_TDD.Models;

namespace Inlamning2_TDD_Tests.Interfaces
{
    [TestClass]
    public class IProductRepositoryTests
    {
        private productRepository _sut;
        private Mock<IProductRepository> _repository;
        private Mock<ICampaignRepository> _campRepo;

        public IProductRepositoryTests()
        {
            _campRepo = new Mock<ICampaignRepository> ();
            _repository = new Mock<IProductRepository>();
            _sut = new productRepository();
        }


        [TestMethod]
        public void IProductRepository_AddProduct()
        {
            //Arrange
            int id = 1;
            string filePath = "hejsan.txt";
            ProductModel product = new ProductModel(_campRepo.Object, id, "Banan", 20, 10, 10);

            //Act
            var result = _sut.AddProduct(filePath, product);

            //Assert
            Assert.AreEqual(Task.CompletedTask, result);
        }

    }
}
