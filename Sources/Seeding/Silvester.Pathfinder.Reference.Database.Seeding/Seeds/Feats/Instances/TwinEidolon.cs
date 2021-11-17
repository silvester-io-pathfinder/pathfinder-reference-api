using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwinEidolon : Template
    {
        public static readonly Guid ID = Guid.Parse("3f8bf422-aa7b-47f4-b209-ab77df60f564");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twin Eidolon",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait matching your eidolon's tradition ((trait: arcane), (trait: divine), (trait: occult), or (trait: primal)).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aeff59f8-2f4b-4293-9ff5-b129f9bfa9ed"), Type = TextBlockType.Text, Text = "You can transform to match your eidolon. When you (action: Manifest your Eidolon | Manifest Eidolon), you can call upon its powers to transform yourself into a duplicate until it unmanifests. You can’t use this if you (action: Manifest your Eidolon | Manifest Eidolon) in an unusual way, such as (action: Meld into Eidolon)." };
            yield return new TextBlock { Id = Guid.Parse("595150cd-50b1-4e31-85c1-8196b045d8d7"), Type = TextBlockType.Text, Text = "While using Twin Eidolon, you use your eidolon’s statistics other than your mental ability modifiers, including its evolutions. You can’t cast spells (except spells your eidolon could cast), Activate or otherwise benefit from magic items that normally benefit you and not your eidolon, or use other actions it can’t perform. Any of its spells you cast with limited uses count against your eidolon’s uses. You can (action: Manifest your Eidolon | Manifest Eidolon) again to end this effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c8b6d6e-0cfc-4cbf-9c46-fc5caa8f1fd1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
