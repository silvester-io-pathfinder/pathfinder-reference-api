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
    public class LungingSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("2a3415e0-0403-4aff-8c8a-e5b74c87c237");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lunging Spellstrike",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a380f87-24ff-4741-a530-4a3d9215ac38"), Type = TextBlockType.Text, Text = $"Your spell unwinds the structure of your staff to make it exceptionally long, or even separate it into shards held together by magical power. Make a {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)} with a staff, with a spell that isn't a cantrip or focus spell. Increase the staff's reach by 5 feet &#215; the spell's level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7fbc7c62-5698-427d-9786-a7a2d430228b"), Feats.Instances.Spellstrike.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("8123fdc5-d0ca-44f5-b667-d680dcbf390d"), HybridStudies.Instances.TwistingTree.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("31ae63ec-caa8-42d9-b7d7-996770f058e8"), Traits.Instances.Arcane.ID);
            builder.Add(Guid.Parse("dcfbe4df-6f7a-4e0f-a49c-10085d6b10fc"), Traits.Instances.Magus.ID);
            builder.Add(Guid.Parse("8efc9229-0d43-4f22-bd22-6ee7aeebdf5c"), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40bd119d-42d3-49e6-8d36-d8887d1657ce"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
