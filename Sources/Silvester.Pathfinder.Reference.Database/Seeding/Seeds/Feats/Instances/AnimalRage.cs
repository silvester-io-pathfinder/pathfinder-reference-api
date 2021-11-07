using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnimalRage : Template
    {
        public static readonly Guid ID = Guid.Parse("1514b1db-d667-4941-9d8c-f47202224d2b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Animal Rage",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("45e93351-7c55-4bee-b815-9d3f30b9c537"), Type = TextBlockType.Text, Text = "You transform into your animal. You gain the effects of the 3rd-level (spell: animal form) spell except you use your own statistics, temporary Hit Points, and unarmed attacks instead of those granted by animal form. You also retain the constant abilities of your gear. If your animal is a frog, your tongue’s reach increases to 15 feet. (action: Dismissing | Dismiss) the transformation gains the (trait: rage) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("befb18ba-fce5-4beb-bcf8-0d6c3c604e59"), Instincts.Instances.AnimalInstinct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07a285b6-12d2-4ea7-b9fe-956715b17967"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
