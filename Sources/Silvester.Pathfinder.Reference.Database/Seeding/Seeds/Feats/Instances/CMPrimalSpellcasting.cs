using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CMPrimalSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("84d04b21-4a8c-45fb-bc5a-7b1d4255f833");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "CM - Primal Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("77193697-08ea-4e91-a683-fadbdbc6992e"), Type = TextBlockType.Text, Text = "You’re trained in primal spell attack rolls and spell DCs. Your key spellcasting ability is Charisma. Add a primal cantrip that requires a spell attack roll to your spell repertoire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e6e786a-e1ab-4739-8901-d7c9a518aa66"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
