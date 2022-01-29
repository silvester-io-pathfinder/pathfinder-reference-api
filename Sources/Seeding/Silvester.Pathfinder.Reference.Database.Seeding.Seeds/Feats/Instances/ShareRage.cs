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
    public class ShareRage : Template
    {
        public static readonly Guid ID = Guid.Parse("b87c3162-6f3f-4f7b-b791-f9d46e5e693a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Share Rage",
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
            yield return new TextBlock { Id = Guid.Parse("914822b0-fff5-484c-a46b-5a3c89e0654d"), Type = TextBlockType.Text, Text = $"You stoke an ally's fury. While you are raging, one willing creature within 30 feet gains the effects of the {ToMarkdownLink<Models.Entities.Feat>("Rage", Feats.Instances.Rage.ID)} action, except it can still use {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} actions." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("23064831-fbf2-433c-9335-d072a04c211c"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("b5e3dd83-161d-4640-9041-3b65466a8c91"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("89fa39f3-32da-4add-8289-de1837870641"), Traits.Instances.Rage.ID);
            builder.Add(Guid.Parse("118c06ae-c64f-41e1-afcf-e881c304375e"), Traits.Instances.Visual.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("78a5d3f5-744d-4e26-93ca-e521e98b9c53"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
