using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpiritsWrath : Template
    {
        public static readonly Guid ID = Guid.Parse("fdcb4bbd-6533-499e-957c-0f68988e371c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spirit's Wrath",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("007f60fa-732a-49c5-9824-4615ad327688"), Type = TextBlockType.Text, Text = "You call forth an ephemeral apparition, typically the ghost of an ancestor or a nature spirit, which takes the form of a wisp. The spirit wisp makes a melee wisp rush unarmed attack against an enemy within 120 feet of you. The wisp’s attack modifier is equal to your proficiency bonus for martial weapons plus your Strength modifier plus a +2 item bonus, and it applies the same circumstance and status bonuses and penalties that you have. On a hit, the wisp deals damage equal to 4d8 plus your Constitution modifier. The damage is your choice of negative or positive damage; don’t apply your (feat: Rage) damage or your weapon specialization damage, but circumstance and status bonuses and penalties that would also affect the wisp’s damage apply. If your wisp’s (action: Strike) is a critical hit, the target becomes frightened 1. This attack uses and counts toward your multiple attack penalty as if you were the one attacking." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("131bbd29-c943-4ac0-93ac-55c270715985"), Instincts.Instances.SpiritInstinct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4260f7c5-f023-4b73-92a4-c1ed1e6cdd00"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
