using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrimalEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("05633514-005e-4900-8c05-45ec931b753d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Primal Evolution",
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
            yield return new TextBlock { Id = Guid.Parse("17b40cc1-a8a9-4db0-8df5-c8a0f78bbfab"), Type = TextBlockType.Text, Text = "You can call upon the creatures of the wild for aid. You gain an additional spell slot of your highest level, which you can use only to cast (spell: summon animal) or (spell: summon plants or fungi | summon plant or fungus). You can cast either of these spells using that spell slot, even if it they aren’t in your spell repertoire." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificBloodlineTradition(Guid.Parse("b73f2264-2fcb-49ce-b01c-71196f311076"), Bloodlines.Instances.Primal.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("317d6cab-5df4-4815-b09c-b6ada3fd0551"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
