using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Unconscious : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("10ef1d07-27bd-4073-96f7-2a55a05a9831");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Unconscious",
                Description = "You're sleeping, or you've been knocked out. You can't act. You take a –4 status penalty to AC, Perception, and Reflex saves, and you have the blinded and flat-footed conditions. When you gain this condition, you fall prone and drop items you are wielding or holding unless the effect states otherwise or the GM determines you're in a position in which you wouldn't.",
                ConditionCategoryId = seeder.GetCategoryByName("Death and Dying").Id,
                OverridesConditionId = Dazzled.ID
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("5486ed38-3692-4186-80e4-1746c21c7130"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 622
            };
        }

        public override IEnumerable<ConditionDetailBlock> GetConditionDetailBlocks()
        {
            yield return new ConditionDetailBlock { Id = Guid.Parse("c6aa5055-28cd-4854-86db-881fab8977e2"), Type = ConditionDetailBlockType.Text, Text = "If you're unconscious because you're dying, you can't wake up while you have 0 Hit Points. If you are restored to 1 Hit Point or more via healing, you lose the dying and unconscious conditions and can act normally on your next turn." };
            yield return new ConditionDetailBlock { Id = Guid.Parse("5be411d3-3892-464b-b651-9ccbea01a9c7"), Type = ConditionDetailBlockType.Text, Text = "If you are unconscious and at 0 Hit Points, but not dying, you naturally return to 1 Hit Point and awaken after sufficient time passes. The GM determines how long you remain unconscious, from a minimum of 10 minutes to several hours. If you receive healing during this time, you lose the unconscious condition and can act normally on your next turn." };
            yield return new ConditionDetailBlock { Id = Guid.Parse("a4f63976-a4f5-402f-88be-f7e5425d1129"), Type = ConditionDetailBlockType.Text, Text = "If you're unconscious and have more than 1 Hit Point (typically because you are asleep or unconscious due to an effect), you wake up in one of the following ways. Each causes you to lose the unconscious condition." };
            yield return new ConditionDetailBlock { Id = Guid.Parse("6f70d006-bd20-422d-ba07-22db1bf4f59f"), Type = ConditionDetailBlockType.Enumeration, Text = "You take damage, provided the damage doesn't reduce you to 0 Hit Points. If the damage reduces you to 0 Hit Points, you remain unconscious and gain the dying condition as normal." };
            yield return new ConditionDetailBlock { Id = Guid.Parse("a84e3630-44d8-4047-b3d9-d21bd140eadf"), Type = ConditionDetailBlockType.Enumeration, Text = "You receive healing, other than the natural healing you get from resting." };
            yield return new ConditionDetailBlock { Id = Guid.Parse("1c0ad848-d2ea-45b4-a709-9d84395bb14d"), Type = ConditionDetailBlockType.Enumeration, Text = "Someone shakes you awake with an Interact action." };
            yield return new ConditionDetailBlock { Id = Guid.Parse("e60b28de-b1af-43af-ba61-daf960327a05"), Type = ConditionDetailBlockType.Enumeration, Text = "There's loud noise going on around you—though this isn't automatic. At the start of your turn, you automatically attempt a Perception check against the noise's DC (or the lowest DC if there is more than one noise), waking up if you succeed. If creatures are attempting to stay quiet around you, this Perception check uses their Stealth DCs. Some magical effects make you sleep so deeply that they don't allow you to attempt this Perception check." };
            yield return new ConditionDetailBlock { Id = Guid.Parse("042a7b29-141c-4489-b084-86796a198da4"), Type = ConditionDetailBlockType.Enumeration, Text = "If you are simply asleep, the GM decides you wake up either because you have had a restful night's sleep or something disrupted that rest." };
        }
    }
}
