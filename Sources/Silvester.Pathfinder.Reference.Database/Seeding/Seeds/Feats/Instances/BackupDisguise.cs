using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BackupDisguise : Template
    {
        public static readonly Guid ID = Guid.Parse("2f43d52e-e6f5-42b2-be53-9a10f24aaeb6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Backup Disguise",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe2388f4-47a6-4c44-973e-c638b52e775b"), Type = TextBlockType.Text, Text = "~ Access: member of the Firebrands (second Rank)" };
            yield return new TextBlock { Id = Guid.Parse("2f9ae0a5-a364-44c9-b805-cb4d2e6a965c"), Type = TextBlockType.Text, Text = "You have a specific disguise that you keep at the ready, worn underneath your outer garment. You can change into this disguise to (action: Impersonate) as a 3-action activity. If you have master proficiency in Deception, it is instead a 2-action activity, and if you have legendary proficiency, it is a single action. You can create a new backup disguise by spending the normal amount of time it takes you to (action: Impersonate), but you can have only one backup disguise at a time. Having a backup disguise doesn’t allow you to remove your armor or any other complex piece of clothing any more quickly, but once you have those off, the disguise is readily available. Because you have the backup disguise at the ready, it’s possible that a thorough search might reveal some elements of the disguise (see (action: Conceal an Object) in the Stealth skill)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5dadb3d0-31c7-40a5-9ced-691d668d44d2"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6741a495-ce0a-4acf-ad0a-31ed0ed31455"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
