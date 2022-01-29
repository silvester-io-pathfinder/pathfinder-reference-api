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
    public class CrystallineCloud : Template
    {
        public static readonly Guid ID = Guid.Parse("d8b56044-65a0-45ac-8499-b0bdb5a599fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crystalline Cloud",
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
            yield return new TextBlock { Id = Guid.Parse("dedafec5-3cc3-4644-8e92-bafe99205ff2"), Type = TextBlockType.Text, Text = $"When you use {ToMarkdownLink<Models.Entities.Feat>("Crystalline Dust", Feats.Instances.CrystallineDust.ID)}, you can spend one additional action to disperse the motes as a 10-foot-radius cloud centered on you instead of as haze; the activity gains the {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} trait. All creatures within the cloud become concealed, and all creatures outside the cloud become concealed to creatures within it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6fcb87bb-cc66-4190-86c2-d900137f83f6"), Feats.Instances.CrystallineDust.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fd7e2fbe-d74f-4e0b-a7ad-018d3a67f194"), Traits.Instances.Aphorite.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f20afa47-e82a-481e-ad78-b0f82af3fed4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
