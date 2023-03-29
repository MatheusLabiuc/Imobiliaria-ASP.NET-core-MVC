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

                if (!context.Vendedores.Any())
                {
                    context.Vendedores.AddRange(new List<Vendedor>()
                    {
                   new Vendedor()
                    {
                        Nome = "Pedro Henrique",
                        Documento = "44.543.123-21",
                        Telefone = "(11) 321223564"
                        
                    },
                  new Vendedor()
                    {

                        Nome = "João Carlos",
                        Documento = "32-431.098-09",
                        Telefone = "(11) 365435876"

                    },
                  new Vendedor()
                    {

                        Nome = "Otavio Parker",
                        Documento = "21-321.098-09",
                        Telefone = "(65) 65435876"

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
                        ImagemURL = "https://cdn.pixabay.com/photo/2018/03/18/15/26/villa-3237114_960_720.jpg",
                        Logradouro = "Rua Fonseca de Abreu",
                        Numero = "231",
                        Complemento = "Casa 3",
                        Cep = "06543-190",
                        Bairro = "Helena Maria",
                        Cidade = "São Paulo",
                        Estado = "SP",
                        Descricao = "Essa é a descrição do primeiro imóvel",
                        Valor = 500432,
                        DataCadastro = DateTime.Now.AddDays(-5),
                        VendedorId = 1


                    },
                  new Imovel()
                    {
                        ImagemURL = "https://cdn.pixabay.com/photo/2016/12/06/14/33/log-cabin-1886620_960_720.jpg",
                        Logradouro = "Rua Circular",
                        Numero = "543",
                        Complemento = "Apto 23",
                        Cep = "08655-901",
                        Bairro = "Conceição",
                        Cidade = "São Paulo",
                        Estado = "SP",
                        Descricao = "Essa é a descrição do segundo imóvel",
                        Valor = 1000000,
                        DataCadastro = DateTime.Now.AddDays(-35),
                        VendedorId = 1
                    },
                  new Imovel()
                    {
                        ImagemURL = "https://cdn.pixabay.com/photo/2018/03/18/15/26/villa-3237114_960_720.jpg",
                        Logradouro = "Rua Da Fonte",
                        Numero = "1232",
                        Complemento = "Casa 231",
                        Cep = "06254-901",
                        Bairro = "Conceição",
                        Cidade = "São Paulo",
                        Estado = "SP",
                        Descricao = "Essa é a descrição do terceiro imóvel",
                        Valor = 1200000,
                        DataCadastro = DateTime.Now.AddDays(-24),
                        VendedorId = 2

                    },
                  new Imovel()
                    {
                        ImagemURL = "https://cdn.pixabay.com/photo/2018/03/18/15/26/villa-3237114_960_720.jpg",
                        Logradouro = "Estrada das Rosas",
                        Numero = "1232",
                        Complemento = "Casa 231",
                        Cep = "06254-901",
                        Bairro = "Conceição",
                        Cidade = "São Paulo",
                        Estado = "SP",
                        Descricao = "Essa é a descrição do terceiro imóvel",
                        Valor = 1200000,
                        DataCadastro = DateTime.Now.AddDays(-24),
                        VendedorId = 3

                    }
                });
                
                   

                    context.SaveChanges();

                };











            }
        }
    }
}
