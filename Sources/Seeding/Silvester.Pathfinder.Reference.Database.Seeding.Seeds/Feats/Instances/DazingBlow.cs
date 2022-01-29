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
    public class DazingBlow : Template
    {
        public static readonly Guid ID = Guid.Parse("e7e8b756-fba0-443d-a1ea-93804e521412");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dazing Blow",
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
            yield return new TextBlock { Id = Guid.Parse("6b156ac9-a645-497c-ad08-f2ebe872e7f0"), Type = TextBlockType.Text, Text = $"You pummel a held foe, hoping to stagger them. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a creature you have grabbed. The weapon damage from this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} is bludgeoning damage. If the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits, the creature must attempt a Fortitude save against your class DC; this is an {ToMarkdownLink<Models.Entities.Trait>("incapacitation", Traits.Instances.Incapacitation.ID)} effect." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Press.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("2ca5a6ac-8b54-4967-8928-544519b19474"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is stunned 1.",
                Failure = "The creature is stunned 2.",
                CriticalFailure = "The creature is stunned 3.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1aea2e5-6ac9-4c5b-a747-82eadcfa3404"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
