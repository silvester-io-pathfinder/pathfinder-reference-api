using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Dead : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("3c3ce9f5-aceb-4db8-810a-1291035cf709");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Dead",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("24e658a1-86a6-40da-86a3-6f67b13d4598"), Type = Utilities.Text.TextBlockType.Text, Text = "After you die, you can’t act or be affected by spells that target creatures (unless they specifically target dead creatures), and for all other purposes you are an object. When you die, you are reduced to 0 Hit Points if you had a different amount, and you can’t be brought above 0 Hit Points as long as you remain dead. Some magic can bring creatures back to life, such as the resurrect ritual or the raise dead spell." };
            yield return new TextBlock { Id = Guid.Parse("a1b5f2c5-4799-468a-a3aa-7742b80487d5"), Type = Utilities.Text.TextBlockType.Footnote, Text = "This is not an official status condition, but a pf2e.io liberty to smooth out some of the inconsistencies in the rulesbooks." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage 
            {
                Id = Guid.Parse("162fb61e-213f-4fa8-bfa8-36e3ec271847"),
                SourceId = CoreRulebook.ID,
                Page = 461
            };
        }
    }
}
