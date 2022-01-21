using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NonlethalSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("b32ddc4d-231c-478e-9c7a-c33f4fab9153");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nonlethal Spell",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c0b564de-c35e-4b5b-95dc-55a09e77b84a"), Type = TextBlockType.Text, Text = "You can alter offensive spells to be less deadly. If your next action is to (activity: Cast a Spell) that deals damage and doesn't have the (trait: death) or (trait: negative) trait, that spell gains the (trait: nonlethal) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6bcf11b2-9733-45dd-aeb9-58be5f189ecb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
