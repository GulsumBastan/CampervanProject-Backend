using CampervanProject_Backend.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampervanProject_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public List<Product> _products;
        public ProductsController()
        {
            _products = new List<Product>
            {
                new Product {Id=1,Name= "Çekme Karavan", CategoryId = 1 ,Description="\r\n\r\nÇekme karavan adından da anlaşılacağı üzere motorlu taşıtlar tarafından çekilerek götürülebilen ve Karavan içinde yaşamak için gerekli ekipmanların barındırıldığı karavan tipidir. Bu tarz karavanlar sadece motorlu araçlar ile çekilebilmekte olup karavan donanımında herhangi bir itici kuvvet olarak motor yoktur.\r\n\r\n En güvenli hız sınırı Çekme karavan için 80 km dir. Aracın arkasında bulunan ağırlık yüksek hızlarda sizin sürüşünüzü etkileyeceği için hız sınırını geçmemeyi dikkat etmeniz gerekmektedir.Çekme karavanlarda özellikle taşıtın ağırlık durumuna göre Vergi ve Ruhsat işlenmektedir. 750 KG altı olan karavanlardan O1 Belgesi ve Çekme karavan satış faturası ile noterden satış yapılabilmektedir. 750 Kg altı karavanlar Vergi ve Muayeneden muaftır.",ImageUrl="assets/cekmekaravan.jpg"},
                new Product {Id=2,Name= "Moto Karavan", CategoryId = 2 , Description="Yaşam alanı ile sürücü mahalinin bir arada olduğu yani aynı araçta olduğu karavanlara motokaravan denilmektedir. Çekme karavanlarda karavanı çekmek için ayrı bir araca ihtiyaç var iken motokaravanda zaten sahip olduğunuz aracın içerisinde yaşamaktasınız. Bu tür karavanlar genellikle minibüs, otobüs ve benzeri araçlardan yapılmaktadır. Motokaravanlar ülkemizde genellikle vergilerden dolayı 5 yaş üstü araçlardan imal edilmektedir. Bu tür karavanlar için genellikle yüksek tavanlı panelvan türü araçlar tercih edilmekle birlikte farklı araç türlerinden de ihtiyaçlara göre farklı ebatlarda ve özelliklerde karavanlar üretilmektedir. Bu tür karavanlara sahip olmak için motokaravan üreten firmalardan kendinize bir karavan yaptırabilirsiniz. Aynı zamanda bu konularda gerekli araştırmaları yaptıktan sonra kendi karavanınızı da üretmeniz mümkün.  ",ImageUrl="assets/motokaravan.jpg"},
                new Product {Id=3,Name= "Minivan Karavan", CategoryId = 3, Description="Minivan arabalar hem ticari hem de binek amaçlı kullanıma uygun araçlar olarak bilinmektedir. Son derece geniş iç hacmi bulunan ve ferah bir tasarıma sahip olan araçların keyifli bir yolculuk yapma imkanı sunduğunu söylemek mümkün olmaktadır.\r\n\r\nMinivan araçlar, uzun yollarda bile rahat ve keyifli bir yolculuk yapılmasına imkan sağlamaktadır. Minibüslerin en küçük ve lüks şekli minivan olarak bilinmektedir. Yüksek verimlilik sunması ve yol tutuş gücünün yüksek olması nedeniyle oldukça fazla tercih edilen araçlar arasında yer almaktadır.\r\n\r\nTercih edilecek olan minivan arabaların özellikleri ise aracın üretildiği firmaya bağlı olarak farklılık gösterebilmektedir. ",ImageUrl="assets/minivankaravan.jpg" },
                new Product {Id=4,Name= "Pick-up Karavan", CategoryId = 4 , Description="Bu zamana kadar pek çok kişi, tatillerini bir karavan ile geçirmeyi düşünmüş, bu hayalle en yakın kamp planının gelmesini iple çekmiştir. Tatilleri çok daha keyifli hale getirmeyi yarayan karavanlar birbirinden farklı modellere sahiptir. Karavan modelleri arasında yer alan pikap karavan, araç arkasına kurulumu mümkün olan model olarak ifade edilir.\r\n\r\nBu sayede pikap karavanı tercih edecek kişinin bu aracı ister otomobil ister yük ya da karavan olarak kullanması sağlanır. Pikap karavanlar için bu noktada çok yönlü araçlar demek mümkündür. Tercih imkanı sunması sebebiyle çok daha kullanışlı olan pikap karavanlar, kamp tutkunlarının her daim imdadına yetişen tarzdadır.",ImageUrl="assets/pick-upkaravan.jpg"},
                new Product {Id=5,Name= "Küçük Gözyaşı Karavan", CategoryId = 5 , Description="Gözyaşı römorkları motor kapasitesi düşük olan araçlar için uygundur. İçinde tuvalet ya da duş gibi yaşamsal üniteler bulunmaz ancak iki kişinin yatmasına olanak sağlayan bir alan vardır.\r\nMini karavanlar genellikle ekonomik bakımdan uygundur bu nedenle çok sık tercih edilir. İçi küçüktür ancak isteğe bağlı bazı ihtiyaçlarınızı minimal ölçülerde sığdırabilirsiniz.",ImageUrl="assets/gozyasıkaravan.jpg"},
                new Product {Id=6,Name= "Panelvan Karavan", CategoryId = 6 , Description="Panelvan içinde yatak, mutfak bulunan küçük araçlara verilen isimdir diyebiliriz. İçinde çok kapsamlı kullanım alanı yoktur. Ancak yatacak yer ve yemek yapmak gibi ihtiyaçları karşılar. Camperlar, kullanım kolaylığı açısından karavana oranla herhangi bir caddede kolaylıkla kullanılabilir ve tipik bir arabaya uygun herhangi bir alana park edilebilirler. Karavan veya çekme karavanlarda ise durum böyle değildir. Büyüklükleri nedeniyle şehir içinde kullanılmaları zor olabildiği gibi park alanı bulmak da kolay olmayabilir. Ancak camper ve karavan karşılaştırmasında dikkat etmeniz gereken unsurlar bununla sınırlı değildir.\r\n\r\nPanelvan dönüşümünde genellikle tuvalet, duş veya banyosu entegre olmayan bir karavan elde edilir. Bu da yoldayken tuvalet ve duş gibi bazı ihtiyaçlarınız için dışa bağımlı olacağınız anlamına gelir. ",ImageUrl="assets/panelvankaravan.jpg"}
            };
        }

        [HttpGet]
        public ActionResult<Product> GetProductByCategoryId(int categoryId)
        {
            return _products.Find(f => f.CategoryId == categoryId);
        }

    }
}