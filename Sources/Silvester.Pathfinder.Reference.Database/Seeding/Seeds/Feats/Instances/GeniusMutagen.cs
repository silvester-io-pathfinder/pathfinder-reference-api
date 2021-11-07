using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GeniusMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("371198ca-3fe1-4a5a-8337-131870c51d4b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Genius Mutagen",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f12cc775-ba09-43f8-aba3-5e0f797d06e7"), Type = TextBlockType.Text, Text = "Specialized tweaks to your formula that supplements your genius considerably broaden the benefits you gain from cognitive mutagens. When you’re affected by a cognitive mutagen, you also gain the mutagen’s item bonus to Deception, Diplomacy, Intimidation, Medicine, Nature, Performance, Religion, and Survival checks. In addition, you can communicate telepathically with creatures within 60 feet with whom you share a language. The communication is two-way once you establish it, so a creature you contact can also communicate with you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("661484a8-d7eb-48bd-b323-bdff82a5aeea"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
