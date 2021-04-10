using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Confused : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("b9c63a02-449e-43c2-a236-5a3f851f766f");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Confused",
                Description = "You don't have your wits about you, and you attack wildly. You are flat-footed, you don't treat anyone as your ally (though they might still treat you as theirs), and you can't Delay, Ready, or use reactions.  You use all your actions to Strike or cast offensive cantrips, though the GM can have you use other actions to facilitate attack, such as draw a weapon, move so that a target is in reach, and so forth. Your targets are determined randomly by the GM. If you have no other viable targets, you target yourself, automatically hitting but not scoring a critical hit. If it's impossible for you to attack or cast spells, you babble incoherently, wasting your actions.  Each time you take damage from an attack or spell, you can attempt a DC 11 flat check to recover from your confusion and end the condition."
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d685714-66ec-4b52-bb2c-d105f158ae61"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 618
            };
        }
    }
}
