using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MelodiousSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("33bea17f-8a06-470d-b806-d502a4eba601");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Melodious Spell",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f0f33ee-84b5-45cf-b1d4-3fc386289db2"), Type = TextBlockType.Text, Text = "You subtly weave your spellcasting into your performance. If the next action you take is to (activity: Cast a Spell), attempt a Performance check against all observers’ Perception DCs. If your Performance check is successful against an observer’s Perception DC, that observer doesn’t notice that you are (activity: Casting a Spell | Cast a Spell), even though normally spells have sensory manifestations that would make spellcasting obvious to those around you, and verbal, somatic, and material components are extremely overt. You hide all of these as part of an ordinary performance." };
            yield return new TextBlock { Id = Guid.Parse("10b72ff9-1463-4ff9-bda6-713e5e261ff5"), Type = TextBlockType.Text, Text = "This hides only the spell’s spellcasting actions and manifestations, not its effects, so an observer might still see a ray streak out from you or see you vanish." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a451ea2a-ee58-4c48-8cd5-98117f165278"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
