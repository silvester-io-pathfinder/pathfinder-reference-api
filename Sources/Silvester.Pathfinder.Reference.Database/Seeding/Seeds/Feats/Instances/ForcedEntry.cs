using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ForcedEntry : Template
    {
        public static readonly Guid ID = Guid.Parse("14a4ac24-9e83-49e2-a57b-692891cbf0be");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forced Entry",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e807e9d5-38b6-4666-8b92-3a02c1cab453"), Type = TextBlockType.Text, Text = "You are trained to preserve the archaeological value of your location when entering. You don’t take a penalty to (action: Force Open) doors, windows, or containers without a (item: crowbar). If you roll a success on a check to (action: Force Open), you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("4d189565-fb1b-4e26-91e9-1ff5b0301856"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
            builder.HaveSpecificFeat(Guid.Parse("ca107f31-1669-46f7-a101-0cc8a74cc27b"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a5c44e2-db93-4465-9815-07daeb99f733"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
