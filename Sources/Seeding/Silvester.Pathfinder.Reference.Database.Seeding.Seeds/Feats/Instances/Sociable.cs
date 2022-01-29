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
    public class Sociable : Template
    {
        public static readonly Guid ID = Guid.Parse("fa286ef7-42d9-4a0e-ad00-bdc9853c6e91");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sociable",
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
            yield return new TextBlock { Id = Guid.Parse("fa741647-715e-4a62-8b4e-f1f32fa58bd9"), Type = TextBlockType.Text, Text = $"You're extremely extroverted, and you often spend your time carousing or otherwise socializing. You are trained in Diplomacy (or another skill of your choice if you were already trained in Diplomacy), and you gain the {ToMarkdownLink<Models.Entities.Feat>("Hobnobber", Feats.Instances.Hobnobber.ID)} skill feat." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a081592e-6cdd-4144-8d6d-9e67e17e7608"), Traits.Instances.HalfElf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("625b1ce1-b2a4-43db-8adb-b35f7aa1dc03"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
