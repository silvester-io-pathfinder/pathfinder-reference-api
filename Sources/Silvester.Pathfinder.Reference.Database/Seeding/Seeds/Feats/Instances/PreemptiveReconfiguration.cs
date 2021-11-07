using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PreemptiveReconfiguration : Template
    {
        public static readonly Guid ID = Guid.Parse("f6b73922-8161-4e49-b0e2-d80b4d4cbcea");

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
            yield return new TextBlock { Id = Guid.Parse("f59ec484-c967-4d87-ba74-818200897c2a"), Type = TextBlockType.Text, Text = "Your body anticipates the blow. The impact area briefly reorganizes into a strengthened tissue lattice that blunts the attack. You gain resistance equal to your level to the triggering damage type, which applies against the triggering damage." };
            yield return new TextBlock { Id = Guid.Parse("285a806b-2d98-4d84-b462-ac4a0e3990f6"), Type = TextBlockType.Text, Text = "If you have the (feat: Crystalline Dust) feat, you can use Preemptive Reconfiguration without expending a usage of the reaction for the purpose of the feat’s Frequency limit. Instead, the usage counts toward your number of (feat: Crystalline Dust) uses per day, as if you had used that feat instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f86f2ad-27e3-46d8-b29a-9e7e482063b9"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
