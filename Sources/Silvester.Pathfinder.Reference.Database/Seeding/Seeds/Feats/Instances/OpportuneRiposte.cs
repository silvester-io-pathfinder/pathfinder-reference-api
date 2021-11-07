using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OpportuneRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("5c31dbfa-43e7-4f61-92f9-43d00dc1068e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Opportune Riposte",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A foe within your reach critically fails a Strike against you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b359ee52-b5d0-4210-b946-3006364fc1c7"), Type = TextBlockType.Text, Text = "You take advantage of an opening from your enemy’s fumbled attack. You either make a melee (action: Strike) against the triggering foe or attempt to (action: Disarm) it of the weapon it used for the (action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f48fafb4-9210-4e33-9e7f-7c9516d4edc7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
