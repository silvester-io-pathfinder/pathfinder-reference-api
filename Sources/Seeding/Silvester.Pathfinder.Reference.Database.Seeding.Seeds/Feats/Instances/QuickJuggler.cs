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
    public class QuickJuggler : Template
    {
        public static readonly Guid ID = Guid.Parse("dd24420d-d132-4236-87d9-ecba8b977d08");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Juggler",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1e1f119e-3062-4665-abb1-8a887d7e8654"), Type = TextBlockType.Text, Text = $"When you start to {ToMarkdownLink<Models.Entities.Feat>("Juggle", Feats.Instances.Juggle.ID)} or add another item to those you are {ToMarkdownLink<Models.Entities.Feat>("Juggling", Feats.Instances.Juggle.ID)}, you add two items instead of one. Increase the maximum number of items you can {ToMarkdownLink<Models.Entities.Feat>("Juggle", Feats.Instances.Juggle.ID)} by one." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c21f17cb-2cb0-4be6-8afc-6b8cb79f1096"), Proficiencies.Instances.Expert.ID, Skills.Instances.Performance.ID);
            builder.HaveSpecificFeat(Guid.Parse("2812c568-f86e-4ca0-b3c3-7b7cdf74a818"), Feats.Instances.JugglerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("178126d4-b6e7-4cff-837a-7da3edd9282b"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2fd7b945-e5f3-4523-ba48-c7e29431e3ac"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
