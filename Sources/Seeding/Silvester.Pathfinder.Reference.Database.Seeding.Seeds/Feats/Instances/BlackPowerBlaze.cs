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
    public class BlackPowerBlaze : Template
    {
        public static readonly Guid ID = Guid.Parse("565212b9-8b5d-403e-8f56-c14040e65643");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Black Power Blaze",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("223c7897-a90d-4a22-8755-810c9232769a"), Type = TextBlockType.Text, Text = $"You learn to take advantage of every shot, flying across the battlefield with the help of your weapon's recoil. {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} and use {ToMarkdownLink<Models.Entities.Feat>("Black Powder Boost", Feats.Instances.BlackPowderBoost.ID)}. Make a ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with the required weapon at any point during the {ToMarkdownLink<Models.Entities.Feat>("Black Powder Boost", Feats.Instances.BlackPowderBoost.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3d8f378d-0d55-4682-9138-4d6f08dd13eb"), Feats.Instances.BlackPowderBoost.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df5fdcdc-db8a-4e93-8458-d6de8f606fb6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
