using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BondedFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("1f215b87-3f81-45d7-93fd-8998a8246304");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bonded Focus",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("568f3ceb-e1ce-4e15-894c-42b02a07539d"), Type = TextBlockType.Text, Text = "Your connection to your bonded item increases your focus pool. If you have spent at least 2 Focus Points since the last time you (action: Refocused | Refocus) and your bonded item is in your possession, you recover 2 Focus Points when you (Activity: Refocus) instead of 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("ff248e9f-231f-4f06-b00c-65a92a73c9cc"), ClassFeatures.Wizards.ArcaneBond.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67789780-bea1-4862-9b9c-6ab5204fc825"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
