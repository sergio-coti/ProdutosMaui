using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProdutosApi.Controllers
{
    [Route("api/produtos")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(List<Produto>), 200)]
        public IActionResult GetAll()
        {
            return Ok(ObterProdutos());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(List<Produto>), 200)]
        public IActionResult GetById(string id)
        {
            return Ok(ObterProdutos().Where(p => p.Id == id).FirstOrDefault());
        }

        private List<Produto> ObterProdutos()
        {
            var produtos = new List<Produto>
            {
                new Produto
                {
                    Id = "a984d4ef-fc84-4d14-94a2-d80db6b52242",
                    Nome = "Notebook Lenovo Ideapad",
                    Preco = 3599.99m,
                    Quantidade = 15,
                    Descricao = "Notebook com processador Intel Core i7, 16GB de RAM e SSD de 512GB",
                    Categoria = "Informática",
                    Foto = "produto01.png"
                },
                new Produto
                {
                    Id = "8db02a45-7aaa-4778-ae4b-d66c6b09ac6c",
                    Nome = "Monitor Gamer LG Ultrawide",
                    Preco = 1999.99m,
                    Quantidade = 20,
                    Descricao = "Monitor gamer ultrawide de 34 polegadas, resolução 3440x1440 e taxa de atualização de 144Hz",
                    Categoria = "Informática",
                    Foto = "produto02.png"
                },
                new Produto
                {
                    Id = "b338968d-f9b9-4040-8e0b-c15f150ae74a",
                    Nome = "Teclado Mecânico Corsair K70",
                    Preco = 549.99m,
                    Quantidade = 30,
                    Descricao = "Teclado mecânico com switches Cherry MX, retroiluminação RGB e estrutura em alumínio",
                    Categoria = "Informática",
                    Foto = "produto03.png"
                },
                new Produto
                {
                    Id = "f9d185c4-b36e-4a24-8bf4-459a150f2d7a",
                    Nome = "Mouse Logitech G502 Hero",
                    Preco = 299.99m,
                    Quantidade = 40,
                    Descricao = "Mouse gamer com sensor Hero 25K, 11 botões programáveis e peso ajustável",
                    Categoria = "Informática",
                    Foto = "produto04.png"
                },
                new Produto
                {
                    Id = "1ba4e895-9273-423f-9cf3-b724ef9f1b19",
                    Nome = "SSD Samsung 970 EVO Plus",
                    Preco = 499.99m,
                    Quantidade = 25,
                    Descricao = "SSD NVMe PCIe M.2 de 1TB, velocidade de leitura de até 3500MB/s e escrita de até 3300MB/s",
                    Categoria = "Informática",
                    Foto = "produto05.png"
                },
                new Produto
                {
                    Id = "9852d524-09c1-41dd-a2f4-b3d8b9836670",
                    Nome = "Placa de Vídeo NVIDIA GeForce RTX 3080",
                    Preco = 6999.99m,
                    Quantidade = 10,
                    Descricao = "Placa de vídeo com 10GB de memória GDDR6X, arquitetura Ampere e suporte a Ray Tracing",
                    Categoria = "Informática",
                    Foto = "produto06.png"
                },
                new Produto
                {
                    Id = "cf6e725c-455d-4a93-a0b9-2ab07f20f00f",
                    Nome = "Roteador Wi-Fi TP-Link Archer AX6000",
                    Preco = 999.99m,
                    Quantidade = 20,
                    Descricao = "Roteador Wi-Fi 6 de alta performance com velocidade total de até 6000Mbps",
                    Categoria = "Informática",
                    Foto = "produto07.png"
                },
                new Produto
                {
                    Id = "016164f1-d4b1-47fb-800b-f7a956cafd5a",
                    Nome = "Webcam Logitech C920",
                    Preco = 349.99m,
                    Quantidade = 30,
                    Descricao = "Webcam Full HD 1080p com correção de luz automática e microfone integrado",
                    Categoria = "Informática",
                    Foto = "produto08.png"
                },
                new Produto
                {
                    Id = "61b67c39-96ff-4c52-8abf-28dfba6ac106",
                    Nome = "Fone de Ouvido HyperX Cloud II",
                    Preco = 499.99m,
                    Quantidade = 25,
                    Descricao = "Fone de ouvido com som surround 7.1 virtual, microfone removível e conchas auriculares em couro",
                    Categoria = "Informática",
                    Foto = "produto09.png"
                },
                new Produto
                {
                    Id = "c43893a6-3213-4b1f-96d7-b9043b3f0f08",
                    Nome = "Impressora Multifuncional HP DeskJet 3776",
                    Preco = 399.99m,
                    Quantidade = 15,
                    Descricao = "Impressora multifuncional compacta, imprime, copia e digitaliza, conexão Wi-Fi e compatível com HP ePrint",
                    Categoria = "Informática",
                    Foto = "produto10.png"
                }
            };

            return produtos;
        }
    }

    public class Produto
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string Foto { get; set; }
    }
}
