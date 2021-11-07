using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EsotericAntithesis : Template
    {
        public static readonly Guid ID = Guid.Parse("ce65c4f3-f9d8-4103-9c03-5bc577a5c364");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Esoteric Antithesis",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7f2cc56e-d731-4678-a684-d51a146f6485"), Type = TextBlockType.Text, Text = "You search through your esoterica to find the right trinket that will apply a weakness to your attacks against the creature you (feat: Found Flaws|Find Flaws) in. You Interact to apply specific esoterica to yourself and your weapons; you can perform this (action: Interact) action with the hand holding your implement. Your unarmed and weapon (action: Strikes|Strike) against the creature become magical if they weren’t already, and you cause them to apply one of the creature’s weaknesses even if they don’t deal the correct type of damage. If the creature has a weakness with a value of 2 + half your level or higher, set the type of weakness to the creature’s highest weakness. Otherwise, you create a custom weakness with a value equal to 2 + half your level; this weakness applies only to your (action: Strikes|Strike). For example, against a tyrant, you might attach a chain broken to free a captive. This effect lasts until you use (feat: Find Flaws) again." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d65e875a-1c7c-4ab5-93ed-00ce36e2c12f"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
