using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Unconscious : Template
    {
        public static readonly Guid ID = Guid.Parse("10ef1d07-27bd-4073-96f7-2a55a05a9831");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Unconscious",
                ConditionCategoryId = ConditionCategories.Instances.DeathAndDying.ID,
                OverridesConditionId = Dazzled.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ccda5475-0435-42f0-aff9-64ed329fc078"), Type = Utilities.Text.TextBlockType.Text, Text = "You’re sleeping, or you’ve been knocked out. You can’t act. You take a –4 status penalty to AC, Perception, and Reflex saves, and you have the blinded and flat-footed conditions. When you gain this condition, you fall prone and drop items you are wielding or holding unless the effect states otherwise or the GM determines you’re in a position in which you wouldn’t." };
            yield return new TextBlock { Id = Guid.Parse("d56e4fd8-c59b-4f88-b3b0-5b3bd29f2f45"), Type = Utilities.Text.TextBlockType.Text, Text = "If you’re unconscious because you’re dying, you can’t wake up while you have 0 Hit Points. If you are restored to 1 Hit Point or more via healing, you lose the dying and unconscious conditions and can act normally on your next turn." };
            yield return new TextBlock { Id = Guid.Parse("be5208b3-bbef-49f9-94b4-3da0a9dbb2df"), Type = Utilities.Text.TextBlockType.Text, Text = "If you are unconscious and at 0 Hit Points, but not dying, you naturally return to 1 Hit Point and awaken after sufficient time passes. The GM determines how long you remain unconscious, from a minimum of 10 minutes to several hours. If you receive healing during this time, you lose the unconscious condition and can act normally on your next turn." };
            yield return new TextBlock { Id = Guid.Parse("96b1a609-4873-422b-9fad-494547fe4387"), Type = Utilities.Text.TextBlockType.Text, Text = "If you’re unconscious and have more than 1 Hit Point (typically because you are asleep or unconscious due to an effect), you wake up in one of the following ways. Each causes you to lose the unconscious condition." };
            yield return new TextBlock { Id = Guid.Parse("6f70d006-bd20-422d-ba07-22db1bf4f59f"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "You take damage, provided the damage doesn't reduce you to 0 Hit Points. If the damage reduces you to 0 Hit Points, you remain unconscious and gain the dying condition as normal." };
            yield return new TextBlock { Id = Guid.Parse("a84e3630-44d8-4047-b3d9-d21bd140eadf"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "You receive healing, other than the natural healing you get from resting." };
            yield return new TextBlock { Id = Guid.Parse("1c0ad848-d2ea-45b4-a709-9d84395bb14d"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Someone shakes you awake with an Interact action." };
            yield return new TextBlock { Id = Guid.Parse("e60b28de-b1af-43af-ba61-daf960327a05"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "There's loud noise going on around you—though this isn't automatic. At the start of your turn, you automatically attempt a Perception check against the noise's DC (or the lowest DC if there is more than one noise), waking up if you succeed. If creatures are attempting to stay quiet around you, this Perception check uses their Stealth DCs. Some magical effects make you sleep so deeply that they don't allow you to attempt this Perception check." };
            yield return new TextBlock { Id = Guid.Parse("042a7b29-141c-4489-b084-86796a198da4"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "If you are simply asleep, the GM decides you wake up either because you have had a restful night's sleep or something disrupted that rest." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5486ed38-3692-4186-80e4-1746c21c7130"),
                SourceId = CoreRulebook.ID,
                Page = 622
            };
        }
    }
}
