using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BloodComponentSubstitution : Template
    {
        public static readonly Guid ID = Guid.Parse("d6a3bc5b-0162-4919-a0ed-0384be77dc32");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blood Component Substitution",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f236005b-7d8b-4614-b150-ebede3f74544"), Type = TextBlockType.Text, Text = $"You can bypass the need for incantations and gestures by drawing energy directly from your blood, causing you to visibly glow the color of your blood and crackle with magical energy. When you {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)}, you can replace all verbal, material, or somatic spellcasting components with a blood component. To use a blood component, you lose Hit Points equal to twice the spell's level as the energy in your blood is depleted, and you can't decrease the Hit Points lost in any way. As usual for altering components, this has no effect on the number of actions required to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)}, and your {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} activity gains the {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} trait but not the {ToMarkdownLink<Models.Entities.Trait>("manipulate", Traits.Instances.Manipulate.ID)} trait. You can't use blood components to replace any required part of a spell's cost." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aca75eee-eebd-46ba-8493-2156d7db676c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
