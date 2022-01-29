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
    public class WardCasting : Template
    {
        public static readonly Guid ID = Guid.Parse("a8d86a5b-11a0-485b-a7b9-07a48891f64a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ward Casting",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a flat check for Steady Spellcasting, but you haven't rolled yet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ece5b7b4-197f-42b9-8de1-9ae47d37233a"), Type = TextBlockType.Text, Text = $"You carefully ward your spell by drawing from a mantle of magical energy you prepared to protect your casting, increasing your chance of retaining the spell. You reduce the DC of the flat check for {ToMarkdownLink<Models.Entities.Feat>("Steady Spellcasting", Feats.Instances.SteadySpellcasting.ID)} from 15 to 10." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c0a486b4-be82-492d-99de-46f2e4520b83"), Feats.Instances.SpellmasterDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("66792c9a-eeff-46f3-bde9-c3530ecbc8f2"), Feats.Instances.SteadySpellcasting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f80308eb-a53e-425d-b3b7-99ccdbbbdb33"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
