using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BondConversion : Template
    {
        public static readonly Guid ID = Guid.Parse("e8774755-58d7-4856-847e-750cf32b8cc2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bond Conversion",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("716ae59c-645f-4599-93ba-b1515629f85d"), Type = TextBlockType.Text, Text = "By carefully manipulating the arcane energies stored in your bonded item as you drain it, you can conserve just enough power to cast another, slightly weaker spell. If the next action you use is to (activity: Cast a Spell) using the energy from (Action: Drain Bonded Item), you gain an extra use of (Action: Drain Bonded Item). You must use this extra use of (Action: Drain Bonded Item) before the end of your next turn or you lose it, and you can use this additional use only to cast a spell 2 or more levels lower than the first spell cast with (Action: Drain Bonded Item)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("ee4762c2-a7c1-4be2-aa2c-5209044736e3"), ClassFeatures.Wizards.ArcaneBond.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20b2704a-afea-4117-8dc0-a02469b62bf1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
