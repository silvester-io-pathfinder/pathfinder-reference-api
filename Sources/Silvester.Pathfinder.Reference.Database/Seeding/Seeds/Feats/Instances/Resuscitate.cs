using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Resuscitate : Template
    {
        public static readonly Guid ID = Guid.Parse("1a030661-8966-4781-ac39-33b90f99e1eb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resuscitate",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32162f60-55f8-4ae0-9c07-2e143bc1638e"), Type = TextBlockType.Text, Text = "You can use Medicine to resuscitate the dead. Attempt a DC 40 Medicine check to revive a dead creature that has been dead for no more than 3 rounds. If you succeed, the target returns to life with the effects of (spell: raise dead), except it still has the wounded condition it had before dying, increased by 1 (or wounded 1 if it wasn’t wounded before dying). Whether you succeed or fail, the target is temporarily immune to Resuscitate for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6679d73b-ed1c-42cd-bcdd-f25b3f206f6c"), Feats.Instances.MedicDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("79cd5349-2463-4417-a59c-a495d8815300"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec29688a-b6a9-4416-a94a-b4335d13ad3b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
