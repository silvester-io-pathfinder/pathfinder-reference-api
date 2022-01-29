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
    public class UntrainedImprovisation : Template
    {
        public static readonly Guid ID = Guid.Parse("0d110e85-51b0-4426-a8a5-c389b5a11424");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Untrained Improvisation",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c022ba5-e4ad-4b96-a6df-96d83a529842"), Type = TextBlockType.Text, Text = $"You've learned how to handle situations when you're out of your depth. Your proficiency bonus to untrained skill checks is equal to half your level instead of +0. If you're 7th level or higher, the bonus increases to your full level instead. This doesn't allow you to use the skill's trained actions." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f638d536-223a-4944-a911-4940e02758e0"), Traits.Instances.General.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db2179b2-bbb7-4b69-a472-437c3b38bc02"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
