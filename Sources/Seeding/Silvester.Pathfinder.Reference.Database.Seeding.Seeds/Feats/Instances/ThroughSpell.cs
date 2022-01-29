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
    public class ThroughSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("4beb545d-5eb0-4e5e-959c-6a2a7b10de7c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Through Spell",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("058e1e73-e522-4c1e-b9c5-5ed432b940c3"), Type = TextBlockType.Text, Text = $"Spells you cast can transform briefly into vital essence, traveling harmlessly through living and undead creatures between you and your target, blocked only by solid objects. If the next action you use is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} that requires a spell attack roll, your targets don't benefit from cover provided by living or undead creatures." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("b61dce65-9223-469d-a4b8-ccb4074a897e"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("fa226d8b-015d-457c-862e-b8b398330886"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("a009d4fc-f33d-417b-adb5-78a571e41ca4"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b92b8f0-4640-4e18-a8ec-1b8413522bc9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
