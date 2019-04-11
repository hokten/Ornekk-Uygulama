using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class VeritabaniBesle : System.Data.Entity.DropCreateDatabaseAlways<WebApplication8Context> 
    {
        protected override void Seed(WebApplication8Context context)
        {
            Yazar abc = new Yazar
            {
                YazarAdiSoyadi = "Ali Veli",
                YazarDogumTarihi = DateTime.Now,
                YazarEmailAdresi = "ali@veli.com"
            };

            context.Yazars.Add(abc);


            context.Yazars.Add(
                new Yazar
                {
                    YazarAdiSoyadi = "Yaşar KEMAL",
                    YazarDogumTarihi = DateTime.Now,
                    YazarEmailAdresi = "hokten@gmail.com"
                }
                );
            base.Seed(context);
        }

    }
}