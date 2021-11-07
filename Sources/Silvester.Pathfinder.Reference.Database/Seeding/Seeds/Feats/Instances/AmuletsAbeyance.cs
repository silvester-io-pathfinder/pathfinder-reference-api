using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AmuletsAbeyance : Template
    {
        public static readonly Guid ID = Guid.Parse("342796d9-255a-4c88-b241-765026f0fbac");

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
            yield return new TextBlock { Id = Guid.Parse("3f601aab-688b-4ada-82dc-3c393a756ca6"), Type = TextBlockType.Text, Text = "You forcefully present your amulet to turn away harm. You or a target ally within 15 feet gain resistance to all damage against the triggering damage. The resistance is equal to 2 + your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("269b4612-b81b-4c15-a108-3fe8b20b7ad9"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
