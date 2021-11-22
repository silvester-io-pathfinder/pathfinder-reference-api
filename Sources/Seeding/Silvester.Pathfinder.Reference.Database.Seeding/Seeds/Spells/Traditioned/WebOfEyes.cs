using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WebOfEyes : Template
    {
        public static readonly Guid ID = Guid.Parse("c0f3a9ff-aa80-4d36-b8ae-0fadaeb6ab99");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Web of Eyes",
                Level = 3,
                Range = "30 feet.",
                Duration = "10 minutes.",
                Targets = "Up to 5 willing creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7746f4d-bb43-4063-9a36-62c3bc3d60d4"), Type = TextBlockType.Text, Text = "You place an invisible scrying sensor on each target just above their eyes. Each sensor looks where that target looks, and all the targets can link their vision briefly to help notice things one target sees but the others might not. Each target can use an action, which has the concentrate trait, to share what it sees with any number of other targets until the start of its next turn. Only one creature can share its vision at a time, so if another target takes this action, the effect ends for any target that was previously sharing its vision." };
            yield return new TextBlock { Id = Guid.Parse("d01646a9-845e-4eb2-babd-928302dcf636"), Type = TextBlockType.Text, Text = "This improves how well the recipients can perceive anything the sharing creature is looking at. For instance, if a creature is undetected to a recipient but observed by the sharing creature, the creature becomes observed by the recipient as well. Typically, the creature is seen as a glowing outline superimposed on its position. This might allow the recipient to target a creature it couldn�t otherwise; however, cover and line of effect still might prevent or impede targeting and attacks. This can only improve the recipient�s vision, not reduce it; for example, if an enemy was undetected by the sharing creature and observed by a recipient, the recipient would still clearly observe the enemy." };
            yield return new TextBlock { Id = Guid.Parse("10a7f6be-32c8-471e-b847-66369b28c33b"), Type = TextBlockType.Text, Text = "Once the vision sharing stops, the benefit ends. Whether a creature is hidden or undetected is still based on the last information a target had before the vision sharing ended. For example, that means if a creature is behind a wall but hasn�t moved, it�s still hidden rather than undetected by a recipient that witnessed its current position." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Scrying.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("940ea34a-b302-4d29-aa2a-1d5a8e15dddb"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 140
            };
        }
    }
}
