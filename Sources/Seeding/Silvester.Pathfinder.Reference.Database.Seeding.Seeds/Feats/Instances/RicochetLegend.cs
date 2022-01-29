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
    public class RicochetLegend : Template
    {
        public static readonly Guid ID = Guid.Parse("a80f22a8-028e-4ef4-8a52-430a77e6e6a5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ricochet Legend",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f0f30b4e-6ed7-4475-8296-1899fb14410b"), Type = TextBlockType.Text, Text = $"The more obstacles between you and your target, the deadlier your shots become, as you ricochet off multiple surfaces to hit them. When using {ToMarkdownLink<Models.Entities.Feat>("Ricochet Shot", Feats.Instances.RicochetShot.ID)}, your shot can bounce off of any surface within your weapon's first three range increments and the target can't benefit from cover unless they have total cover on all sides." };
            yield return new TextBlock { Id = Guid.Parse("130ce8ac-3bb6-4e3f-99ed-3cdb9e51cdde"), Type = TextBlockType.Text, Text = $"In addition, a creature must attempt a Will save against your class DC the first time in an encounter you attack it with a {ToMarkdownLink<Models.Entities.Feat>("Ricochet Shot", Feats.Instances.RicochetShot.ID)}. If it fails, it's stunned 2 and is unable to determine where your shot originated." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c774d08d-193a-448d-bf5b-48ea0d3b1b78"), Feats.Instances.RicochetMaster.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("329fc522-2dca-4020-b335-f7291db2a5c6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
