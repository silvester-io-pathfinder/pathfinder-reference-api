using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClanProtector : Template
    {
        public static readonly Guid ID = Guid.Parse("fbe03c13-7eab-42f1-a889-28cb58bac3e3");

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
            yield return new TextBlock { Id = Guid.Parse("bd1b96eb-42ab-4ccb-92bb-ec5488e974fa"), Type = TextBlockType.Text, Text = "Your clan dagger can protect your allies as easily as yourself. When you use an (action: Interact) action to gain a circumstance bonus to AC from your (item: clan dagger)’s (trait: parry) trait, you can grant the circumstance bonus to an adjacent ally instead of gaining it yourself. You can use multiple (action: Interact) actions to protect multiple allies, or to protect yourself and an ally. The ally benefits from the bonus to AC only when they are adjacent to you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a097205-b25b-4b69-acf8-2084bca4bfaf"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
