using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CMDivineSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("4184c9c7-1ae0-4fdb-a662-d84759655d7a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "CM - Divine Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("a8dc1605-0075-47e6-ae03-4f6bd67b9db8"), Type = TextBlockType.Text, Text = "You’re trained in divine spell attack rolls and spell DCs. Your key spellcasting ability is Charisma. Add a divine cantrip that requires a spell attack roll to your spell repertoire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e18b605-9782-42e8-80a9-f873a055c0a7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
