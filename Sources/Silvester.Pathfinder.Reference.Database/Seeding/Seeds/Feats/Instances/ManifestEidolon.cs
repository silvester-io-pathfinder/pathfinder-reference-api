using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ManifestEidolon : Template
    {
        public static readonly Guid ID = Guid.Parse("2857f20c-e7c0-4bfb-88c7-6b44378fa919");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Manifest Eidolon",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This activity has the trait matching your eidolon's tradition ((trait: arcane), (trait: divine), (trait: occult), or (trait: primal)).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0f4127f7-2004-4776-9377-d348e58aa2db"), Type = TextBlockType.Text, Text = "Your eidolon appears in an open space adjacent to you, and can then take a single action. If your eidolon was already manifested, you unmanifest it instead." };
            yield return new TextBlock { Id = Guid.Parse("9a7cc95b-bd61-49ad-9545-8abcc102e2d6"), Type = TextBlockType.Text, Text = "The conduit that allows your eidolon to manifest is also a tether between you. Your eidolon must remain within 100 feet of you at all times and can’t willingly go beyond that limit. If forced beyond this distance, or if you are reduced to 0 Hit Points, your eidolon’s physical form dissolves: your eidolon unmanifests, and you need to use Manifest Eidolon to manifest it again." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ddcbfc0f-481d-457c-a97f-37c47eefd347"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
