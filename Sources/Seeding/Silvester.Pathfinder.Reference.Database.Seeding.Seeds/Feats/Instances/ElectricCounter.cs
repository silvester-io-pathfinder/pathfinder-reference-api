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
    public class ElectricCounter : Template
    {
        public static readonly Guid ID = Guid.Parse("923abfe7-ed72-4cf6-bf08-3c91a5f1b8f2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Electric Counter",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait corresponding to the tradition of ki spells you cast, either divine or occult.",
                Trigger = "You would take damage.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8cf4f37b-090b-44dd-9bee-850690a52149"), Type = TextBlockType.Text, Text = $"You gain resistance to electricity equal to your level until the start of your next turn. If the triggering damage was electricity, this resistance applies to it. If the triggering damage was from a melee attack, the attacker takes 3d6 electricity damage." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("5178366b-5016-478f-8fd1-c58ff3320441"), Traits.Instances.Electricity.ID);
            builder.Add(Guid.Parse("68aaac87-ba40-4c66-9572-1df33e9f34de"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("63fdf72e-80ab-4d0b-bb1f-6ddaa6f3e4a6"), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("46daa3e4-e02b-4f75-a0eb-4a8b5fd805cd"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
