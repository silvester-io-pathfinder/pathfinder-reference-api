using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlchemistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("113282f8-d3c9-4fc1-b167-2a7579d29c46");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Alchemist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the alchemist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("25eccefe-5695-4169-92ac-8d6e9a3151a9"), Type = TextBlockType.Text, Text = "You put your alchemical interest into practice. You become trained in alchemical bombs and Crafting; if you were already trained in Crafting, you instead become trained in a skill of your choice. You become trained in alchemist class DC." };
            yield return new TextBlock { Id = Guid.Parse("45c8b6cf-e351-4ca7-81a1-539ef7079b7f"), Type = TextBlockType.Text, Text = "You gain the alchemist's infused reagents class feature, gaining a number of reagents each day equal to your level. You also gain the (feat: Alchemical Crafting) feat and four additional formulas for 1st-level alchemical items, as well as the ability to create free items during your daily preparations. Your advanced alchemy level is 1 and doesn't increase on its own." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("b4bf4637-42f0-4f9b-81e5-a10ce7b671a7"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92dc6676-095f-4ccc-aade-4eaa21402516"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
