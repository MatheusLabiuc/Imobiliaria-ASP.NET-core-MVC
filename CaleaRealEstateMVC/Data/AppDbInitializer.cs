using CaleaRealEstateMVC.Models;

namespace CaleaRealEstateMVC.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Enderecos.Any())
                {
                    context.Enderecos.AddRange(new List<Endereco>()
                    {
                   new Endereco()
                    {
                        Logradouro = "rua leonor r borges",
                        Numero = "255",
                        Complemento = "casa 2",
                        Cep ="65650-100",
                        Bairro = "helena maria",
                        Cidade = "sao paulo",
                        Estado = "sp"
                    },
                  new Endereco()
                    {
                        Logradouro = "rua leonor das rodas",
                        Numero = "2445",
                        Complemento = "casa 43",
                        Cep ="65320-109",
                        Bairro = "alphaville",
                        Cidade = "sao paulo",
                        Estado = "sp"

                    }
                });

                    context.SaveChanges();

                };

                if (!context.Vendedores.Any())
                {
                    context.Vendedores.AddRange(new List<Vendedor>()
                    {
                   new Vendedor()
                    {
                        Nome = "pedro silva",
                        Documento = "44304034403"
                    },
                  new Vendedor()
                    {

                        Nome = "pedro joseias",
                        Documento = "44444444"
                    }
                });

                    context.SaveChanges();

                };

                if (!context.Imoveis.Any())
                {
                    context.Imoveis.AddRange(new List<Imovel>()
                    {
                  new Imovel()
                    {
                        Descricao = "essa é a descrição do primeiro imovel",
                        ImagemURL = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                        Valor = 1300.3,
                        EnderecoId= 2,
                        VendedorId = 1

                    },
                  new Imovel()
                    {
                        Descricao = "essa é a descrição do segunda imovel",
                        ImagemURL = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                        Valor = 1200.3,
                        EnderecoId= 1,
                        VendedorId = 2

                    }
                });

                    context.SaveChanges();

                };











            }
        }
    }
}
