using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AmuletsAbeyance : Template
    {
        public static readonly Guid ID = Guid.Parse("600572d5-f173-4824-9741-83486f14df85");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Amulet's Abeyance",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "The subject of your Esoteric Antithesis would damage you or an ally within 15 feet of you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("80f83d3c-0fcb-4bc9-a678-25ae0afa0244"), Type = TextBlockType.Text, Text = "You forcefully present your amulet to turn away harm. You or a target ally within 15 feet gain resistance to all damage against the triggering damage. The resistance is equal to 2 + your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01c7ac01-9dac-4d49-be7b-8c7eedd43d2f"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
