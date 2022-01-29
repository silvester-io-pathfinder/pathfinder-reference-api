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
    public class ScalpelsPoint : Template
    {
        public static readonly Guid ID = Guid.Parse("af95c4a9-3fe8-4c7d-82ee-c0b8c510c449");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scalpel's Point",
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
            yield return new TextBlock { Id = Guid.Parse("51c0e21a-709a-49ba-ac07-103497d0603a"), Type = TextBlockType.Text, Text = $"Your stratagems benefit from your precise knowledge of anatomy. When you critically hit with an attack on which you substituted your attack roll due to {ToMarkdownLink<Models.Entities.Feat>("Devising a Stratagem", Feats.Instances.DeviseAStratagem.ID)}, if your attack dealt piercing or slashing damage, you also deal 1d6 persistent bleed damage to your target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMethodology(Guid.Parse("361afa98-e344-4881-bdbb-ecc07451ee7f"), Methodologies.Instances.ForensicMedicine.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Investigator.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0742b17a-7d23-4cfd-83aa-3547ee44118b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
