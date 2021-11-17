using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConcealSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("72a796cd-3ee8-479d-ac67-6439942daccb");

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
            yield return new TextBlock { Id = Guid.Parse("2fdf6dad-4d53-44b9-b707-6c01d5f157c3"), Type = TextBlockType.Text, Text = "You can hide your magical gestures and incantations within your speech and movement in an attempt to conceal the fact that you are (activity: Casting a Spell | Cast a Spell). If the next action you use is to (activity: Cast a Spell), attempt a Stealth check against one or more observers’ Perception DCs; if the spell has verbal components, you must also attempt a Deception check against the observers’ Perception DC. If you succeed at your check (or checks) against an observer’s DC, that observer doesn’t notice you’re (activity: Casting a Spell | Cast a Spell), even though material, somatic, and verbal components are usually noticeable and spells normally have sensory manifestations that would make spellcasting obvious to those nearby." };
            yield return new TextBlock { Id = Guid.Parse("4ccbd91e-958f-4c94-93dd-33b09751035b"), Type = TextBlockType.Text, Text = "This ability hides only the spell’s spellcasting actions and manifestations, not its effects, so an observer might still see a ray streak out from you or see you vanish into thin air." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a858549-58f9-4458-aedd-1bf744dd7290"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}