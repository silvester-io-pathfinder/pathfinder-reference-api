using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CelestialWord : Template
    {
        public static readonly Guid ID = Guid.Parse("f416612b-49bb-474d-a2f8-0f52dc052bd2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Celestial Word",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("33327637-0661-4b8b-81e6-11e0e504887b"), Type = TextBlockType.Text, Text = $"You can call forth a holy word from the celestial realms to punish your foes. Once per day, you can cast {ToMarkdownLink<Models.Entities.Spell>("divine decree", Spells.Instances.DivineDecree.ID)} as a 7th-level divine innate spell. You must choose good for the spell's alignment, and you can {ToMarkdownLink<Models.Entities.Rule>("Cast the Spell", Rules.Instances.CastASpell.ID)} regardless of whether you worship a deity or what their alignment is." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b17c171e-0aa6-4af9-9c21-8fac270b6deb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
