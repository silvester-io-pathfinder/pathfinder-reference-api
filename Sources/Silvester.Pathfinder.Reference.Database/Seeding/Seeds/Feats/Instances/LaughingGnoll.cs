using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LaughingGnoll : Template
    {
        public static readonly Guid ID = Guid.Parse("033138b5-8aa4-4db1-b65d-3bcf291f483c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Laughing Gnoll",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f7a1066-c3c5-4a2d-a1da-501ad60f0728"), Type = TextBlockType.Text, Text = "A gnoll’s sinister giggle is a sound of warning and threat. You gain the (feat: Battle Cry) skill feat. You don’t take a penalty when you attempt to (action: Demoralize) a creature that doesn’t understand your language." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("df748c86-db1b-42fc-9f8d-d89d35ce00f9"), Proficiencies.Instances.Master.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38cf3c6a-a31e-498e-856e-4a034b1efc68"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
