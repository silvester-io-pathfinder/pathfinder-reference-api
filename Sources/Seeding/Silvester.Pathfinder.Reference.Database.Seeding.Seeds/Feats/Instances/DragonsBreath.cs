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
    public class DragonsBreath : Template
    {
        public static readonly Guid ID = Guid.Parse("87c96c4e-1aae-475f-93a8-7cdabfb4cce7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon's Breath",
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
            yield return new TextBlock { Id = Guid.Parse("c40b46bc-9b6c-40dc-9058-04c2e7d9494f"), Type = TextBlockType.Text, Text = $"You can put more effort into your {ToMarkdownLink<Models.Entities.Feat>("Kobold Breath", Feats.Instances.KoboldBreath.ID)} to channel greater draconic power, though it takes more out of you. When you use {ToMarkdownLink<Models.Entities.Feat>("Kobold Breath", Feats.Instances.KoboldBreath.ID)}, you can increase the damage dice to d8s and increase the area to 60 feet for a line breath weapon or 30 feet for a cone. If you do, you can't use {ToMarkdownLink<Models.Entities.Feat>("Kobold Breath", Feats.Instances.KoboldBreath.ID)} again for 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a62d749b-7a40-484d-97b3-7d80d62cfa25"), Feats.Instances.KoboldBreath.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Kobold.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e23b236c-8f91-4218-ac5a-48900322d525"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
