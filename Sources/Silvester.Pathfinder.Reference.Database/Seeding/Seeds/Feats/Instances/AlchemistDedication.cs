using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlchemistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("17759500-7d16-4903-a578-3270f84f4e96");

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
            yield return new TextBlock { Id = Guid.Parse("c5cbe111-5f76-4a84-8b0e-68442f51a959"), Type = TextBlockType.Text, Text = "You put your alchemical interest into practice. You become trained in alchemical bombs and Crafting; if you were already trained in Crafting, you instead become trained in a skill of your choice. You become trained in alchemist class DC." };
            yield return new TextBlock { Id = Guid.Parse("08434d34-93bb-44c7-a7a3-755148ba2660"), Type = TextBlockType.Text, Text = "You gain the alchemist’s infused reagents class feature, gaining a number of reagents each day equal to your level. You also gain the (feat: Alchemical Crafting) feat and four additional formulas for 1st-level alchemical items, as well as the ability to create free items during your daily preparations. Your advanced alchemy level is 1 and doesn’t increase on its own." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("bf764ad4-7d4a-4aaa-9269-cd1a62bad6c7"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1698a18-5b81-461e-a318-e7ffaf386d20"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
