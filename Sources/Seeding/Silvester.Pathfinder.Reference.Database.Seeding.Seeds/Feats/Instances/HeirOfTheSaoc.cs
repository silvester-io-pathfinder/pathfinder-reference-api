using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeirOfTheSaoc : Template
    {
        public static readonly Guid ID = Guid.Parse("0564cb3c-4702-4702-842f-fd6a923c7380");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heir of the Saoc",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b9b25d1d-80c8-40a8-966b-41f43c34c11d"), Type = TextBlockType.Text, Text = $"In the past, you would have been a proud initiate of the Saoc Brethren. Today, you carry on their legacy. When you use {ToMarkdownLink<Models.Entities.Feat>("Saoc Astrology", Feats.Instances.SaocAstrology.ID)}, roll 1d4 instead; on a 1, you take a -1 penalty to the skill check. On any other result, you gain a circumstance bonus of that value (for instance, a +3 circumstance bonus on a 3)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b1692d4d-10e9-4af2-825a-c490726a335d"), Feats.Instances.SaocAstrology.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c501a608-2fe2-4357-8c54-48830be816f1"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
