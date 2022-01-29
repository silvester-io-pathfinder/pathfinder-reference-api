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
    public class FocusedJuggler : Template
    {
        public static readonly Guid ID = Guid.Parse("ac61d3e9-24fa-4b69-ab61-725e640a606a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Focused Juggler",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn begins.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d48b6e42-6bba-40c5-9766-9b202ce37ae9"), Type = TextBlockType.Text, Text = $"You continue {ToMarkdownLink<Models.Entities.Feat>("Juggling", Feats.Instances.Juggle.ID)} until the end of your next turn. Increase the maximum number of items you can {ToMarkdownLink<Models.Entities.Feat>("Juggle", Feats.Instances.Juggle.ID)} by one." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a2635227-5403-42e9-9487-a9ab752a3192"), Feats.Instances.JugglerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Manipulate.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01b79c1c-229f-471f-90fc-5dcca1682bca"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
