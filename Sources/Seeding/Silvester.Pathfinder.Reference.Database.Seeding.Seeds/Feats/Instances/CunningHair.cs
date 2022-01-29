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
    public class CunningHair : Template
    {
        public static readonly Guid ID = Guid.Parse("d87f139f-bfc2-4a91-a283-6f995f328f87");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cunning Hair",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f774909f-30f1-487b-86a1-c5afa9a93703"), Type = TextBlockType.Text, Text = $"Your hair moves under your control. You can perform simple {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} actions with your hair, such as opening an unlocked door. Your hair can't perform actions that require fingers or significant manual dexterity, including any action that would require a check to accomplish, and you can't use it to hold items." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Changeling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a003dcd6-a012-49c8-81e0-ea58efa187d0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
