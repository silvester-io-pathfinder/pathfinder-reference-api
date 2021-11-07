using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AutomatonArmamentClaw : Template
    {
        public static readonly Guid ID = Guid.Parse("cfc16710-ef2d-4cfa-b503-3b9b9af33044");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Automaton Armament - Claw",
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
            yield return new TextBlock { Id = Guid.Parse("ef602fe9-737b-4dc5-860e-90bb707e2568"), Type = TextBlockType.Text, Text = "You gain a claw unarmed attack which deals 1d4 slashing damage, is in the brawling group, and has the (trait: agile), (trait: finesse), and (trait: unarmed) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20045fd9-4c40-417f-bd33-595bc3b8419c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
