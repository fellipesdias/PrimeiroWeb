using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Moq;
using primeiroweb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebAPI.Controllers;
using Xunit;

namespace PWebTest
{
    public class CategoriasControllerTest
    {
        private readonly Mock<DbSet<categoria>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly categoria _categoria;
        public CategoriasControllerTest()
        {
            _mockSet = new Mock<DbSet<categoria>>();
            _mockContext = new Mock<Context>();
            _categoria = new categoria { Id = 1, Descricao = "Teste Categoria" };

            _mockContext.Setup(m => m.Categorias).Returns(_mockSet.Object);
            _mockContext.Setup(expression: m => m.Categorias.FindAsync(1))
              .ReturnsAsync(_categoria);

        }
        [Fact]

        public async Task Get_Categoria()
        {
            var service = new categoriasController(_mockContext.Object);

            await service.Getcategoria(1);

            _mockSet.Verify(expression: m => m.FindAsync(1),
                Times.Once());

        }

    }
}
