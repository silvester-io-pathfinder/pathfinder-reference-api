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
    public class RollWithIt : Template
    {
        public static readonly Guid ID = Guid.Parse("aa070d7e-f905-47f9-979a-a8a5b44a14d9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Roll With It",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A foe hits you with a melee weapon or unarmed attack.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dadf573c-ab10-48c4-ae6b-c9bbfa518cd8"), Type = TextBlockType.Text, Text = $"When you take a big hit, your foe bounces you around like a rubber ball, but you escape the worst of the blow. Your foe can move you any distance of its choice up to 30 feet in a direction of its choice (this is not forced movement, and it triggers reactions as normal). You fall prone and are stunned 1. Attempt a DC 6 flat check. On a success, you take minimum damage from the attack, and on a critical success, if the attack was a critical hit, you don't take double damage from the critical hit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("ad50b42b-a017-41d1-b4c4-9b1b60be78d6"), Heritages.Instances.UnbreakableGoblin.ID);
            builder.HaveSpecificFeat(Guid.Parse("09d53e4d-8c7b-48e0-bce9-ca5706a61e06"), Feats.Instances.BouncyGoblin.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("ae64d3b6-93a4-4583-ac87-249676391dfa"), Traits.Instances.Goblin.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de678708-1688-466c-b606-3c03e0f76b74"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
