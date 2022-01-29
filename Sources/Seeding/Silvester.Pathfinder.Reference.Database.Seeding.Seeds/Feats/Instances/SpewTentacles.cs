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
    public class SpewTentacles : Template
    {
        public static readonly Guid ID = Guid.Parse("1209830b-95b3-458b-93ae-728fc55792d7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spew Tentacles",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("66b04832-ca01-403f-b380-2397bae63931"), Type = TextBlockType.Text, Text = $"You can open your mouth to an immense size and spew forth an impossibly large field of tentacles. You can cast {ToMarkdownLink<Models.Entities.Spell>("black tentacles", Spells.Instances.BlackTentacles.ID)} once per day as an innate occult spell, though when you do so, you spew them from your mouth out to the appropriate range, where they take root and begin {ToMarkdownLink<Models.Entities.SkillAction>("Grappling", SkillActions.Instances.Grapple.ID)} creatures as usual. The tentacles recognize you as a part of them and don't attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Grapple", SkillActions.Instances.Grapple.ID)} you, even if you are in the area." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fleshwarp.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b0aae353-2705-489a-894a-6702241f66af"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
