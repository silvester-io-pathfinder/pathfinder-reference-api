using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlignKi : Template
    {
        public static readonly Guid ID = Guid.Parse("77aa5a19-d0cd-409b-82fb-eff124884689");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Align Ki",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You Cast a Spell that has the monk trait.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1f8ee5e5-e095-4568-a3aa-f6a481992f7a"), Type = TextBlockType.Text, Text = "The power of your ki soothes your wounds and energizes you for battle. You regain Hit Points equal to your level plus your Wisdom modifier." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyKiSpells(Guid.Parse("75026628-7b1c-4149-a008-f8d7ce6fcac3"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3405b509-1079-4f9e-a964-c20b00ca1577"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
