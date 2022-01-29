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
    public class Spelunker : Template
    {
        public static readonly Guid ID = Guid.Parse("98007f49-8968-46d9-b503-1ca783196407");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spelunker",
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
            yield return new TextBlock { Id = Guid.Parse("b2113d7e-3d6d-401b-8b26-5bd5c193fb8c"), Type = TextBlockType.Text, Text = $"Living underground, you have learned to find your way without landmarks or even solid ground. If you roll a success on an Survival check to {ToMarkdownLink<Models.Entities.SkillAction>("Sense Direction", SkillActions.Instances.SenseDirection.ID)} or an Athletics check to {ToMarkdownLink<Models.Entities.SkillAction>("Climb", SkillActions.Instances.Climb.ID)}, you get a critical success instead. You're not flat-footed when you attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Climb", SkillActions.Instances.Climb.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("0e630a90-7fa4-43bd-89d3-af19e3cf1eed"), Traits.Instances.Shisk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("427dfb80-0fae-4bf6-9cc6-1472940b18ba"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
