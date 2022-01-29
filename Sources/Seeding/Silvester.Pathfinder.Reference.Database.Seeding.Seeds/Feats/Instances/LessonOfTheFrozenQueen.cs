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
    public class LessonOfTheFrozenQueen : Template
    {
        public static readonly Guid ID = Guid.Parse("a8c0dbe8-231b-43e0-8492-ae3177498aef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesson of the Frozen Queen",
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
            yield return new TextBlock { Id = Guid.Parse("1e9b6f13-d03f-4094-9f6d-5f36ebf265dc"), Type = TextBlockType.Text, Text = $"~ Lesson Type: Major" };
            yield return new TextBlock { Id = Guid.Parse("b856728b-ed37-46f0-a86c-22654af01ba4"), Type = TextBlockType.Text, Text = $"You gain the {ToMarkdownLink<Models.Entities.Spell>("glacial heart", Spells.Instances.GlacialHeart.ID)} hex, and your familiar learns {ToMarkdownLink<Models.Entities.Spell>("wall of ice", Spells.Instances.WallOfIce.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("65ebfc66-d75a-464a-b2af-02a8c19cc175"), Type = TextBlockType.Text, Text = $"A witch with Baba Yaga as a patron can select the lesson of the frozen queen when a feat or other effect grants a major lesson. Other witches who find secret knowledge or magic from Baba Yaga hidden in Irrisen or elsewhere might be able to uncover this rare lesson as well." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a47a13fd-bcc0-44a6-a11c-d5389e540fd1"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
