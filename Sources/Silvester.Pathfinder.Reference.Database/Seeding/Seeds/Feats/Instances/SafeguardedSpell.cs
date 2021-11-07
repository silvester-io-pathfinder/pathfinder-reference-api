using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SafeguardedSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("210946af-b220-44bc-b185-bb40f366021f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Safeguarded Spell",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b6300c90-437a-423c-aaa4-b8776f262fbe"), Type = TextBlockType.Text, Text = "You bring the magical wavelengths of your spell into sync with the ones produced by your own body. If the next action you take is to (activity: Cast a Spell) with an area, you aren’t affected by the spell even if you are within the area." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56ad1fe9-b2a6-43be-813b-39a258d65286"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
