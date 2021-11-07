using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeastGunnerPrimalSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("46671c4c-bdae-4f7e-83d9-6e22e3a3e62c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beast Gunner - Primal Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("5c8cbe7a-4529-4d7e-9654-5ac3761e21fd"), Type = TextBlockType.Text, Text = "You’re trained in primal spell attack rolls and spell DCs. Your key spellcasting ability is Charisma. Add a primal cantrip that requires a spell attack roll to your spell repertoire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a892b822-2ba1-40dc-970b-28095955c9da"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
