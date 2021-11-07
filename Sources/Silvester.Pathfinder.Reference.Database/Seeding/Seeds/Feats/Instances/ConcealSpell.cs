using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConcealSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("d86f70f3-5eba-441c-a668-1f56cec1cc99");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Conceal Spell",
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
            yield return new TextBlock { Id = Guid.Parse("8d8c112d-5e5e-4500-b7b8-91202ef7b227"), Type = TextBlockType.Text, Text = "You can hide your magical gestures and incantations within your speech and movement in an attempt to conceal the fact that you are (activity: Casting a Spell | Cast a Spell). If the next action you use is to (activity: Cast a Spell), attempt a Stealth check against one or more observers’ Perception DCs; if the spell has verbal components, you must also attempt a Deception check against the observers’ Perception DC. If you succeed at your check (or checks) against an observer’s DC, that observer doesn’t notice you’re (activity: Casting a Spell | Cast a Spell), even though material, somatic, and verbal components are usually noticeable and spells normally have sensory manifestations that would make spellcasting obvious to those nearby." };
            yield return new TextBlock { Id = Guid.Parse("dcb086f5-f896-4350-8e28-e447ecae404a"), Type = TextBlockType.Text, Text = "This ability hides only the spell’s spellcasting actions and manifestations, not its effects, so an observer might still see a ray streak out from you or see you vanish into thin air." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab112f53-9deb-40a8-ac1c-2f36e9063e7a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
