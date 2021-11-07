using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CMAlreadyASpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("5757d2d2-0d3a-4a36-b911-cd1333aa6357");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "CM - Already a Spellcaster",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0626758d-b033-4d04-b48b-ff339315f6d7"), Type = TextBlockType.Text, Text = "You learn one additional cantrip from your spellcasting tradition. This cantrip must require a spell attack roll." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82889587-b6a8-41c2-8bcd-994e085b29e6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
