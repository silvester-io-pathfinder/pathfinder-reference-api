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
    public class ModificationAerodynamicConstruction : Template
    {
        public static readonly Guid ID = Guid.Parse("45178594-71f4-412f-8265-61189eb30e85");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Aerodynamic Construction",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("51421ae9-a606-4b0e-b13b-a85ae87d6aad"), Type = TextBlockType.Enumeration, Text = $"*Melee Only**" };
            yield return new TextBlock { Id = Guid.Parse("073d4811-ac90-4dc5-9098-66ee59de7be5"), Type = TextBlockType.Text, Text = $"You carefully engineer the shape of your weapon to maintain its momentum in attacks against successive targets. Your innovation gains the {ToMarkdownLink<Models.Entities.Trait>("sweep", Traits.Instances.Sweep.ID)} trait and the {ToMarkdownLink<Models.Entities.Trait>("versatile S", Traits.Instances.Versatile.ID)} trait." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82507b3c-920b-4d27-985b-34099c062994"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
