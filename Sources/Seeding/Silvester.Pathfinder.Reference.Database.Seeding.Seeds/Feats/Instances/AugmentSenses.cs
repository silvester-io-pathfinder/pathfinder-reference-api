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
    public class AugmentSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("358d5253-f1ec-4cdb-9bca-d6199984394d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Augment Senses",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4065172f-55f7-409c-ab59-94989d652766"), Type = TextBlockType.Text, Text = $"You open vestigial eyes, unfurl tympanic flaps of skin, or otherwise enhance your senses. Until the start of your next turn, you gain the following benefits: you can't be flanked; when you {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} for creatures, you can scan a 60-foot cone or a 30-foot burst instead of the normal area; and when you {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} for hidden objects, you can search a 15-foot square instead of the normal area." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2bc84c79-af13-44c8-8805-7332f4e46038"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
