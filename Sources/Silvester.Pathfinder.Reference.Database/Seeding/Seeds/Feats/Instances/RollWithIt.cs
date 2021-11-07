using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RollWithIt : Template
    {
        public static readonly Guid ID = Guid.Parse("4ac76a8e-a4cd-4f29-a166-2b34b2f2a80a");

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
            yield return new TextBlock { Id = Guid.Parse("1dc3db74-e9e7-4e84-a7bb-c4c200da90de"), Type = TextBlockType.Text, Text = "When you take a big hit, your foe bounces you around like a rubber ball, but you escape the worst of the blow. Your foe can move you any distance of its choice up to 30 feet in a direction of its choice (this is not forced movement, and it triggers reactions as normal). You fall prone and are stunned 1. Attempt a DC 6 flat check. On a success, you take minimum damage from the attack, and on a critical success, if the attack was a critical hit, you don’t take double damage from the critical hit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("d51b3655-50bc-4411-ab54-7a4090a63e7b"), Heritages.Instances.UnbreakableGoblin.ID);
            builder.HaveSpecificFeat(Guid.Parse("6936a9ee-aa26-4453-959b-1721d7fbda76"), Feats.Instances.BoundyGoblin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19ca9c4a-27b8-486c-939c-4e957eb6292d"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
