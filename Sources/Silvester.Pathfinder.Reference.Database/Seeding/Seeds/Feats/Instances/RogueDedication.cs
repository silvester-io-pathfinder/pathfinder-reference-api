using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RogueDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("31d43246-056d-43cf-a727-fa054ac8ea7d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rogue Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot gain another dedication feat until you have gained two other feats from the rogue archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("88ede565-61ae-44ca-b40e-09848c1ebcf4"), Type = TextBlockType.Text, Text = "You gain a skill feat and the rogue’s surprise attack class feature (page 181). You become trained in light armor. In addition, you become trained in Stealth or Thievery plus one skill of your choice; if you are already trained in both Stealth and Thievery, you become trained in an additional skill of your choice. You become trained in rogue class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("e7107021-3dcc-4fc9-b2cc-4c5964d52583"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad6a7009-1365-4655-86ae-b52faf983306"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
