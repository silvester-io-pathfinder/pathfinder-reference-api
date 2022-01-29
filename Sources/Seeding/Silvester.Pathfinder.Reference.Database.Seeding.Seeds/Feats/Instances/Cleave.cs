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
    public class Cleave : Template
    {
        public static readonly Guid ID = Guid.Parse("3e1e6932-654f-4357-afe9-cfe7af08db05");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cleave",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your melee Strike kills a creature or knocks it unconscious, and another foe is adjacent to that creature.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("75900be9-29ac-4b67-b051-321495078121"), Type = TextBlockType.Text, Text = $"You swing clear through one foe and into another. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the second foe." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("74516882-5d8f-4b11-a9db-b2b4f2a93551"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("cbc27fc8-a9d2-4414-a638-e13c67b74de1"), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61d45ed4-99e4-4758-9794-4e025b48e96a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
