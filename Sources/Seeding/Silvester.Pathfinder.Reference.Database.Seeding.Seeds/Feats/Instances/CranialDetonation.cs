using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CranialDetonation : Template
    {
        public static readonly Guid ID = Guid.Parse("7fb8a72c-dd25-40df-8079-7f8841f6edf4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cranial Detonation",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3e65892e-d80b-46d3-8fc0-aa75a6c7cf8b"), Type = TextBlockType.Text, Text = $"As your magic fells a creature, you take advantage of their flickering consciousness to release a detonation of psychic energy from the creature's head. Use this amp in place of the psi cantrip's normal amp entry. Unlike with many amps, you choose to add this amp to a spell after you've successfully reduced a non-mindless enemy to 0 Hit Points with the spell, rather than as part of {ToMarkdownLink<Models.Entities.Rule>("Casting the Spell", Rules.Instances.CastASpell.ID)}. You can't use this amp on a {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)} spell." };
            yield return new TextBlock { Id = Guid.Parse("ebd90417-0acd-4e28-abef-cd9cae1d4f3d"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("ca48b8c5-b441-4a56-b4b3-0a790595f9ba"), Type = TextBlockType.Text, Text = $"~ Amp: The enemy you reduced to 0 Hit Points dies (a {ToMarkdownLink<Models.Entities.Trait>("death", Traits.Instances.Death.ID)} effect), and its head explodes. If the cantrip reduced more than one foe to 0 Hit Points, choose one head to detonate. The detonation generates a shockwave in a 15-foot emanation around that enemy. Each creature in the emanation takes 1d4 damage per level of the amped spell, with a basic save against your spell DC. You choose a physical or mental shockwave, and the explosion deals force damage with a basic Fortitude save (for a physical shockwave) or mental damage with a basic Will save (for a mental shockwave)." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53ff42b4-22e4-4768-a882-60513e220fac"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
