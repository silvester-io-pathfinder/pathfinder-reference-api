using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PortentousSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("61aea4ea-9efc-45ad-98b5-57fa11f4433d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Portentous Spell",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a53ea48d-7ad6-4ce5-82f4-0271e3d72a7c"), Type = TextBlockType.Text, Text = "Your spellcasting is rife with strange lights, esoteric gestures, and other captivating effects that befuddle your foes. If the next action you use is to (activity: Cast a Spell), any creature that attempts to use a reaction triggered by your (activity: Cast a Spell) activity takes a -2 circumstance penalty to attack rolls and skill checks rolled as part of the reaction. In addition, if the spell includes a spell attack roll or requires a saving throw, creatures you hit or that fail their saves are fascinated with you until the start of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3ce4d3e-c088-45bc-8547-bbe220aff257"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
