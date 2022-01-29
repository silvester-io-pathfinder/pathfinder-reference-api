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
    public class SlagMay : Template
    {
        public static readonly Guid ID = Guid.Parse("6eb10a53-93c3-41e4-83c3-74f83dedeca7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slag May",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("54de3612-a0c2-4dde-89be-ce99f32ded20"), Type = TextBlockType.Text, Text = $"Your mother was an annis hag, known for physical prowess, and you have one violet or steel-gray eye. You have thick, sturdy claws made of cold iron that grow naturally from your body. You gain a claw unarmed attack that deals 1d6 slashing damage. Your claws are in the brawling group, have the {ToMarkdownLink<Models.Entities.Trait>("unarmed", Traits.Instances.Unarmed.ID)} and {ToMarkdownLink<Models.Entities.Trait>("grapple", Traits.Instances.Grapple.ID)} traits, and are cold iron." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("38723657-afc1-4754-9bd6-24a52286419c"), Traits.Instances.Changeling.ID);
            builder.Add(Guid.Parse("9314ef8e-a86b-406e-af4c-30be04d8d872"), Traits.Instances.Lineage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d34d24d8-0c96-4046-aabc-490d0ae3935d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
