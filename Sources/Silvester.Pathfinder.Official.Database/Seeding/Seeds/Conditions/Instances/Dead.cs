using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Dead : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("3c3ce9f5-aceb-4db8-810a-1291035cf709");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Dead",
                Description = "After you die, you can’t act or be affected by spells that target creatures (unless they specifically target dead creatures), and for all other purposes you are an object. When you die, you are reduced to 0 Hit Points if you had a different amount, and you can’t be brought above 0 Hit Points as long as you remain dead. Some magic can bring creatures back to life, such as the resurrect ritual or the raise dead spell",
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage 
            {
                Id = Guid.Parse("162fb61e-213f-4fa8-bfa8-36e3ec271847"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 461
            };
        }
    }
}
