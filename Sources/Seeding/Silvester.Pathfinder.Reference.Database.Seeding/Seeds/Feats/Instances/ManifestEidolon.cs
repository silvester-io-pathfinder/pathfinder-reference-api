using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ManifestEidolon : Template
    {
        public static readonly Guid ID = Guid.Parse("9fdcea5f-4dd4-43bd-b457-2c723e06c8d2");

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
            yield return new TextBlock { Id = Guid.Parse("04601c20-087a-4227-9950-5262666db4e9"), Type = TextBlockType.Text, Text = "Your eidolon appears in an open space adjacent to you, and can then take a single action. If your eidolon was already manifested, you unmanifest it instead." };
            yield return new TextBlock { Id = Guid.Parse("e2b94a41-e048-4cba-9acf-3b321bb0bed0"), Type = TextBlockType.Text, Text = "The conduit that allows your eidolon to manifest is also a tether between you. Your eidolon must remain within 100 feet of you at all times and can't willingly go beyond that limit. If forced beyond this distance, or if you are reduced to 0 Hit Points, your eidolon's physical form dissolves: your eidolon unmanifests, and you need to use Manifest Eidolon to manifest it again." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7b9dd1b-bc3b-4e84-bd8f-b0b786a5de22"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
