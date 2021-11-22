using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClanProtector : Template
    {
        public static readonly Guid ID = Guid.Parse("993a82ca-f945-4f4b-bad0-836cbb3cb44f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clan Protector",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d92b82c-3401-4a23-b080-549c24f7457e"), Type = TextBlockType.Text, Text = "Your clan dagger can protect your allies as easily as yourself. When you use an (action: Interact) action to gain a circumstance bonus to AC from your (item: clan dagger)'s (trait: parry) trait, you can grant the circumstance bonus to an adjacent ally instead of gaining it yourself. You can use multiple (action: Interact) actions to protect multiple allies, or to protect yourself and an ally. The ally benefits from the bonus to AC only when they are adjacent to you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35c4dde4-be6d-41fa-93f4-f908e35c06bd"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
