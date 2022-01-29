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
    public class SpiritsInterference : Template
    {
        public static readonly Guid ID = Guid.Parse("33a9057b-4702-42e4-a63e-4778f6236a7e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spirits' Interference",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("016fbe82-877c-4ad2-b409-d14d515c479c"), Type = TextBlockType.Text, Text = $"You call forth protective spirits to ward off ranged attacks. Until your rage ends, anyone making a ranged attack against you must succeed at a DC 5 flat check or the attack misses with no effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("124cda9c-b62b-4c32-9aa4-80250d8bbef7"), Instincts.Instances.SpiritInstinct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("eda6d58e-8960-480d-887d-d81cb482ef34"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("8c7add04-f307-4bea-bc11-3f5bd3bd373f"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("6e55defc-82eb-4c07-b8ae-238b2d9df506"), Traits.Instances.Instinct.ID);
            builder.Add(Guid.Parse("79223967-9a82-483f-a566-527def4e065f"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("1d545475-57c0-45c2-98f7-48db62b1a8b9"), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47a90793-3782-4bd9-9866-5e0eb5884d80"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
