using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationMetallicReactance : Template
    {
        public static readonly Guid ID = Guid.Parse("0056ea8d-d7c4-42b6-abfa-c09caa29774c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Metallic Reactance",
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
            yield return new TextBlock { Id = Guid.Parse("bce7850f-1467-47bd-b5b8-f8c939d01e77"), Type = TextBlockType.Text, Text = $"The metals in your armor are carefully alloyed to ground electricity and protect from acidic chemical reactions. You gain resistance equal to 3 + half your level to acid and electricity damage. When under the effects of {ToMarkdownLink<Models.Entities.Feat>("Overdrive", Feats.Instances.Overdrive.ID)}, the resistance increases by 2." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("993955c2-a2a5-4cc7-b5a2-208d8de75ee8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
