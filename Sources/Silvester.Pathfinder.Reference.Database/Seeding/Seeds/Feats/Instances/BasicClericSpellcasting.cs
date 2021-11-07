using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicClericSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("e9e410f5-351f-4fcf-88a1-3791a8437d1d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Basic Cleric Spellcasting",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4960ed84-0fac-4b28-a473-10fc367173ac"), Type = TextBlockType.Text, Text = "You gain a 1st-level spell slot. At 6th level, you gain a 2nd-level spell slot. At 8th level, you gain a 3rd-level spell slot. You can prepare your deity’s spells in your spell slots of the appropriate level from the cleric archetype." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9b2eb129-f044-42a5-a4b5-661971f09c24"), Feats.Instances.ClericDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a271619-c834-4652-8720-39c8339f7e53"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
