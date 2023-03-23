using Inlamning2_TDD.Interface;
using Moq;
using Inlamning2_TDD.Repository;
using Inlamning2_TDD.Models;

namespace Inlamning2_TDD_Tests.Interfaces
{
    [TestClass]
    public class ProductRepositoryTests
    {
        private ProductRepository _sut;
        private Mock<IProductRepository> _repositoryMock;
        private Mock<ICampaignRepository> _campRepoMock;

        public ProductRepositoryTests()
        {
            _campRepoMock = new Mock<ICampaignRepository> ();
            _repositoryMock = new Mock<IProductRepository>();
            _sut = new ProductRepository();
        }


        [TestMethod]
        public void Adding_Product_Should_Return_TaskComplete()
        {
            //Arrange
            int id = 10;
            ProductModel product = new ProductModel(id, "Banan", 20, 10, 1);

            //Act
            var result = _sut.AddProduct(product);

            //Assert
            Assert.AreEqual(Task.CompletedTask, result);
        }
        [TestMethod]
        public void Get_Product_By_Id_Should_Return_Object()
        {
            //Arrange
            int id = 10;
            ProductModel product = new ProductModel(id, "Banan", 20, 10, 1);
            _sut.AddProduct(product);

            //Act
            var result = _sut.GetProductById(id);

            //Assert
            Assert.AreEqual(product.Id, result.Id);
        }

       

    }
}
