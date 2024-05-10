using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class Director
    {
        public Character BuildHero(ICharacterBuilder builder)
        {
            return builder.SetHeight(180)
                          .SetBuild("Мускулистий")
                          .SetHairColor("Блонд")
                          .SetEyeColor("Голубий")
                          .SetClothes("Броня")
                          .SetInventory(new List<string> { "Меч", "Щит" })
                          .Build();
        }

        public Character BuildEnemy(ICharacterBuilder builder)
        {
            return builder.SetHeight(195)
                          .SetBuild("Стрункий")
                          .SetHairColor("Чорний")
                          .SetEyeColor("Червоний")
                          .SetClothes("Темна мантія")
                          .SetInventory(new List<string> { "Кинджал", "Отрута" })
                          .Build();
        }
    }
}
