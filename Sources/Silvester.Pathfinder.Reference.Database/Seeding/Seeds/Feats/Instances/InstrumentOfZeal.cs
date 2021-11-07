using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InstrumentOfZeal : Template
    {
        public static readonly Guid ID = Guid.Parse("bc805ec9-2651-4f7b-b14a-752447fb0f8a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Instrument of Zeal",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fba0467a-636c-41ef-bc8d-3524d1ce03fb"), Type = TextBlockType.Text, Text = "Divine energy fills your weapon. Whenever you critically hit a foe with (feat: Blade of Justice) or a (feat: Retributive Strike), your attack adds an extra damage die and the target is slowed 1 on its next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("6162f300-04d4-46c0-81ff-d81d8c23a977"), DivineAllies.Instances.Blade.ID);
            builder.HaveSpecificTenet(Guid.Parse("f7972bcf-654f-4056-b41d-60a16cc09e76"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2fe178a9-b451-48ee-b628-1482c22bda1b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
