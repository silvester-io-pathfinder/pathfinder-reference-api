using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PreemptiveReconfiguration : Template
    {
        public static readonly Guid ID = Guid.Parse("d9296f5d-4e68-4f0c-b136-6da8db88e626");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Preemptive Reconfiguration",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would take bludgeoning, piercing, or slashing damage.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7d3e29d7-9093-4c5b-bd1c-0d5aa252d903"), Type = TextBlockType.Text, Text = "Your body anticipates the blow. The impact area briefly reorganizes into a strengthened tissue lattice that blunts the attack. You gain resistance equal to your level to the triggering damage type, which applies against the triggering damage." };
            yield return new TextBlock { Id = Guid.Parse("fae0fbb6-3461-4727-91af-a6d99279e270"), Type = TextBlockType.Text, Text = "If you have the (feat: Crystalline Dust) feat, you can use Preemptive Reconfiguration without expending a usage of the reaction for the purpose of the feat's Frequency limit. Instead, the usage counts toward your number of (feat: Crystalline Dust) uses per day, as if you had used that feat instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f81825f6-3c74-4bc4-9092-19f403075608"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
