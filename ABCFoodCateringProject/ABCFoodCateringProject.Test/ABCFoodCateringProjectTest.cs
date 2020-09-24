using ABCFoodCateringProject.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ABCFoodCateringProject.Test
{
    public class ABCFoodCateringProjectTest
    {
        [Fact]
        public void CanChangeFoodTitle()
        {
            // Arrange
            var orderDetail = new Order { FoodDescription = "Sushi", Quantity = 5 };
            // Act
            orderDetail.FoodDescription = "New FoodDescription";
            // Assert
            Assert.Equal("New FoodDescription", orderDetail.FoodDescription);
        }

        [Fact]
        public void CanChangeOrderPrice()
        {
            // Arrange
            var orderDetail = new Order { FoodDescription = "Sushi", Quantity = 30 };
            // Act
            orderDetail.Quantity = 100;
            // Assert
            Assert.Equal(100, orderDetail.Quantity);
        }
    }
}
