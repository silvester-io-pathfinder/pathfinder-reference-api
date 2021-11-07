using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CranialDetonation : Template
    {
        public static readonly Guid ID = Guid.Parse("6c009925-eed9-4c5c-9dce-4c4b60b6413e");

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
            yield return new TextBlock { Id = Guid.Parse("7de39d4d-f2b1-450b-89ec-a72489132758"), Type = TextBlockType.Text, Text = "As your magic fells a creature, you take advantage of their flickering consciousness to release a detonation of psychic energy from the creature’s head. Use this amp in place of the psi cantrip’s normal amp entry. Unlike with many amps, you choose to add this amp to a spell after you’ve successfully reduced a non-mindless enemy to 0 Hit Points with the spell, rather than as part of (action: Casting the Spell | Cast a Spell). You can’t use this amp on a (trait: nonlethal) spell." };
            yield return new TextBlock { Id = Guid.Parse("c389b71c-33ca-4463-a575-79875ceff918"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("83da44ec-4285-42e3-81cc-07c45146947e"), Type = TextBlockType.Text, Text = "~ Amp: The enemy you reduced to 0 Hit Points dies (a (trait: death) effect), and its head explodes. If the cantrip reduced more than one foe to 0 Hit Points, choose one head to detonate. The detonation generates a shockwave in a 15-foot emanation around that enemy. Each creature in the emanation takes 1d4 damage per level of the amped spell, with a basic save against your spell DC. You choose a physical or mental shockwave, and the explosion deals force damage with a basic Fortitude save (for a physical shockwave) or mental damage with a basic Will save (for a mental shockwave)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b6512a8e-4cde-4f6c-aa94-c557a9f2d0bd"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
