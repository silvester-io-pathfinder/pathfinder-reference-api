using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FeyCaller : Template
    {
        public static readonly Guid ID = Guid.Parse("7db9dc75-859b-45b2-9886-9a62bbfd90f9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fey Caller",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e383c924-fd8e-4647-92d0-18c028a83967"), Type = TextBlockType.Text, Text = "You have learned some of the tricks the fey use to bend primal magic toward illusions and trickery. Add (Spell: illusory disguise), (Spell: illusory object), (Spell: illusory scene), and (Spell: veil) to your spell list as primal spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a208d18b-8695-4221-8f8b-9e32abce49eb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
