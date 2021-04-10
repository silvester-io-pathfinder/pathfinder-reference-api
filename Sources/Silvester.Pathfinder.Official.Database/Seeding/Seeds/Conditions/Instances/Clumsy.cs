using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Clumsy : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("740be8e2-cab8-4cbe-8065-fd71a6d2192e");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Clumsy",
                Description = "Your movements become clumsy and inexact. Clumsy always includes a value. You take a status penalty equal to the condition value to Dexterity-based checks and DCs, including AC, Reflex saves, ranged attack rolls, and skill checks using Acrobatics, Stealth, and Thievery.",
                ConditionCategoryId = seeder.GetCategoryByName("Lowered Abilities").Id,
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("b52512cc-bfab-429f-a40d-a0488043a296"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 618
            };
        }
    }
}
