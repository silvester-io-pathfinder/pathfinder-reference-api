using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BreathControl : Template
    {
        public static readonly Guid ID = Guid.Parse("b8a77e2c-9f24-4d66-acc4-3e7b9824cf79");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Breath Control",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("00cd17f8-5ad6-46db-8692-20a3ba683b97"), Type = TextBlockType.Text, Text = "You have incredible breath control, which grants you advantages when air is hazardous or sparse. You can hold your breath for 25 times as long as usual before suffocating. You gain a +1 circumstance bonus to saving throws against inhaled threats, such as inhaled poisons, and if you roll a success on such a saving throw, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3fb240de-2df4-4bf4-b801-5ef39b6acdce"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
