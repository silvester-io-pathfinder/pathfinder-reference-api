using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationAntimagicPlating : Template
    {
        public static readonly Guid ID = Guid.Parse("42d11a77-1a68-4e45-8edb-d77313413c7b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Antimagic Plating",
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
            yield return new TextBlock { Id = Guid.Parse("c2d42c08-22df-411b-9094-a70cda2acfb7"), Type = TextBlockType.Text, Text = "Whether you used some clever adaptation of the magic-negating skymetal known as noqual or created magical protections of your own design, you’ve strengthened your armor against magic. While wearing the armor, you gain a +1 circumstance bonus to all saving throws against spells and to AC against spells. Against spells that target the armor directly (like (spell: heat metal)), you instead gain a +4 circumstance bonus to all saving throws and to AC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5df9e5bb-f7e3-46a6-b563-0bf346bde3d0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
